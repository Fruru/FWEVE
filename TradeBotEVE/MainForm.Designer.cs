namespace TradeBotEVE
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startBot = new System.Windows.Forms.Button();
            this.AsetsXTextBox = new System.Windows.Forms.TextBox();
            this.AsetsYTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstShipYTextBox = new System.Windows.Forms.TextBox();
            this.FirstShipXTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChatYTextBox = new System.Windows.Forms.TextBox();
            this.ChatXTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mySellOrderCountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.myBuyOrderCountTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iterationCountTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.iterationPauseTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.doTimeMainTextBox = new System.Windows.Forms.TextBox();
            this.doTimeAddTextBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.testButton = new System.Windows.Forms.Button();
            this.coordLabelX = new System.Windows.Forms.Label();
            this.timerGetCursorPos = new System.Windows.Forms.Timer(this.components);
            this.coordLabelY = new System.Windows.Forms.Label();
            this.sellCheckBox = new System.Windows.Forms.CheckBox();
            this.buyCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sistemNameTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.undockXtextbox = new System.Windows.Forms.TextBox();
            this.undockYtextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startBot
            // 
            this.startBot.Location = new System.Drawing.Point(366, 27);
            this.startBot.Name = "startBot";
            this.startBot.Size = new System.Drawing.Size(75, 23);
            this.startBot.TabIndex = 0;
            this.startBot.Text = "Запуск";
            this.startBot.UseVisualStyleBackColor = true;
            this.startBot.Click += new System.EventHandler(this.startBot_Click);
            // 
            // AsetsXTextBox
            // 
            this.AsetsXTextBox.Location = new System.Drawing.Point(173, 30);
            this.AsetsXTextBox.Name = "AsetsXTextBox";
            this.AsetsXTextBox.Size = new System.Drawing.Size(59, 20);
            this.AsetsXTextBox.TabIndex = 1;
            this.AsetsXTextBox.Text = "820";
            // 
            // AsetsYTextBox
            // 
            this.AsetsYTextBox.Location = new System.Drawing.Point(239, 30);
            this.AsetsYTextBox.Name = "AsetsYTextBox";
            this.AsetsYTextBox.Size = new System.Drawing.Size(59, 20);
            this.AsetsYTextBox.TabIndex = 2;
            this.AsetsYTextBox.Text = "148";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Склад";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Первый шип";
            // 
            // FirstShipYTextBox
            // 
            this.FirstShipYTextBox.Location = new System.Drawing.Point(239, 56);
            this.FirstShipYTextBox.Name = "FirstShipYTextBox";
            this.FirstShipYTextBox.Size = new System.Drawing.Size(59, 20);
            this.FirstShipYTextBox.TabIndex = 5;
            this.FirstShipYTextBox.Text = "537";
            // 
            // FirstShipXTextBox
            // 
            this.FirstShipXTextBox.Location = new System.Drawing.Point(173, 56);
            this.FirstShipXTextBox.Name = "FirstShipXTextBox";
            this.FirstShipXTextBox.Size = new System.Drawing.Size(59, 20);
            this.FirstShipXTextBox.TabIndex = 4;
            this.FirstShipXTextBox.Text = "877";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Чат";
            // 
            // ChatYTextBox
            // 
            this.ChatYTextBox.Location = new System.Drawing.Point(239, 82);
            this.ChatYTextBox.Name = "ChatYTextBox";
            this.ChatYTextBox.Size = new System.Drawing.Size(59, 20);
            this.ChatYTextBox.TabIndex = 8;
            this.ChatYTextBox.Text = "609";
            // 
            // ChatXTextBox
            // 
            this.ChatXTextBox.Location = new System.Drawing.Point(173, 82);
            this.ChatXTextBox.Name = "ChatXTextBox";
            this.ChatXTextBox.Size = new System.Drawing.Size(59, 20);
            this.ChatXTextBox.TabIndex = 7;
            this.ChatXTextBox.Text = "828";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ордеров продажи";
            // 
            // mySellOrderCountTextBox
            // 
            this.mySellOrderCountTextBox.Location = new System.Drawing.Point(173, 454);
            this.mySellOrderCountTextBox.Name = "mySellOrderCountTextBox";
            this.mySellOrderCountTextBox.Size = new System.Drawing.Size(59, 20);
            this.mySellOrderCountTextBox.TabIndex = 10;
            this.mySellOrderCountTextBox.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ордеров скупки";
            // 
            // myBuyOrderCountTextBox
            // 
            this.myBuyOrderCountTextBox.Location = new System.Drawing.Point(173, 480);
            this.myBuyOrderCountTextBox.Name = "myBuyOrderCountTextBox";
            this.myBuyOrderCountTextBox.Size = new System.Drawing.Size(59, 20);
            this.myBuyOrderCountTextBox.TabIndex = 12;
            this.myBuyOrderCountTextBox.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Циклов";
            // 
            // iterationCountTextBox
            // 
            this.iterationCountTextBox.Location = new System.Drawing.Point(173, 506);
            this.iterationCountTextBox.Name = "iterationCountTextBox";
            this.iterationCountTextBox.Size = new System.Drawing.Size(59, 20);
            this.iterationCountTextBox.TabIndex = 14;
            this.iterationCountTextBox.Text = "200";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Время между ц-ми";
            // 
            // iterationPauseTextBox
            // 
            this.iterationPauseTextBox.Location = new System.Drawing.Point(173, 532);
            this.iterationPauseTextBox.Name = "iterationPauseTextBox";
            this.iterationPauseTextBox.Size = new System.Drawing.Size(59, 20);
            this.iterationPauseTextBox.TabIndex = 16;
            this.iterationPauseTextBox.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Время между действиями";
            // 
            // doTimeMainTextBox
            // 
            this.doTimeMainTextBox.Location = new System.Drawing.Point(173, 558);
            this.doTimeMainTextBox.Name = "doTimeMainTextBox";
            this.doTimeMainTextBox.Size = new System.Drawing.Size(59, 20);
            this.doTimeMainTextBox.TabIndex = 18;
            this.doTimeMainTextBox.Text = "800";
            // 
            // doTimeAddTextBox
            // 
            this.doTimeAddTextBox.Location = new System.Drawing.Point(239, 558);
            this.doTimeAddTextBox.Name = "doTimeAddTextBox";
            this.doTimeAddTextBox.Size = new System.Drawing.Size(59, 20);
            this.doTimeAddTextBox.TabIndex = 20;
            this.doTimeAddTextBox.Text = "100";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(29, 584);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(268, 95);
            this.listBox.TabIndex = 21;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(366, 109);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 22;
            this.testButton.Text = "TEST";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // coordLabelX
            // 
            this.coordLabelX.AutoSize = true;
            this.coordLabelX.Location = new System.Drawing.Point(363, 678);
            this.coordLabelX.Name = "coordLabelX";
            this.coordLabelX.Size = new System.Drawing.Size(14, 13);
            this.coordLabelX.TabIndex = 23;
            this.coordLabelX.Text = "X";
            // 
            // timerGetCursorPos
            // 
            this.timerGetCursorPos.Interval = 50;
            this.timerGetCursorPos.Tick += new System.EventHandler(this.timerGetCursorPos_Tick);
            // 
            // coordLabelY
            // 
            this.coordLabelY.AutoSize = true;
            this.coordLabelY.Location = new System.Drawing.Point(427, 678);
            this.coordLabelY.Name = "coordLabelY";
            this.coordLabelY.Size = new System.Drawing.Size(14, 13);
            this.coordLabelY.TabIndex = 24;
            this.coordLabelY.Text = "Y";
            // 
            // sellCheckBox
            // 
            this.sellCheckBox.AutoSize = true;
            this.sellCheckBox.Checked = true;
            this.sellCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sellCheckBox.Location = new System.Drawing.Point(33, 179);
            this.sellCheckBox.Name = "sellCheckBox";
            this.sellCheckBox.Size = new System.Drawing.Size(65, 17);
            this.sellCheckBox.TabIndex = 25;
            this.sellCheckBox.Text = "Защита\r\n";
            this.sellCheckBox.UseVisualStyleBackColor = true;
            // 
            // buyCheckBox
            // 
            this.buyCheckBox.AutoSize = true;
            this.buyCheckBox.Location = new System.Drawing.Point(33, 425);
            this.buyCheckBox.Name = "buyCheckBox";
            this.buyCheckBox.Size = new System.Drawing.Size(62, 17);
            this.buyCheckBox.TabIndex = 26;
            this.buyCheckBox.Text = "Скупка";
            this.buyCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Система - цель";
            // 
            // sistemNameTextbox
            // 
            this.sistemNameTextbox.Location = new System.Drawing.Point(173, 106);
            this.sistemNameTextbox.Name = "sistemNameTextbox";
            this.sistemNameTextbox.Size = new System.Drawing.Size(125, 20);
            this.sistemNameTextbox.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Андок Кнопка";
            // 
            // undockXtextbox
            // 
            this.undockXtextbox.Location = new System.Drawing.Point(173, 133);
            this.undockXtextbox.Name = "undockXtextbox";
            this.undockXtextbox.Size = new System.Drawing.Size(59, 20);
            this.undockXtextbox.TabIndex = 30;
            // 
            // undockYtextbox
            // 
            this.undockYtextbox.Location = new System.Drawing.Point(238, 133);
            this.undockYtextbox.Name = "undockYtextbox";
            this.undockYtextbox.Size = new System.Drawing.Size(59, 20);
            this.undockYtextbox.TabIndex = 31;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 700);
            this.Controls.Add(this.undockYtextbox);
            this.Controls.Add(this.undockXtextbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sistemNameTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buyCheckBox);
            this.Controls.Add(this.sellCheckBox);
            this.Controls.Add(this.coordLabelY);
            this.Controls.Add(this.coordLabelX);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.doTimeAddTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.doTimeMainTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iterationPauseTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.iterationCountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.myBuyOrderCountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mySellOrderCountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChatYTextBox);
            this.Controls.Add(this.ChatXTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstShipYTextBox);
            this.Controls.Add(this.FirstShipXTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AsetsYTextBox);
            this.Controls.Add(this.AsetsXTextBox);
            this.Controls.Add(this.startBot);
            this.Name = "MainForm";
            this.Text = "TradeBotEVE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mySellOrderCountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox myBuyOrderCountTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox iterationCountTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox iterationPauseTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox doTimeMainTextBox;
        private System.Windows.Forms.TextBox doTimeAddTextBox;
        public System.Windows.Forms.TextBox AsetsXTextBox;
        public System.Windows.Forms.TextBox AsetsYTextBox;
        public System.Windows.Forms.TextBox FirstShipYTextBox;
        public System.Windows.Forms.TextBox FirstShipXTextBox;
        public System.Windows.Forms.TextBox ChatYTextBox;
        public System.Windows.Forms.TextBox ChatXTextBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label coordLabelX;
        private System.Windows.Forms.Timer timerGetCursorPos;
        private System.Windows.Forms.Label coordLabelY;
        private System.Windows.Forms.CheckBox sellCheckBox;
        private System.Windows.Forms.CheckBox buyCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sistemNameTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox undockXtextbox;
        private System.Windows.Forms.TextBox undockYtextbox;
    }
}

