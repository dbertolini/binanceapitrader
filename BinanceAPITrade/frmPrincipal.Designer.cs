
namespace BinanceAPITrade
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetCryptos = new System.Windows.Forms.Button();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.lblSecretKey = new System.Windows.Forms.Label();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.datCryptos = new System.Windows.Forms.DataGridView();
            this.btnSaveKeys = new System.Windows.Forms.Button();
            this.txtSearchSymbol = new System.Windows.Forms.TextBox();
            this.lblSearchSymbol = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.lblConsole = new System.Windows.Forms.Label();
            this.btnClearConsole = new System.Windows.Forms.Button();
            this.txtApiUrl = new System.Windows.Forms.TextBox();
            this.lblApiUrl = new System.Windows.Forms.Label();
            this.chkBTC = new System.Windows.Forms.CheckBox();
            this.rdbBNB = new System.Windows.Forms.RadioButton();
            this.rdbBTC = new System.Windows.Forms.RadioButton();
            this.rdbUSDT = new System.Windows.Forms.RadioButton();
            this.rdbETH = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBUSD = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb25 = new System.Windows.Forms.RadioButton();
            this.rdb50 = new System.Windows.Forms.RadioButton();
            this.rdb100 = new System.Windows.Forms.RadioButton();
            this.rdb75 = new System.Windows.Forms.RadioButton();
            this.txtPercentPriceChange = new System.Windows.Forms.TextBox();
            this.lblPercentChangePrice = new System.Windows.Forms.Label();
            this.btnConnectBot = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.grpTelegramConnection = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.datCryptos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetCryptos
            // 
            this.btnGetCryptos.Location = new System.Drawing.Point(17, 162);
            this.btnGetCryptos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetCryptos.Name = "btnGetCryptos";
            this.btnGetCryptos.Size = new System.Drawing.Size(211, 28);
            this.btnGetCryptos.TabIndex = 0;
            this.btnGetCryptos.Text = "Get cryptos";
            this.btnGetCryptos.UseVisualStyleBackColor = true;
            this.btnGetCryptos.Click += new System.EventHandler(this.btnGetCryptos_Click);
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(105, 48);
            this.txtApiKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(744, 22);
            this.txtApiKey.TabIndex = 1;
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(33, 52);
            this.lblApiKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(58, 16);
            this.lblApiKey.TabIndex = 2;
            this.lblApiKey.Text = "API Key:";
            // 
            // lblSecretKey
            // 
            this.lblSecretKey.AutoSize = true;
            this.lblSecretKey.Location = new System.Drawing.Point(16, 84);
            this.lblSecretKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecretKey.Name = "lblSecretKey";
            this.lblSecretKey.Size = new System.Drawing.Size(76, 16);
            this.lblSecretKey.TabIndex = 4;
            this.lblSecretKey.Text = "Secret Key:";
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(105, 80);
            this.txtSecretKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(744, 22);
            this.txtSecretKey.TabIndex = 3;
            // 
            // datCryptos
            // 
            this.datCryptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datCryptos.Location = new System.Drawing.Point(15, 256);
            this.datCryptos.Margin = new System.Windows.Forms.Padding(4);
            this.datCryptos.Name = "datCryptos";
            this.datCryptos.RowHeadersWidth = 51;
            this.datCryptos.Size = new System.Drawing.Size(380, 330);
            this.datCryptos.TabIndex = 5;
            // 
            // btnSaveKeys
            // 
            this.btnSaveKeys.Location = new System.Drawing.Point(737, 112);
            this.btnSaveKeys.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveKeys.Name = "btnSaveKeys";
            this.btnSaveKeys.Size = new System.Drawing.Size(113, 28);
            this.btnSaveKeys.TabIndex = 6;
            this.btnSaveKeys.Text = "Save Keys";
            this.btnSaveKeys.UseVisualStyleBackColor = true;
            this.btnSaveKeys.Click += new System.EventHandler(this.btnSaveKeys_Click);
            // 
            // txtSearchSymbol
            // 
            this.txtSearchSymbol.Location = new System.Drawing.Point(127, 224);
            this.txtSearchSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchSymbol.Name = "txtSearchSymbol";
            this.txtSearchSymbol.Size = new System.Drawing.Size(267, 22);
            this.txtSearchSymbol.TabIndex = 7;
            this.txtSearchSymbol.TextChanged += new System.EventHandler(this.txtSearchSymbol_TextChanged);
            // 
            // lblSearchSymbol
            // 
            this.lblSearchSymbol.AutoSize = true;
            this.lblSearchSymbol.Location = new System.Drawing.Point(13, 228);
            this.lblSearchSymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchSymbol.Name = "lblSearchSymbol";
            this.lblSearchSymbol.Size = new System.Drawing.Size(101, 16);
            this.lblSearchSymbol.TabIndex = 8;
            this.lblSearchSymbol.Text = "Search symbol:";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(417, 256);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(209, 59);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(756, 256);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(453, 329);
            this.txtConsole.TabIndex = 3;
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.Location = new System.Drawing.Point(752, 228);
            this.lblConsole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(61, 16);
            this.lblConsole.TabIndex = 8;
            this.lblConsole.Text = "Console:";
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.Location = new System.Drawing.Point(1101, 224);
            this.btnClearConsole.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Size = new System.Drawing.Size(109, 25);
            this.btnClearConsole.TabIndex = 0;
            this.btnClearConsole.Text = "Clear";
            this.btnClearConsole.UseVisualStyleBackColor = true;
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // txtApiUrl
            // 
            this.txtApiUrl.Location = new System.Drawing.Point(105, 16);
            this.txtApiUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtApiUrl.Name = "txtApiUrl";
            this.txtApiUrl.Size = new System.Drawing.Size(744, 22);
            this.txtApiUrl.TabIndex = 1;
            // 
            // lblApiUrl
            // 
            this.lblApiUrl.AutoSize = true;
            this.lblApiUrl.Location = new System.Drawing.Point(28, 20);
            this.lblApiUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApiUrl.Name = "lblApiUrl";
            this.lblApiUrl.Size = new System.Drawing.Size(62, 16);
            this.lblApiUrl.TabIndex = 2;
            this.lblApiUrl.Text = "API URL:";
            // 
            // chkBTC
            // 
            this.chkBTC.AutoSize = true;
            this.chkBTC.Location = new System.Drawing.Point(264, 167);
            this.chkBTC.Margin = new System.Windows.Forms.Padding(4);
            this.chkBTC.Name = "chkBTC";
            this.chkBTC.Size = new System.Drawing.Size(109, 20);
            this.chkBTC.TabIndex = 9;
            this.chkBTC.Text = "Only with BTC";
            this.chkBTC.UseVisualStyleBackColor = true;
            // 
            // rdbBNB
            // 
            this.rdbBNB.AutoSize = true;
            this.rdbBNB.Location = new System.Drawing.Point(21, 91);
            this.rdbBNB.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBNB.Name = "rdbBNB";
            this.rdbBNB.Size = new System.Drawing.Size(54, 20);
            this.rdbBNB.TabIndex = 10;
            this.rdbBNB.Text = "BNB";
            this.rdbBNB.UseVisualStyleBackColor = true;
            // 
            // rdbBTC
            // 
            this.rdbBTC.AutoSize = true;
            this.rdbBTC.Checked = true;
            this.rdbBTC.Location = new System.Drawing.Point(21, 34);
            this.rdbBTC.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBTC.Name = "rdbBTC";
            this.rdbBTC.Size = new System.Drawing.Size(53, 20);
            this.rdbBTC.TabIndex = 11;
            this.rdbBTC.TabStop = true;
            this.rdbBTC.Text = "BTC";
            this.rdbBTC.UseVisualStyleBackColor = true;
            // 
            // rdbUSDT
            // 
            this.rdbUSDT.AutoSize = true;
            this.rdbUSDT.Location = new System.Drawing.Point(21, 119);
            this.rdbUSDT.Margin = new System.Windows.Forms.Padding(4);
            this.rdbUSDT.Name = "rdbUSDT";
            this.rdbUSDT.Size = new System.Drawing.Size(64, 20);
            this.rdbUSDT.TabIndex = 10;
            this.rdbUSDT.Text = "USDT";
            this.rdbUSDT.UseVisualStyleBackColor = true;
            // 
            // rdbETH
            // 
            this.rdbETH.AutoSize = true;
            this.rdbETH.Location = new System.Drawing.Point(20, 63);
            this.rdbETH.Margin = new System.Windows.Forms.Padding(4);
            this.rdbETH.Name = "rdbETH";
            this.rdbETH.Size = new System.Drawing.Size(54, 20);
            this.rdbETH.TabIndex = 10;
            this.rdbETH.Text = "ETH";
            this.rdbETH.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBTC);
            this.groupBox1.Controls.Add(this.rdbBNB);
            this.groupBox1.Controls.Add(this.rdbETH);
            this.groupBox1.Controls.Add(this.rdbBUSD);
            this.groupBox1.Controls.Add(this.rdbUSDT);
            this.groupBox1.Location = new System.Drawing.Point(412, 342);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(105, 186);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // rdbBUSD
            // 
            this.rdbBUSD.AutoSize = true;
            this.rdbBUSD.Location = new System.Drawing.Point(20, 148);
            this.rdbBUSD.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBUSD.Name = "rdbBUSD";
            this.rdbBUSD.Size = new System.Drawing.Size(64, 20);
            this.rdbBUSD.TabIndex = 10;
            this.rdbBUSD.Text = "BUSD";
            this.rdbBUSD.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb25);
            this.groupBox2.Controls.Add(this.rdb50);
            this.groupBox2.Controls.Add(this.rdb100);
            this.groupBox2.Controls.Add(this.rdb75);
            this.groupBox2.Location = new System.Drawing.Point(525, 342);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(105, 153);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QTY";
            // 
            // rdb25
            // 
            this.rdb25.AutoSize = true;
            this.rdb25.Location = new System.Drawing.Point(21, 34);
            this.rdb25.Margin = new System.Windows.Forms.Padding(4);
            this.rdb25.Name = "rdb25";
            this.rdb25.Size = new System.Drawing.Size(52, 20);
            this.rdb25.TabIndex = 11;
            this.rdb25.Text = "25%";
            this.rdb25.UseVisualStyleBackColor = true;
            // 
            // rdb50
            // 
            this.rdb50.AutoSize = true;
            this.rdb50.Location = new System.Drawing.Point(21, 63);
            this.rdb50.Margin = new System.Windows.Forms.Padding(4);
            this.rdb50.Name = "rdb50";
            this.rdb50.Size = new System.Drawing.Size(52, 20);
            this.rdb50.TabIndex = 10;
            this.rdb50.Text = "50%";
            this.rdb50.UseVisualStyleBackColor = true;
            // 
            // rdb100
            // 
            this.rdb100.AutoSize = true;
            this.rdb100.Checked = true;
            this.rdb100.Location = new System.Drawing.Point(21, 119);
            this.rdb100.Margin = new System.Windows.Forms.Padding(4);
            this.rdb100.Name = "rdb100";
            this.rdb100.Size = new System.Drawing.Size(59, 20);
            this.rdb100.TabIndex = 10;
            this.rdb100.TabStop = true;
            this.rdb100.Text = "100%";
            this.rdb100.UseVisualStyleBackColor = true;
            // 
            // rdb75
            // 
            this.rdb75.AutoSize = true;
            this.rdb75.Location = new System.Drawing.Point(21, 91);
            this.rdb75.Margin = new System.Windows.Forms.Padding(4);
            this.rdb75.Name = "rdb75";
            this.rdb75.Size = new System.Drawing.Size(52, 20);
            this.rdb75.TabIndex = 10;
            this.rdb75.Text = "75%";
            this.rdb75.UseVisualStyleBackColor = true;
            // 
            // txtPercentPriceChange
            // 
            this.txtPercentPriceChange.Location = new System.Drawing.Point(660, 540);
            this.txtPercentPriceChange.Margin = new System.Windows.Forms.Padding(4);
            this.txtPercentPriceChange.Name = "txtPercentPriceChange";
            this.txtPercentPriceChange.Size = new System.Drawing.Size(57, 22);
            this.txtPercentPriceChange.TabIndex = 14;
            this.txtPercentPriceChange.Text = "60";
            // 
            // lblPercentChangePrice
            // 
            this.lblPercentChangePrice.AutoSize = true;
            this.lblPercentChangePrice.Location = new System.Drawing.Point(408, 544);
            this.lblPercentChangePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercentChangePrice.Name = "lblPercentChangePrice";
            this.lblPercentChangePrice.Size = new System.Drawing.Size(234, 16);
            this.lblPercentChangePrice.TabIndex = 15;
            this.lblPercentChangePrice.Text = "Set change price 24 hs threshold (%<):";
            // 
            // btnConnectBot
            // 
            this.btnConnectBot.Location = new System.Drawing.Point(892, 16);
            this.btnConnectBot.Name = "btnConnectBot";
            this.btnConnectBot.Size = new System.Drawing.Size(254, 23);
            this.btnConnectBot.TabIndex = 16;
            this.btnConnectBot.Text = "Connect Telegram Bot";
            this.btnConnectBot.UseVisualStyleBackColor = true;
            this.btnConnectBot.Click += new System.EventHandler(this.btnConnectBot_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(892, 48);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(254, 23);
            this.btnDisconnect.TabIndex = 16;
            this.btnDisconnect.Text = "Disconnect Telegram Bot";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // grpTelegramConnection
            // 
            this.grpTelegramConnection.BackColor = System.Drawing.Color.Red;
            this.grpTelegramConnection.Location = new System.Drawing.Point(892, 84);
            this.grpTelegramConnection.Name = "grpTelegramConnection";
            this.grpTelegramConnection.Size = new System.Drawing.Size(254, 56);
            this.grpTelegramConnection.TabIndex = 17;
            this.grpTelegramConnection.TabStop = false;
            this.grpTelegramConnection.Text = "Telegram connection";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 778);
            this.Controls.Add(this.grpTelegramConnection);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnectBot);
            this.Controls.Add(this.lblPercentChangePrice);
            this.Controls.Add(this.txtPercentPriceChange);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkBTC);
            this.Controls.Add(this.lblConsole);
            this.Controls.Add(this.lblSearchSymbol);
            this.Controls.Add(this.txtSearchSymbol);
            this.Controls.Add(this.btnSaveKeys);
            this.Controls.Add(this.datCryptos);
            this.Controls.Add(this.lblSecretKey);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.txtSecretKey);
            this.Controls.Add(this.lblApiUrl);
            this.Controls.Add(this.lblApiKey);
            this.Controls.Add(this.txtApiUrl);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.btnClearConsole);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnGetCryptos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binance API Trader";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datCryptos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetCryptos;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label lblApiKey;
        private System.Windows.Forms.Label lblSecretKey;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.DataGridView datCryptos;
        private System.Windows.Forms.Button btnSaveKeys;
        private System.Windows.Forms.TextBox txtSearchSymbol;
        private System.Windows.Forms.Label lblSearchSymbol;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.Button btnClearConsole;
        private System.Windows.Forms.TextBox txtApiUrl;
        private System.Windows.Forms.Label lblApiUrl;
        private System.Windows.Forms.CheckBox chkBTC;
        private System.Windows.Forms.RadioButton rdbBNB;
        private System.Windows.Forms.RadioButton rdbBTC;
        private System.Windows.Forms.RadioButton rdbUSDT;
        private System.Windows.Forms.RadioButton rdbETH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb25;
        private System.Windows.Forms.RadioButton rdb50;
        private System.Windows.Forms.RadioButton rdb100;
        private System.Windows.Forms.RadioButton rdb75;
        private System.Windows.Forms.RadioButton rdbBUSD;
        private System.Windows.Forms.TextBox txtPercentPriceChange;
        private System.Windows.Forms.Label lblPercentChangePrice;
        private System.Windows.Forms.Button btnConnectBot;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox grpTelegramConnection;
    }
}

