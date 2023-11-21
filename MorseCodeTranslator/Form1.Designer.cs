namespace MorseCodeTranslator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInput = new Label();
            txtInput = new TextBox();
            btnConvert = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblOutput = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInput.Location = new Point(197, 89);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(187, 21);
            lblInput.TabIndex = 0;
            lblInput.Text = "Enter text to be translated";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.Location = new Point(162, 146);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(268, 29);
            txtInput.TabIndex = 1;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.FromArgb(192, 255, 192);
            btnConvert.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvert.Location = new Point(188, 215);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(196, 63);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 255, 192);
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(651, 127);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 48);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 128, 128);
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(651, 222);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 49);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.BackColor = Color.FromArgb(192, 255, 255);
            lblOutput.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOutput.Location = new Point(241, 356);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 32);
            lblOutput.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 358);
            label1.Name = "label1";
            label1.Size = new Size(164, 30);
            label1.TabIndex = 6;
            label1.Text = "Translated text:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 466);
            Controls.Add(label1);
            Controls.Add(lblOutput);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private TextBox txtInput;
        private Button btnConvert;
        private Button btnClear;
        private Button btnExit;
        private Label lblOutput;
        private Label label1;
    }
}