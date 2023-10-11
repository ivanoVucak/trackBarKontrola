namespace trackBarKontrola
{
    partial class Form1
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
            this.vrijednostTrb = new System.Windows.Forms.TrackBar();
            this.text1Lbl = new System.Windows.Forms.Label();
            this.vrijednostTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vrijednostTrb)).BeginInit();
            this.SuspendLayout();
            // 
            // vrijednostTrb
            // 
            this.vrijednostTrb.Location = new System.Drawing.Point(12, 27);
            this.vrijednostTrb.Maximum = 100;
            this.vrijednostTrb.Name = "vrijednostTrb";
            this.vrijednostTrb.Size = new System.Drawing.Size(338, 45);
            this.vrijednostTrb.TabIndex = 0;
            this.vrijednostTrb.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // text1Lbl
            // 
            this.text1Lbl.AutoSize = true;
            this.text1Lbl.Location = new System.Drawing.Point(25, 92);
            this.text1Lbl.Name = "text1Lbl";
            this.text1Lbl.Size = new System.Drawing.Size(127, 13);
            this.text1Lbl.TabIndex = 1;
            this.text1Lbl.Text = "Postavljena vrijednost je: ";
            // 
            // vrijednostTb
            // 
            this.vrijednostTb.Location = new System.Drawing.Point(159, 92);
            this.vrijednostTb.Name = "vrijednostTb";
            this.vrijednostTb.Size = new System.Drawing.Size(36, 20);
            this.vrijednostTb.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 169);
            this.Controls.Add(this.vrijednostTb);
            this.Controls.Add(this.text1Lbl);
            this.Controls.Add(this.vrijednostTrb);
            this.Name = "Form1";
            this.Text = "Upotreba TrackBar kontrole";
            ((System.ComponentModel.ISupportInitialize)(this.vrijednostTrb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar vrijednostTrb;
        private System.Windows.Forms.Label text1Lbl;
        private System.Windows.Forms.TextBox vrijednostTb;
    }
}

