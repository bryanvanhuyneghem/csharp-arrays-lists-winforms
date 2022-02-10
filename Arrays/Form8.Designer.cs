namespace Arrays
{
    partial class Form8
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
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtInvoer = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.lblAantal = new System.Windows.Forms.Label();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.btnAantal = new System.Windows.Forms.Button();
            this.lblSom = new System.Windows.Forms.Label();
            this.lblGem = new System.Windows.Forms.Label();
            this.lblResSom = new System.Windows.Forms.Label();
            this.lblResGem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(453, 131);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(77, 20);
            this.btnBereken.TabIndex = 13;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // txtInvoer
            // 
            this.txtInvoer.Location = new System.Drawing.Point(271, 131);
            this.txtInvoer.Name = "txtInvoer";
            this.txtInvoer.Size = new System.Drawing.Size(163, 20);
            this.txtInvoer.TabIndex = 12;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(211, 134);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(40, 13);
            this.lblInvoer.TabIndex = 11;
            this.lblInvoer.Text = "Invoer:";
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(211, 95);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(80, 13);
            this.lblAantal.TabIndex = 14;
            this.lblAantal.Text = "Aantal getallen:";
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(298, 95);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(30, 20);
            this.txtAantal.TabIndex = 15;
            // 
            // btnAantal
            // 
            this.btnAantal.Location = new System.Drawing.Point(334, 95);
            this.btnAantal.Name = "btnAantal";
            this.btnAantal.Size = new System.Drawing.Size(30, 21);
            this.btnAantal.TabIndex = 16;
            this.btnAantal.Text = "OK";
            this.btnAantal.UseVisualStyleBackColor = true;
            this.btnAantal.Click += new System.EventHandler(this.btnAantal_Click);
            // 
            // lblSom
            // 
            this.lblSom.AutoSize = true;
            this.lblSom.Location = new System.Drawing.Point(211, 187);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(31, 13);
            this.lblSom.TabIndex = 17;
            this.lblSom.Text = "Som:";
            // 
            // lblGem
            // 
            this.lblGem.AutoSize = true;
            this.lblGem.Location = new System.Drawing.Point(211, 220);
            this.lblGem.Name = "lblGem";
            this.lblGem.Size = new System.Drawing.Size(66, 13);
            this.lblGem.TabIndex = 18;
            this.lblGem.Text = "Gemiddelde:";
            // 
            // lblResSom
            // 
            this.lblResSom.AutoSize = true;
            this.lblResSom.Location = new System.Drawing.Point(298, 187);
            this.lblResSom.Name = "lblResSom";
            this.lblResSom.Size = new System.Drawing.Size(0, 13);
            this.lblResSom.TabIndex = 19;
            // 
            // lblResGem
            // 
            this.lblResGem.AutoSize = true;
            this.lblResGem.Location = new System.Drawing.Point(298, 219);
            this.lblResGem.Name = "lblResGem";
            this.lblResGem.Size = new System.Drawing.Size(0, 13);
            this.lblResGem.TabIndex = 20;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResGem);
            this.Controls.Add(this.lblResSom);
            this.Controls.Add(this.lblGem);
            this.Controls.Add(this.lblSom);
            this.Controls.Add(this.btnAantal);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtInvoer);
            this.Controls.Add(this.lblInvoer);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtInvoer;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.Button btnAantal;
        private System.Windows.Forms.Label lblSom;
        private System.Windows.Forms.Label lblGem;
        private System.Windows.Forms.Label lblResSom;
        private System.Windows.Forms.Label lblResGem;
    }
}