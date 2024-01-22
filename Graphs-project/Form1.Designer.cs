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
      this.clearButton = new System.Windows.Forms.Button();
      this.DFSradioButton = new System.Windows.Forms.RadioButton();
      this.BFSradioButton = new System.Windows.Forms.RadioButton();
      this.algorithmGroupBox = new System.Windows.Forms.GroupBox();
      this.StartButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.drawingZone)).BeginInit();
      this.algorithmGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // drawingZone
      // 
      this.drawingZone.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.drawingZone.Location = new System.Drawing.Point(12, 12);
      this.drawingZone.Name = "drawingZone";
      this.drawingZone.Size = new System.Drawing.Size(500, 500);
      this.drawingZone.TabIndex = 0;
      this.drawingZone.TabStop = false;
      this.drawingZone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingZone_MouseDown);
      this.drawingZone.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingZone_MouseUp);
      // 
      // clearButton
      // 
      this.clearButton.Location = new System.Drawing.Point(699, 31);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(69, 38);
      this.clearButton.TabIndex = 1;
      this.clearButton.Text = "Clear";
      this.clearButton.UseVisualStyleBackColor = true;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // DFSradioButton
      // 
      this.DFSradioButton.AutoSize = true;
      this.DFSradioButton.Location = new System.Drawing.Point(7, 19);
      this.DFSradioButton.Name = "DFSradioButton";
      this.DFSradioButton.Size = new System.Drawing.Size(46, 17);
      this.DFSradioButton.TabIndex = 2;
      this.DFSradioButton.TabStop = true;
      this.DFSradioButton.Text = "DFS";
      this.DFSradioButton.UseVisualStyleBackColor = true;
      // 
      // BFSradioButton
      // 
      this.BFSradioButton.AutoSize = true;
      this.BFSradioButton.Location = new System.Drawing.Point(7, 42);
      this.BFSradioButton.Name = "BFSradioButton";
      this.BFSradioButton.Size = new System.Drawing.Size(45, 17);
      this.BFSradioButton.TabIndex = 3;
      this.BFSradioButton.TabStop = true;
      this.BFSradioButton.Text = "BFS";
      this.BFSradioButton.UseVisualStyleBackColor = true;
      // 
      // algorithmGroupBox
      // 
      this.algorithmGroupBox.Controls.Add(this.BFSradioButton);
      this.algorithmGroupBox.Controls.Add(this.DFSradioButton);
      this.algorithmGroupBox.Location = new System.Drawing.Point(527, 12);
      this.algorithmGroupBox.Name = "algorithmGroupBox";
      this.algorithmGroupBox.Size = new System.Drawing.Size(69, 69);
      this.algorithmGroupBox.TabIndex = 4;
      this.algorithmGroupBox.TabStop = false;
      this.algorithmGroupBox.Text = "Algorithm";
      // 
      // StartButton
      // 
      this.StartButton.Location = new System.Drawing.Point(613, 31);
      this.StartButton.Name = "StartButton";
      this.StartButton.Size = new System.Drawing.Size(69, 38);
      this.StartButton.TabIndex = 5;
      this.StartButton.Text = "Start";
      this.StartButton.UseVisualStyleBackColor = true;
      this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
      // 
      // GraphsMainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(784, 531);
      this.Controls.Add(this.StartButton);
      this.Controls.Add(this.algorithmGroupBox);
      this.Controls.Add(this.clearButton);
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
      this.algorithmGroupBox.ResumeLayout(false);
      this.algorithmGroupBox.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawingZone;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton DFSradioButton;
        private System.Windows.Forms.RadioButton BFSradioButton;
        private System.Windows.Forms.GroupBox algorithmGroupBox;
        private System.Windows.Forms.Button StartButton;
    }
}

