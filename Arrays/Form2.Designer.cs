namespace Arrays
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
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtInvoer = new System.Windows.Forms.TextBox();
            this.lblInvoer = new System.Windows.Forms.Label();
            this.lblKeuze = new System.Windows.Forms.Label();
            this.txtKeuze = new System.Windows.Forms.TextBox();
            this.btnToonGetal = new System.Windows.Forms.Button();
            this.lblResultaat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(442, 118);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(77, 20);
            this.btnBereken.TabIndex = 10;
            this.btnBereken.Text = "Opslaan";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // txtInvoer
            // 
            this.txtInvoer.Location = new System.Drawing.Point(260, 118);
            this.txtInvoer.Name = "txtInvoer";
            this.txtInvoer.Size = new System.Drawing.Size(163, 20);
            this.txtInvoer.TabIndex = 9;
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(200, 121);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(40, 13);
            this.lblInvoer.TabIndex = 8;
            this.lblInvoer.Text = "Invoer:";
            // 
            // lblKeuze
            // 
            this.lblKeuze.AutoSize = true;
            this.lblKeuze.Location = new System.Drawing.Point(200, 166);
            this.lblKeuze.Name = "lblKeuze";
            this.lblKeuze.Size = new System.Drawing.Size(162, 13);
            this.lblKeuze.TabIndex = 11;
            this.lblKeuze.Text = "Het hoeveelste getal wil je zien? ";
            // 
            // txtKeuze
            // 
            this.txtKeuze.Location = new System.Drawing.Point(368, 163);
            this.txtKeuze.Name = "txtKeuze";
            this.txtKeuze.Size = new System.Drawing.Size(25, 20);
            this.txtKeuze.TabIndex = 12;
            // 
            // btnToonGetal
            // 
            this.btnToonGetal.Location = new System.Drawing.Point(442, 161);
            this.btnToonGetal.Name = "btnToonGetal";
            this.btnToonGetal.Size = new System.Drawing.Size(75, 23);
            this.btnToonGetal.TabIndex = 13;
            this.btnToonGetal.Text = "Toon getal";
            this.btnToonGetal.UseVisualStyleBackColor = true;
            this.btnToonGetal.Click += new System.EventHandler(this.btnToonGetal_Click);
            // 
            // lblResultaat
            // 
            this.lblResultaat.AutoSize = true;
            this.lblResultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultaat.Location = new System.Drawing.Point(375, 223);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(0, 25);
            this.lblResultaat.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultaat);
            this.Controls.Add(this.btnToonGetal);
            this.Controls.Add(this.txtKeuze);
            this.Controls.Add(this.lblKeuze);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtInvoer);
            this.Controls.Add(this.lblInvoer);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Click += new System.EventHandler(this.btnBereken_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtInvoer;
        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.Label lblKeuze;
        private System.Windows.Forms.TextBox txtKeuze;
        private System.Windows.Forms.Button btnToonGetal;
        private System.Windows.Forms.Label lblResultaat;
    }
}