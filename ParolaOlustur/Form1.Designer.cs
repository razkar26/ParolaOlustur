namespace ParolaOlustur
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
            this.btnForm = new System.Windows.Forms.Button();
            this.nUpDown = new System.Windows.Forms.NumericUpDown();
            this.chbOfset = new System.Windows.Forms.CheckBox();
            this.chbLower = new System.Windows.Forms.CheckBox();
            this.chbNum = new System.Windows.Forms.CheckBox();
            this.chbHigh = new System.Windows.Forms.CheckBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnForm
            // 
            this.btnForm.Location = new System.Drawing.Point(267, 86);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(99, 40);
            this.btnForm.TabIndex = 12;
            this.btnForm.Text = "Şifre Oluştur";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // nUpDown
            // 
            this.nUpDown.Location = new System.Drawing.Point(224, 103);
            this.nUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUpDown.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nUpDown.Name = "nUpDown";
            this.nUpDown.ReadOnly = true;
            this.nUpDown.Size = new System.Drawing.Size(37, 20);
            this.nUpDown.TabIndex = 11;
            this.nUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // chbOfset
            // 
            this.chbOfset.AutoSize = true;
            this.chbOfset.Location = new System.Drawing.Point(101, 109);
            this.chbOfset.Name = "chbOfset";
            this.chbOfset.Size = new System.Drawing.Size(44, 17);
            this.chbOfset.TabIndex = 7;
            this.chbOfset.Text = "#-%";
            this.chbOfset.UseVisualStyleBackColor = true;
            // 
            // chbLower
            // 
            this.chbLower.AutoSize = true;
            this.chbLower.Location = new System.Drawing.Point(25, 109);
            this.chbLower.Name = "chbLower";
            this.chbLower.Size = new System.Drawing.Size(40, 17);
            this.chbLower.TabIndex = 8;
            this.chbLower.Text = "a-z";
            this.chbLower.UseVisualStyleBackColor = true;
            // 
            // chbNum
            // 
            this.chbNum.AutoSize = true;
            this.chbNum.Location = new System.Drawing.Point(101, 86);
            this.chbNum.Name = "chbNum";
            this.chbNum.Size = new System.Drawing.Size(41, 17);
            this.chbNum.TabIndex = 9;
            this.chbNum.Text = "0-9";
            this.chbNum.UseVisualStyleBackColor = true;
            // 
            // chbHigh
            // 
            this.chbHigh.AutoSize = true;
            this.chbHigh.Location = new System.Drawing.Point(25, 86);
            this.chbHigh.Name = "chbHigh";
            this.chbHigh.Size = new System.Drawing.Size(43, 17);
            this.chbHigh.TabIndex = 10;
            this.chbHigh.Text = "A-Z";
            this.chbHigh.UseVisualStyleBackColor = true;
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMake.Location = new System.Drawing.Point(64, 31);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(302, 22);
            this.txtMake.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(19, 37);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(39, 16);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Uzunluk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.nUpDown);
            this.Controls.Add(this.chbOfset);
            this.Controls.Add(this.chbLower);
            this.Controls.Add(this.chbNum);
            this.Controls.Add(this.chbHigh);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblPassword);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola Oluştur";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.NumericUpDown nUpDown;
        private System.Windows.Forms.CheckBox chbOfset;
        private System.Windows.Forms.CheckBox chbLower;
        private System.Windows.Forms.CheckBox chbNum;
        private System.Windows.Forms.CheckBox chbHigh;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label1;
    }
}

