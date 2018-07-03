namespace Examen_Carlos_Aguila
{
    partial class PACMAN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PACMAN));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblscore = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.pinkghost = new System.Windows.Forms.PictureBox();
            this.redghost = new System.Windows.Forms.PictureBox();
            this.barra1 = new System.Windows.Forms.PictureBox();
            this.barra2 = new System.Windows.Forms.PictureBox();
            this.cherry = new System.Windows.Forms.PictureBox();
            this.pera = new System.Windows.Forms.PictureBox();
            this.barra3 = new System.Windows.Forms.PictureBox();
            this.tmrpacman = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "pacman";
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblscore.Location = new System.Drawing.Point(12, 9);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(47, 13);
            this.lblscore.TabIndex = 1;
            this.lblscore.Text = "SCORE:";
            this.lblscore.Visible = false;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblnombre.Location = new System.Drawing.Point(286, 9);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "NOMBRE:";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(349, 6);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.Text = "INSERTAR NOMBRE";
            this.txtnombre.Visible = false;
            // 
            // pinkghost
            // 
            this.pinkghost.Image = ((System.Drawing.Image)(resources.GetObject("pinkghost.Image")));
            this.pinkghost.Location = new System.Drawing.Point(75, 172);
            this.pinkghost.Name = "pinkghost";
            this.pinkghost.Size = new System.Drawing.Size(23, 24);
            this.pinkghost.TabIndex = 4;
            this.pinkghost.TabStop = false;
            // 
            // redghost
            // 
            this.redghost.Image = ((System.Drawing.Image)(resources.GetObject("redghost.Image")));
            this.redghost.Location = new System.Drawing.Point(349, 211);
            this.redghost.Name = "redghost";
            this.redghost.Size = new System.Drawing.Size(25, 25);
            this.redghost.TabIndex = 5;
            this.redghost.TabStop = false;
            // 
            // barra1
            // 
            this.barra1.Image = ((System.Drawing.Image)(resources.GetObject("barra1.Image")));
            this.barra1.Location = new System.Drawing.Point(-27, 122);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(65, 239);
            this.barra1.TabIndex = 6;
            this.barra1.TabStop = false;
            // 
            // barra2
            // 
            this.barra2.Image = ((System.Drawing.Image)(resources.GetObject("barra2.Image")));
            this.barra2.Location = new System.Drawing.Point(436, 93);
            this.barra2.Name = "barra2";
            this.barra2.Size = new System.Drawing.Size(50, 290);
            this.barra2.TabIndex = 7;
            this.barra2.TabStop = false;
            // 
            // cherry
            // 
            this.cherry.Image = ((System.Drawing.Image)(resources.GetObject("cherry.Image")));
            this.cherry.Location = new System.Drawing.Point(136, 93);
            this.cherry.Name = "cherry";
            this.cherry.Size = new System.Drawing.Size(20, 25);
            this.cherry.TabIndex = 8;
            this.cherry.TabStop = false;
            // 
            // pera
            // 
            this.pera.Image = ((System.Drawing.Image)(resources.GetObject("pera.Image")));
            this.pera.Location = new System.Drawing.Point(182, 290);
            this.pera.Name = "pera";
            this.pera.Size = new System.Drawing.Size(21, 21);
            this.pera.TabIndex = 9;
            this.pera.TabStop = false;
            // 
            // barra3
            // 
            this.barra3.Image = ((System.Drawing.Image)(resources.GetObject("barra3.Image")));
            this.barra3.Location = new System.Drawing.Point(268, 132);
            this.barra3.Name = "barra3";
            this.barra3.Size = new System.Drawing.Size(65, 166);
            this.barra3.TabIndex = 10;
            this.barra3.TabStop = false;
            // 
            // tmrpacman
            // 
            this.tmrpacman.Enabled = true;
            this.tmrpacman.Tick += new System.EventHandler(this.tmrpacman_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PACMAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(481, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barra3);
            this.Controls.Add(this.pera);
            this.Controls.Add(this.cherry);
            this.Controls.Add(this.barra2);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.redghost);
            this.Controls.Add(this.pinkghost);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PACMAN";
            this.Text = "PACMAN";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PACMAN_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PACMAN_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.PictureBox pinkghost;
        private System.Windows.Forms.PictureBox redghost;
        private System.Windows.Forms.PictureBox barra1;
        private System.Windows.Forms.PictureBox barra2;
        private System.Windows.Forms.PictureBox cherry;
        private System.Windows.Forms.PictureBox pera;
        private System.Windows.Forms.PictureBox barra3;
        private System.Windows.Forms.Timer tmrpacman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

