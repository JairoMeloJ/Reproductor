
namespace Reproductor
{
    partial class Reproductor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Biblioteca = new System.Windows.Forms.PictureBox();
            this.Video = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Biblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1216, 699);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Biblioteca
            // 
            this.Biblioteca.BackColor = System.Drawing.Color.Black;
            this.Biblioteca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Biblioteca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Biblioteca.Image = ((System.Drawing.Image)(resources.GetObject("Biblioteca.Image")));
            this.Biblioteca.Location = new System.Drawing.Point(1171, 12);
            this.Biblioteca.Name = "Biblioteca";
            this.Biblioteca.Size = new System.Drawing.Size(31, 23);
            this.Biblioteca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Biblioteca.TabIndex = 1;
            this.Biblioteca.TabStop = false;
            this.Biblioteca.Click += new System.EventHandler(this.Biblioteca_Click);
            // 
            // Video
            // 
            this.Video.AutoSize = true;
            this.Video.BackColor = System.Drawing.Color.Transparent;
            this.Video.ForeColor = System.Drawing.Color.Black;
            this.Video.Location = new System.Drawing.Point(282, 678);
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(34, 13);
            this.Video.TabIndex = 2;
            this.Video.Text = "Video";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 700);
            this.Controls.Add(this.Video);
            this.Controls.Add(this.Biblioteca);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Reproductor";
            this.Text = "Reproductor";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Biblioteca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox Biblioteca;
        private System.Windows.Forms.Label Video;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

