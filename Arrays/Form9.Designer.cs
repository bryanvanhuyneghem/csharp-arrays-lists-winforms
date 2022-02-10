namespace Arrays
{
    partial class Form9
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
            this.lblWoorden = new System.Windows.Forms.Label();
            this.richtxtWoorden = new System.Windows.Forms.RichTextBox();
            this.btnZoek = new System.Windows.Forms.Button();
            this.lblWoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWoorden
            // 
            this.lblWoorden.AutoSize = true;
            this.lblWoorden.Location = new System.Drawing.Point(327, 77);
            this.lblWoorden.Name = "lblWoorden";
            this.lblWoorden.Size = new System.Drawing.Size(88, 13);
            this.lblWoorden.TabIndex = 0;
            this.lblWoorden.Text = "Geef woorden in:";
            // 
            // richtxtWoorden
            // 
            this.richtxtWoorden.Location = new System.Drawing.Point(290, 93);
            this.richtxtWoorden.Name = "richtxtWoorden";
            this.richtxtWoorden.Size = new System.Drawing.Size(161, 266);
            this.richtxtWoorden.TabIndex = 1;
            this.richtxtWoorden.Text = "";
            // 
            // btnZoek
            // 
            this.btnZoek.Location = new System.Drawing.Point(330, 365);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(75, 23);
            this.btnZoek.TabIndex = 2;
            this.btnZoek.Text = "Zoek";
            this.btnZoek.UseVisualStyleBackColor = true;
            this.btnZoek.Click += new System.EventHandler(this.btnZoek_Click);
            // 
            // lblWoord
            // 
            this.lblWoord.AutoSize = true;
            this.lblWoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWoord.Location = new System.Drawing.Point(325, 406);
            this.lblWoord.Name = "lblWoord";
            this.lblWoord.Size = new System.Drawing.Size(0, 25);
            this.lblWoord.TabIndex = 3;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWoord);
            this.Controls.Add(this.btnZoek);
            this.Controls.Add(this.richtxtWoorden);
            this.Controls.Add(this.lblWoorden);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWoorden;
        private System.Windows.Forms.RichTextBox richtxtWoorden;
        private System.Windows.Forms.Button btnZoek;
        private System.Windows.Forms.Label lblWoord;
    }
}