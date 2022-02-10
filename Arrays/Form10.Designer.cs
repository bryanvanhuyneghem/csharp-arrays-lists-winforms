namespace Arrays
{
    partial class Form10
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
            this.txtFib = new System.Windows.Forms.TextBox();
            this.btnFib = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFib
            // 
            this.txtFib.Location = new System.Drawing.Point(152, 221);
            this.txtFib.Multiline = true;
            this.txtFib.Name = "txtFib";
            this.txtFib.Size = new System.Drawing.Size(514, 143);
            this.txtFib.TabIndex = 0;
            // 
            // btnFib
            // 
            this.btnFib.Location = new System.Drawing.Point(374, 179);
            this.btnFib.Name = "btnFib";
            this.btnFib.Size = new System.Drawing.Size(75, 23);
            this.btnFib.TabIndex = 1;
            this.btnFib.Text = "FiboGo!";
            this.btnFib.UseVisualStyleBackColor = true;
            this.btnFib.Click += new System.EventHandler(this.btnFib_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFib);
            this.Controls.Add(this.txtFib);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFib;
        private System.Windows.Forms.Button btnFib;
    }
}