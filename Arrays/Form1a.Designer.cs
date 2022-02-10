namespace Arrays
{
    partial class Form1a
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
            this.lblInvoer = new System.Windows.Forms.Label();
            this.txtInvoer = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblUitvoer = new System.Windows.Forms.Label();
            this.lblResultaat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(113, 99);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(40, 13);
            this.lblInvoer.TabIndex = 0;
            this.lblInvoer.Text = "Invoer:";
            // 
            // txtInvoer
            // 
            this.txtInvoer.Location = new System.Drawing.Point(159, 96);
            this.txtInvoer.Name = "txtInvoer";
            this.txtInvoer.Size = new System.Drawing.Size(163, 20);
            this.txtInvoer.TabIndex = 1;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(337, 96);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(77, 20);
            this.btnBereken.TabIndex = 2;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // lblUitvoer
            // 
            this.lblUitvoer.AutoSize = true;
            this.lblUitvoer.Location = new System.Drawing.Point(113, 130);
            this.lblUitvoer.Name = "lblUitvoer";
            this.lblUitvoer.Size = new System.Drawing.Size(44, 13);
            this.lblUitvoer.TabIndex = 3;
            this.lblUitvoer.Text = "Uitvoer:";
            // 
            // lblResultaat
            // 
            this.lblResultaat.AutoSize = true;
            this.lblResultaat.Location = new System.Drawing.Point(159, 130);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(0, 13);
            this.lblResultaat.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(631, 434);
            this.Controls.Add(this.lblResultaat);
            this.Controls.Add(this.lblUitvoer);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtInvoer);
            this.Controls.Add(this.lblInvoer);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.TextBox txtInvoer;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblUitvoer;
        private System.Windows.Forms.Label lblResultaat;
    }
}

