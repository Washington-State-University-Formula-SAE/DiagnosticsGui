namespace FSAE_Diagnostics_Tool
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.closeButton = new System.Windows.Forms.Button();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.openButton = new System.Windows.Forms.Button();
            this.portLabel = new System.Windows.Forms.Label();
            this.receiveTextBox = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.testButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.delim3TextBox = new System.Windows.Forms.TextBox();
            this.delim1TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.delim2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delimLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(255, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 21);
            this.closeButton.TabIndex = 30;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(47, 6);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 21);
            this.portComboBox.TabIndex = 29;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(174, 5);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 21);
            this.openButton.TabIndex = 28;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(12, 9);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 13);
            this.portLabel.TabIndex = 27;
            this.portLabel.Text = "Port:";
            // 
            // receiveTextBox
            // 
            this.receiveTextBox.Location = new System.Drawing.Point(15, 33);
            this.receiveTextBox.Multiline = true;
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receiveTextBox.Size = new System.Drawing.Size(315, 304);
            this.receiveTextBox.TabIndex = 31;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM2";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(861, 6);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(259, 75);
            this.testButton.TabIndex = 33;
            this.testButton.Text = "Send Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(861, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(259, 250);
            this.textBox1.TabIndex = 34;
            // 
            // delim3TextBox
            // 
            this.delim3TextBox.Location = new System.Drawing.Point(439, 257);
            this.delim3TextBox.Multiline = true;
            this.delim3TextBox.Name = "delim3TextBox";
            this.delim3TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.delim3TextBox.Size = new System.Drawing.Size(380, 80);
            this.delim3TextBox.TabIndex = 63;
            // 
            // delim1TextBox
            // 
            this.delim1TextBox.Location = new System.Drawing.Point(439, 85);
            this.delim1TextBox.Multiline = true;
            this.delim1TextBox.Name = "delim1TextBox";
            this.delim1TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.delim1TextBox.Size = new System.Drawing.Size(380, 80);
            this.delim1TextBox.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "third delimiter:";
            // 
            // delim2TextBox
            // 
            this.delim2TextBox.Location = new System.Drawing.Point(439, 171);
            this.delim2TextBox.Multiline = true;
            this.delim2TextBox.Name = "delim2TextBox";
            this.delim2TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.delim2TextBox.Size = new System.Drawing.Size(380, 80);
            this.delim2TextBox.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "second delimiter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "first delimiter:";
            // 
            // delimLabel
            // 
            this.delimLabel.AutoSize = true;
            this.delimLabel.Location = new System.Drawing.Point(366, 58);
            this.delimLabel.Name = "delimLabel";
            this.delimLabel.Size = new System.Drawing.Size(84, 13);
            this.delimLabel.TabIndex = 57;
            this.delimLabel.Text = "Delimiter testing:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 425);
            this.Controls.Add(this.delim3TextBox);
            this.Controls.Add(this.delim1TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delim2TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delimLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.receiveTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.portLabel);
            this.Name = "Form1";
            this.Text = "Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox receiveTextBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox delim3TextBox;
        private System.Windows.Forms.TextBox delim1TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox delim2TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label delimLabel;
    }
}

