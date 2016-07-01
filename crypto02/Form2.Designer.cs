namespace crypto02
{
    partial class Form2
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
            this.cancel_B = new System.Windows.Forms.Button();
            this.generate_alphabet_B = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_B
            // 
            this.cancel_B.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_B.Location = new System.Drawing.Point(191, 13);
            this.cancel_B.Name = "cancel_B";
            this.cancel_B.Size = new System.Drawing.Size(75, 23);
            this.cancel_B.TabIndex = 3;
            this.cancel_B.Text = "cancel";
            this.cancel_B.UseVisualStyleBackColor = true;
            this.cancel_B.Click += new System.EventHandler(this.cancel_B_Click);
            // 
            // generate_alphabet_B
            // 
            this.generate_alphabet_B.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_alphabet_B.Location = new System.Drawing.Point(12, 13);
            this.generate_alphabet_B.Name = "generate_alphabet_B";
            this.generate_alphabet_B.Size = new System.Drawing.Size(173, 23);
            this.generate_alphabet_B.TabIndex = 2;
            this.generate_alphabet_B.Text = "generate new alphabet";
            this.generate_alphabet_B.UseVisualStyleBackColor = true;
            this.generate_alphabet_B.Click += new System.EventHandler(this.generate_alphabet_B_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 11);
            this.label1.TabIndex = 7;
            this.label1.Text = "alph: { А...Я, а...я }";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 61);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_B);
            this.Controls.Add(this.generate_alphabet_B);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_B;
        private System.Windows.Forms.Button generate_alphabet_B;
        private System.Windows.Forms.Label label1;
    }
}