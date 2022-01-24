using BinanceAPITrade.Models;
using BinanceAPITrade.Utils;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeleBot;
using TeleBot.Entities;

namespace BinanceAPITrade
{
    public partial class frmPrincipal : Form
    {
        Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public static TeleBot.TeleBot Bot = new TeleBot.TeleBot("XXXXXXXXX:XXXXXXXX-XXXXXXXXXX-X");
        public static bool connectedToBot;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaveKeys_Click(object sender, EventArgs e)
        {
            configuration.AppSettings.Settings["ApiUrl"].Value = txtApiUrl.Text;
            configuration.AppSettings.Settings["ApiKey"].Value = txtApiKey.Text;
            configuration.AppSettings.Settings["SecretKey"].Value = txtSecretKey.Text;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txtApiUrl.Text = configuration.AppSettings.Settings["ApiUrl"].Value;
            txtApiKey.Text = configuration.AppSettings.Settings["ApiKey"].Value;
            txtSecretKey.Text = configuration.AppSettings.Settings["SecretKey"].Value;
        }

        private void btnGetCryptos_Click(object sender, EventArgs e)
        {
            // Obtiene todos los cryptos con su precio
            AppendTextBox("Getting crypto...");
            AppendTextBox(Environment.NewLine);

            var client = new RestClient(txtApiUrl.Text + "/api/v3/ticker/price");
            var request = new RestRequest(Method.GET);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);

            AppendTextBox("Getting crypto status: " + response.StatusCode.ToString());
            AppendTextBox(Environment.NewLine);
            AppendTextBox(Environment.NewLine);

            List<SymbolPrice> listSymbolPrice = new List<SymbolPrice>();

            if(chkBTC.Checked)
            {
                //listSymbolPrice = JsonConvert.DeserializeObject<List<SymbolPrice>>(response.Content).Where(s => s.symbol.Contains("BTC")).OrderBy(l => l.symbol).ToList();
                listSymbolPrice = JsonConvert.DeserializeObject<List<SymbolPrice>>(response.Content).Where(s => s.symbol.EndsWith("BTC")).OrderBy(l => l.symbol).ToList();
            }
            else
            {
                listSymbolPrice = JsonConvert.DeserializeObject<List<SymbolPrice>>(response.Content).OrderBy(l => l.symbol).ToList();
            }

            datCryptos.DataSource = DataTableUtil.ToDataTable(listSymbolPrice);
        }

        private void txtSearchSymbol_TextChanged(object sender, EventArgs e)
        {
            (datCryptos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Symbol LIKE '%{0}%'", txtSearchSymbol.Text);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (datCryptos.SelectedCells.Count > 0)
            {
                // Obtiene el simbolo de la crypto seleccionada
                int selectedrowindex = datCryptos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = datCryptos.Rows[selectedrowindex];
                string selectedSymbol = Convert.ToString(selectedRow.Cells["Symbol"].Value);

                BuyCrypto(selectedSymbol);
            }
            else
            {
                AppendTextBox("ERROR: Nothing selected in the table!");
                AppendTextBox(Environment.NewLine);
                AppendTextBox(Environment.NewLine);
            }
        }

        private void BuyCrypto(string selectedSymbol)
        {
            string timestamp;
            string signature;

            // Obtiene el porcentaje (%) para evitar pre-pump
            AppendTextBox("Getting % price change within 24hs of " + selectedSymbol + "...");
            AppendTextBox(Environment.NewLine);

            var clientPercent = new RestClient(txtApiUrl.Text + "/api/v3/ticker/24hr?symbol=" + selectedSymbol);
            var requestPercent = new RestRequest(Method.GET);
            requestPercent.AddHeader("content-type", "application/json");
            IRestResponse responsePercent = clientPercent.Execute(requestPercent);

            Ticker ticker = new Ticker();
            ticker = JsonConvert.DeserializeObject<Ticker>(responsePercent.Content);

            AppendTextBox("The % price change within 24hs is: " + ticker.priceChangePercent.ToString() + "%");
            AppendTextBox(Environment.NewLine);
            AppendTextBox(Environment.NewLine);

            if (ticker.priceChangePercent > Convert.ToDecimal(txtPercentPriceChange.Text))
            {
                AppendTextBox("The current % is declined: " + ticker.priceChangePercent.ToString() + "% > " + txtPercentPriceChange.Text + "%");
                AppendTextBox(Environment.NewLine);
                AppendTextBox(Environment.NewLine);
            }
            else
            {
                // Obtiene el precio actual de la Crypto
                AppendTextBox("Getting price of symbol " + selectedSymbol + "...");
                AppendTextBox(Environment.NewLine);

                var client = new RestClient(txtApiUrl.Text + "/api/v3/ticker/price?symbol=" + selectedSymbol);
                var request = new RestRequest(Method.GET);
                request.AddHeader("content-type", "application/json");
                IRestResponse response = client.Execute(request);

                AppendTextBox("Getting price status: " + response.StatusCode);
                AppendTextBox(Environment.NewLine);

                SymbolPrice symbolPrice = new SymbolPrice();
                symbolPrice = JsonConvert.DeserializeObject<SymbolPrice>(response.Content);
                decimal priceToBuy = symbolPrice.price;

                AppendTextBox(selectedSymbol + " price: " + priceToBuy);
                AppendTextBox(Environment.NewLine);
                AppendTextBox(Environment.NewLine);

                // Obtiene la cantidad de BTC que tenemos actualmente en nuestra cartera
                timestamp = BinanceUtil.GetTimestamp().ToString();
                signature = BinanceUtil.CreateSignature("timestamp=" + timestamp, txtSecretKey.Text);

                // Selecciona la crypto desde donde se va a comprar
                string selectedCryptoFrom;

                if (rdbBNB.Checked)
                    selectedCryptoFrom = "BNB";
                else if (rdbUSDT.Checked)
                    selectedCryptoFrom = "USDT";
                else if (rdbETH.Checked)
                    selectedCryptoFrom = "ETH";
                else if (rdbBUSD.Checked)
                    selectedCryptoFrom = "BUSD";
                else
                    selectedCryptoFrom = "BTC";

                AppendTextBox("Getting available " + selectedCryptoFrom + "...");
                AppendTextBox(Environment.NewLine);

                var clientAccount = new RestClient(txtApiUrl.Text + "/api/v3/account?timestamp=" + timestamp + "&signature=" + signature);
                var requestAccount = new RestRequest(Method.GET);
                requestAccount.AddHeader("content-type", "application/json");
                requestAccount.AddHeader("X-MBX-APIKEY", txtApiKey.Text);
                IRestResponse responseAccount = clientAccount.Execute(requestAccount);

                AppendTextBox("Getting available " + selectedCryptoFrom + " status: " + responseAccount.StatusCode);
                AppendTextBox(Environment.NewLine);

                AccountInformation accountInformation = new AccountInformation();
                accountInformation = JsonConvert.DeserializeObject<AccountInformation>(responseAccount.Content);

                Balance symbolPriceFrom = accountInformation.balances.Where(b => b.asset == selectedCryptoFrom).FirstOrDefault();
                AppendTextBox(selectedCryptoFrom + " available: " + symbolPriceFrom.free);
                AppendTextBox(Environment.NewLine);
                AppendTextBox(Environment.NewLine);

                // Realiza el calculo para comprar
                AppendTextBox("Calculatting quantity to buy...");
                AppendTextBox(Environment.NewLine);

                decimal quantityToBuyCalculation;

                if (rdb25.Checked)
                    quantityToBuyCalculation = (25 * (symbolPriceFrom.free / priceToBuy)) / 100;
                else if (rdb50.Checked)
                    quantityToBuyCalculation = (50 * (symbolPriceFrom.free / priceToBuy)) / 100;
                else if (rdb75.Checked)
                    quantityToBuyCalculation = (75 * (symbolPriceFrom.free / priceToBuy)) / 100;
                else
                    quantityToBuyCalculation = (symbolPriceFrom.free / priceToBuy);

                string quantityToBuy = quantityToBuyCalculation.ToString().Replace(",", ".");

                string qty = quantityToBuy;

                var a = qty.IndexOf(".");
                if (a != -1)
                {
                    var parteEntera = Convert.ToInt32(qty.Substring(0, a));
                    if (parteEntera > 0)
                    {
                        quantityToBuy = parteEntera.ToString();
                    }
                    else
                    {
                        if (qty.Substring(a).Count() <= 7)
                            quantityToBuy = qty;
                        else
                            quantityToBuy = qty.Substring(0, a + 7);
                    }
                }
                else
                {
                    quantityToBuy = qty;
                }

                AppendTextBox("Result of calculation: " + quantityToBuy);
                AppendTextBox(Environment.NewLine);
                AppendTextBox(Environment.NewLine);

                // Realiza la compra   !!!!!!!!!!!!!!!!!!!!!!!!

                timestamp = BinanceUtil.GetTimestamp().ToString();
                signature = BinanceUtil.CreateSignature("symbol=" + selectedSymbol + "&side=BUY&type=MARKET&quantity=" + quantityToBuy + "&newClientOrderId=api_trader&newOrderRespType=FULL&timestamp=" + timestamp, txtSecretKey.Text);

                AppendTextBox("Buying " + selectedSymbol + "...");
                AppendTextBox(Environment.NewLine);

                //var clientBuy = new RestClient(txtApiUrl.Text + "/api/v3/order/test?symbol=" + selectedSymbol + "&side=BUY&type=MARKET&quantity=" + quantityToBuy + "&newClientOrderId=api_trader&newOrderRespType=ACK&timestamp=" + timestamp + "&signature=" + signature);
                var clientBuy = new RestClient(txtApiUrl.Text + "/api/v3/order?symbol=" + selectedSymbol + "&side=BUY&type=MARKET&quantity=" + quantityToBuy + "&newClientOrderId=api_trader&newOrderRespType=FULL&timestamp=" + timestamp + "&signature=" + signature);
                var requestBuy = new RestRequest(Method.POST);
                requestBuy.AddHeader("content-type", "application/json");
                requestBuy.AddHeader("X-MBX-APIKEY", txtApiKey.Text);
                IRestResponse responseBuy = clientBuy.Execute(requestBuy);

                AppendTextBox("Buy " + selectedSymbol + " status: " + responseBuy.StatusCode);
                AppendTextBox(Environment.NewLine);
                AppendTextBox(Environment.NewLine);
                AppendTextBox("Buy result: " + responseBuy.Content);
                AppendTextBox(Environment.NewLine);
                AppendTextBox(Environment.NewLine);
            }
        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "";
        }

        private void btnConnectBot_Click(object sender, EventArgs e)
        {
            grpTelegramConnection.BackColor = Color.Green;
            connectedToBot = true;
            Bot.OnMessageReceived += OnMessageReceived;
        }

        private void OnMessageReceived(TeleBot.Entities.Message message)
        {
            // Get mesage sender information
            MessageSender sender = (MessageSender)message.Chat ?? message.From;

            Console.WriteLine(message.Text ?? "");

            if (string.IsNullOrEmpty(message.Text))
                return;

            try
            {
                if (!string.IsNullOrEmpty(message.Text))
                {
                    grpTelegramConnection.BackColor = Color.Red;
                    connectedToBot = false;
                    Bot.OnMessageReceived -= OnMessageReceived;

                    BuyCrypto(message.Text.Trim().ToUpper() + "BTC");
                }
                    
            }
            catch (Exception ex)
            {
                grpTelegramConnection.BackColor = Color.Red;
                connectedToBot = false;
                Bot.OnMessageReceived -= OnMessageReceived;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            grpTelegramConnection.BackColor = Color.Red;
            connectedToBot = false;
            Bot.OnMessageReceived -= OnMessageReceived;
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            txtConsole.Text += value;
        }
    }
}
