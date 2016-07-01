namespace crypto02
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.encrypt_B = new System.Windows.Forms.Button();
            this.decrypt_B = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.more_options = new System.Windows.Forms.Button();
            this.copy_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encrypt_B
            // 
            this.encrypt_B.BackColor = System.Drawing.Color.DarkRed;
            this.encrypt_B.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.encrypt_B.Location = new System.Drawing.Point(170, 60);
            this.encrypt_B.Name = "encrypt_B";
            this.encrypt_B.Size = new System.Drawing.Size(75, 23);
            this.encrypt_B.TabIndex = 0;
            this.encrypt_B.Text = "encrypt";
            this.encrypt_B.UseVisualStyleBackColor = false;
            this.encrypt_B.Click += new System.EventHandler(this.encrypt_B_Click);
            // 
            // decrypt_B
            // 
            this.decrypt_B.BackColor = System.Drawing.Color.YellowGreen;
            this.decrypt_B.Location = new System.Drawing.Point(252, 60);
            this.decrypt_B.Name = "decrypt_B";
            this.decrypt_B.Size = new System.Drawing.Size(75, 23);
            this.decrypt_B.TabIndex = 1;
            this.decrypt_B.Text = "decrypt";
            this.decrypt_B.UseVisualStyleBackColor = false;
            this.decrypt_B.Click += new System.EventHandler(this.decrypt_B_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 18);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(464, 18);
            this.textBox2.TabIndex = 3;
            // 
            // more_options
            // 
            this.more_options.BackColor = System.Drawing.Color.SkyBlue;
            this.more_options.Location = new System.Drawing.Point(333, 60);
            this.more_options.Name = "more_options";
            this.more_options.Size = new System.Drawing.Size(75, 23);
            this.more_options.TabIndex = 4;
            this.more_options.Text = "more...";
            this.more_options.UseVisualStyleBackColor = false;
            this.more_options.Click += new System.EventHandler(this.more_options_Click);
            // 
            // copy_button
            // 
            this.copy_button.BackColor = System.Drawing.Color.Violet;
            this.copy_button.Location = new System.Drawing.Point(89, 60);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(75, 23);
            this.copy_button.TabIndex = 5;
            this.copy_button.Text = "copy ↑";
            this.copy_button.UseVisualStyleBackColor = false;
            this.copy_button.Click += new System.EventHandler(this.copy_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(496, 121);
            this.Controls.Add(this.copy_button);
            this.Controls.Add(this.more_options);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.decrypt_B);
            this.Controls.Add(this.encrypt_B);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Transposition cipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encrypt_B;
        private System.Windows.Forms.Button decrypt_B;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button more_options;
        private System.Windows.Forms.Button copy_button;
    }
}

