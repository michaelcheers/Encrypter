namespace Encrypter
{
    partial class Decrypt
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
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Encryption = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BeginText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Input_Type = new System.Windows.Forms.ComboBox();
            this.Output_Type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(75, 10);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '.';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 1;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encryption:";
            // 
            // Encryption
            // 
            this.Encryption.Location = new System.Drawing.Point(75, 36);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(100, 20);
            this.Encryption.TabIndex = 3;
            this.Encryption.TextChanged += new System.EventHandler(this.Encryption_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Text:";
            // 
            // BeginText
            // 
            this.BeginText.AutoSize = true;
            this.BeginText.Location = new System.Drawing.Point(49, 59);
            this.BeginText.Name = "BeginText";
            this.BeginText.Size = new System.Drawing.Size(35, 13);
            this.BeginText.TabIndex = 5;
            this.BeginText.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Copy Message to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input Format:";
            // 
            // Input_Type
            // 
            this.Input_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Input_Type.FormattingEnabled = true;
            this.Input_Type.Items.AddRange(new object[] {
            "Random Characters",
            "Number",
            "File"});
            this.Input_Type.Location = new System.Drawing.Point(90, 101);
            this.Input_Type.Name = "Input_Type";
            this.Input_Type.Size = new System.Drawing.Size(121, 21);
            this.Input_Type.TabIndex = 8;
            this.Input_Type.SelectedIndexChanged += new System.EventHandler(this.Input_Type_SelectedIndexChanged);
            // 
            // Output_Type
            // 
            this.Output_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Output_Type.FormattingEnabled = true;
            this.Output_Type.Items.AddRange(new object[] {
            "Text",
            "Number",
            "File"});
            this.Output_Type.Location = new System.Drawing.Point(90, 128);
            this.Output_Type.Name = "Output_Type";
            this.Output_Type.Size = new System.Drawing.Size(121, 21);
            this.Output_Type.TabIndex = 10;
            this.Output_Type.SelectedIndexChanged += new System.EventHandler(this.Output_Type_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Output Format:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(12, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Case Sensitive:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Decrypt
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Output_Type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Input_Type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BeginText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Encryption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Name = "Decrypt";
            this.Text = "Decrypt";
            this.Load += new System.EventHandler(this.Decrypt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Encryption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BeginText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Input_Type;
        private System.Windows.Forms.ComboBox Output_Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}