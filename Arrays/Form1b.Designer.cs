namespace Arrays
{
    partial class Form1b
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
            this.lblUitvoer = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtInvoer = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.lblBewerking = new System.Windows.Forms.Label();
            this.txtBewerking = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUitvoer
            // 
            this.lblUitvoer.AutoSize = true;
            this.lblUitvoer.Location = new System.Drawing.Point(149, 164);
            this.lblUitvoer.Name = "lblUitvoer";
            this.lblUitvoer.Size = new System.Drawing.Size(44, 13);
            this.lblUitvoer.TabIndex = 8;
            this.lblUitvoer.Text = "Uitvoer:";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(391, 102);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(77, 20);
            this.btnBereken.TabIndex = 7;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // txtInvoer
            // 
            this.txtInvoer.Location = new System.Drawing.Point(209, 102);
            this.txtInvoer.Name = "txtInvoer";
            this.txtInvoer.Size = new System.Drawing.Size(163, 20);
            this.txtInvoer.TabIndex = 6;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(149, 105);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(40, 13);
            this.lblInvoer.TabIndex = 5;
            this.lblInvoer.Text = "Invoer:";
            // 
            // lblBewerking
            // 
            this.lblBewerking.AutoSize = true;
            this.lblBewerking.Location = new System.Drawing.Point(149, 136);
            this.lblBewerking.Name = "lblBewerking";
            this.lblBewerking.Size = new System.Drawing.Size(60, 13);
            this.lblBewerking.TabIndex = 10;
            this.lblBewerking.Text = "Bewerking:";
            // 
            // txtBewerking
            // 
            this.txtBewerking.Location = new System.Drawing.Point(209, 133);
            this.txtBewerking.Name = "txtBewerking";
            this.txtBewerking.Size = new System.Drawing.Size(163, 20);
            this.txtBewerking.TabIndex = 11;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(209, 164);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 13);
            this.lblRes.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtBewerking);
            this.Controls.Add(this.lblBewerking);
            this.Controls.Add(this.lblUitvoer);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtInvoer);
            this.Controls.Add(this.lblInvoer);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUitvoer;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtInvoer;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.Label lblBewerking;
        private System.Windows.Forms.TextBox txtBewerking;
        private System.Windows.Forms.Label lblRes;
    }
}