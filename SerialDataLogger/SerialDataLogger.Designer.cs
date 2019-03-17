namespace SerialDataLogger
{
    partial class SerialDataLogger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_Advanced = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_baudRateComboList = new System.Windows.Forms.ComboBox();
            this.m_connectBtn = new System.Windows.Forms.Button();
            this.m_serialPortListCombo = new System.Windows.Forms.ComboBox();
            this.m_plot = new OxyPlot.WindowsForms.PlotView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_PlotBtn = new System.Windows.Forms.Button();
            this.m_ReadPortBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_readDataTB = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_Advanced);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.m_baudRateComboList);
            this.groupBox2.Controls.Add(this.m_connectBtn);
            this.groupBox2.Controls.Add(this.m_serialPortListCombo);
            this.groupBox2.Location = new System.Drawing.Point(12, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 70);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // m_Advanced
            // 
            this.m_Advanced.Enabled = false;
            this.m_Advanced.Location = new System.Drawing.Point(370, 39);
            this.m_Advanced.Name = "m_Advanced";
            this.m_Advanced.Size = new System.Drawing.Size(75, 23);
            this.m_Advanced.TabIndex = 21;
            this.m_Advanced.Text = "Advanced";
            this.m_Advanced.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Port";
            // 
            // m_baudRateComboList
            // 
            this.m_baudRateComboList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_baudRateComboList.FormattingEnabled = true;
            this.m_baudRateComboList.Location = new System.Drawing.Point(153, 41);
            this.m_baudRateComboList.Name = "m_baudRateComboList";
            this.m_baudRateComboList.Size = new System.Drawing.Size(121, 21);
            this.m_baudRateComboList.TabIndex = 18;
            // 
            // m_connectBtn
            // 
            this.m_connectBtn.Enabled = false;
            this.m_connectBtn.Location = new System.Drawing.Point(289, 39);
            this.m_connectBtn.Name = "m_connectBtn";
            this.m_connectBtn.Size = new System.Drawing.Size(75, 23);
            this.m_connectBtn.TabIndex = 16;
            this.m_connectBtn.Text = "Connect";
            this.m_connectBtn.UseVisualStyleBackColor = true;
            this.m_connectBtn.Click += new System.EventHandler(this.m_connectBtn_Click);
            // 
            // m_serialPortListCombo
            // 
            this.m_serialPortListCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_serialPortListCombo.FormattingEnabled = true;
            this.m_serialPortListCombo.Location = new System.Drawing.Point(6, 41);
            this.m_serialPortListCombo.Name = "m_serialPortListCombo";
            this.m_serialPortListCombo.Size = new System.Drawing.Size(121, 21);
            this.m_serialPortListCombo.TabIndex = 17;
            // 
            // m_plot
            // 
            this.m_plot.BackColor = System.Drawing.Color.White;
            this.m_plot.Location = new System.Drawing.Point(27, 150);
            this.m_plot.Name = "m_plot";
            this.m_plot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.m_plot.Size = new System.Drawing.Size(733, 306);
            this.m_plot.TabIndex = 27;
            this.m_plot.Text = "plot1";
            this.m_plot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.m_plot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.m_plot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_readDataTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.m_PlotBtn);
            this.groupBox1.Controls.Add(this.m_plot);
            this.groupBox1.Controls.Add(this.m_ReadPortBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 477);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plot";
            // 
            // m_PlotBtn
            // 
            this.m_PlotBtn.Enabled = false;
            this.m_PlotBtn.Location = new System.Drawing.Point(115, 19);
            this.m_PlotBtn.Name = "m_PlotBtn";
            this.m_PlotBtn.Size = new System.Drawing.Size(75, 23);
            this.m_PlotBtn.TabIndex = 21;
            this.m_PlotBtn.Text = "Plot";
            this.m_PlotBtn.UseVisualStyleBackColor = true;
            // 
            // m_ReadPortBtn
            // 
            this.m_ReadPortBtn.Enabled = false;
            this.m_ReadPortBtn.Location = new System.Drawing.Point(27, 19);
            this.m_ReadPortBtn.Name = "m_ReadPortBtn";
            this.m_ReadPortBtn.Size = new System.Drawing.Size(75, 23);
            this.m_ReadPortBtn.TabIndex = 16;
            this.m_ReadPortBtn.Text = "Read";
            this.m_ReadPortBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Read Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Seconds";
            // 
            // m_readDataTB
            // 
            this.m_readDataTB.Location = new System.Drawing.Point(27, 48);
            this.m_readDataTB.Name = "m_readDataTB";
            this.m_readDataTB.Size = new System.Drawing.Size(733, 96);
            this.m_readDataTB.TabIndex = 30;
            this.m_readDataTB.Text = "";
            // 
            // SerialDataLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "SerialDataLogger";
            this.Text = "SerialDataLogger";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button m_connectBtn;
        private System.Windows.Forms.ComboBox m_serialPortListCombo;
        private System.Windows.Forms.Button m_Advanced;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox m_baudRateComboList;
        private OxyPlot.WindowsForms.PlotView m_plot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button m_PlotBtn;
        private System.Windows.Forms.Button m_ReadPortBtn;
        private System.Windows.Forms.RichTextBox m_readDataTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

