namespace reproductorMultimedia
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mpmediaplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbvistaarchivos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mpmediaplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // mpmediaplayer
            // 
            this.mpmediaplayer.Enabled = true;
            this.mpmediaplayer.Location = new System.Drawing.Point(12, 12);
            this.mpmediaplayer.Name = "mpmediaplayer";
            this.mpmediaplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpmediaplayer.OcxState")));
            this.mpmediaplayer.Size = new System.Drawing.Size(540, 370);
            this.mpmediaplayer.TabIndex = 0;
            // 
            // lbvistaarchivos
            // 
            this.lbvistaarchivos.FormattingEnabled = true;
            this.lbvistaarchivos.Location = new System.Drawing.Point(558, 12);
            this.lbvistaarchivos.Name = "lbvistaarchivos";
            this.lbvistaarchivos.Size = new System.Drawing.Size(160, 316);
            this.lbvistaarchivos.TabIndex = 1;
            this.lbvistaarchivos.SelectedIndexChanged += new System.EventHandler(this.lbvistaarchivos_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbvistaarchivos);
            this.Controls.Add(this.mpmediaplayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mpmediaplayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mpmediaplayer;
        private System.Windows.Forms.ListBox lbvistaarchivos;
        private System.Windows.Forms.Button button1;
    }
}

