namespace CalM2Baht
{
    partial class TableForm
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
            this.labelRate = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelBaht = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRate.Location = new System.Drawing.Point(12, 9);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(0, 25);
            this.labelRate.TabIndex = 0;
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelM.Location = new System.Drawing.Point(12, 34);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(0, 25);
            this.labelM.TabIndex = 0;
            // 
            // labelBaht
            // 
            this.labelBaht.AutoSize = true;
            this.labelBaht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaht.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBaht.Location = new System.Drawing.Point(330, 34);
            this.labelBaht.Name = "labelBaht";
            this.labelBaht.Size = new System.Drawing.Size(0, 25);
            this.labelBaht.TabIndex = 0;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 302);
            this.Controls.Add(this.labelBaht);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelRate);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Table M2Baht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelBaht;
    }
}