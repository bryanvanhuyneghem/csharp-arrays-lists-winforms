namespace Arrays
{
    partial class Form5
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
            this.lblResultaat = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtInvoer = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResultaat
            // 
            this.lblResultaat.AutoSize = true;
            this.lblResultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultaat.Location = new System.Drawing.Point(281, 230);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(0, 25);
            this.lblResultaat.TabIndex = 21;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(483, 160);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(77, 20);
            this.btnBereken.TabIndex = 17;
            this.btnBereken.Text = "Opslaan";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // txtInvoer
            // 
            this.txtInvoer.Location = new System.Drawing.Point(301, 160);
            this.txtInvoer.Name = "txtInvoer";
            this.txtInvoer.Size = new System.Drawing.Size(163, 20);
            this.txtInvoer.TabIndex = 16;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(241, 163);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(40, 13);
            this.lblInvoer.TabIndex = 15;
            this.lblInvoer.Text = "Invoer:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultaat);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtInvoer);
            this.Controls.Add(this.lblInvoer);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultaat;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtInvoer;
        private System.Windows.Forms.Label lblInvoer;
    }
}