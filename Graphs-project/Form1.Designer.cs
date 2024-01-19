namespace Graphs_project
{
    partial class GraphsMainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
      this.drawingZone = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.drawingZone)).BeginInit();
      this.SuspendLayout();
      // 
      // drawingZone
      // 
      this.drawingZone.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.drawingZone.Location = new System.Drawing.Point(272, 19);
      this.drawingZone.Name = "drawingZone";
      this.drawingZone.Size = new System.Drawing.Size(500, 500);
      this.drawingZone.TabIndex = 0;
      this.drawingZone.TabStop = false;
      // 
      // GraphsMainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(784, 531);
      this.Controls.Add(this.drawingZone);
      this.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(800, 570);
      this.MinimumSize = new System.Drawing.Size(800, 570);
      this.Name = "GraphsMainForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Graphs";
      ((System.ComponentModel.ISupportInitialize)(this.drawingZone)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingZone;
    }
}

