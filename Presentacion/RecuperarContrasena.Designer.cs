namespace Presentacion
{
    partial class RecuperarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContrasena));
            this.IconoMinimizar = new FontAwesome.Sharp.IconButton();
            this.IconoCerrar = new FontAwesome.Sharp.IconButton();
            this.LblRecuperar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblAvisoContrasena = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IconoMinimizar
            // 
            this.IconoMinimizar.FlatAppearance.BorderSize = 0;
            this.IconoMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.IconoMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.IconoMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconoMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconoMinimizar.ForeColor = System.Drawing.Color.Black;
            this.IconoMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.IconoMinimizar.IconColor = System.Drawing.Color.White;
            this.IconoMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoMinimizar.IconSize = 20;
            this.IconoMinimizar.Location = new System.Drawing.Point(745, 1);
            this.IconoMinimizar.Name = "IconoMinimizar";
            this.IconoMinimizar.Rotation = 180D;
            this.IconoMinimizar.Size = new System.Drawing.Size(28, 25);
            this.IconoMinimizar.TabIndex = 4;
            this.IconoMinimizar.UseVisualStyleBackColor = true;
            this.IconoMinimizar.Click += new System.EventHandler(this.IconoMinimizar_Click);
            // 
            // IconoCerrar
            // 
            this.IconoCerrar.FlatAppearance.BorderSize = 0;
            this.IconoCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.IconoCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.IconoCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconoCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconoCerrar.ForeColor = System.Drawing.Color.Black;
            this.IconoCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.IconoCerrar.IconColor = System.Drawing.Color.White;
            this.IconoCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoCerrar.IconSize = 20;
            this.IconoCerrar.Location = new System.Drawing.Point(772, 1);
            this.IconoCerrar.Name = "IconoCerrar";
            this.IconoCerrar.Rotation = 0D;
            this.IconoCerrar.Size = new System.Drawing.Size(28, 25);
            this.IconoCerrar.TabIndex = 3;
            this.IconoCerrar.UseVisualStyleBackColor = true;
            this.IconoCerrar.Click += new System.EventHandler(this.IconoCerrar_Click);
            // 
            // LblRecuperar
            // 
            this.LblRecuperar.AutoSize = true;
            this.LblRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblRecuperar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecuperar.ForeColor = System.Drawing.Color.White;
            this.LblRecuperar.Location = new System.Drawing.Point(47, 86);
            this.LblRecuperar.Name = "LblRecuperar";
            this.LblRecuperar.Size = new System.Drawing.Size(288, 19);
            this.LblRecuperar.TabIndex = 5;
            this.LblRecuperar.Text = "Ingrese usuario o correo electrónico:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recuperación de contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TxtUsuario.Location = new System.Drawing.Point(51, 131);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(402, 24);
            this.TxtUsuario.TabIndex = 0;
            // 
            // LblAvisoContrasena
            // 
            this.LblAvisoContrasena.AutoSize = true;
            this.LblAvisoContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblAvisoContrasena.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvisoContrasena.ForeColor = System.Drawing.Color.White;
            this.LblAvisoContrasena.Location = new System.Drawing.Point(48, 213);
            this.LblAvisoContrasena.Name = "LblAvisoContrasena";
            this.LblAvisoContrasena.Size = new System.Drawing.Size(40, 16);
            this.LblAvisoContrasena.TabIndex = 8;
            this.LblAvisoContrasena.Text = "Aviso";
            this.LblAvisoContrasena.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button1.Location = new System.Drawing.Point(378, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(534, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 229);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // RecuperarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblAvisoContrasena);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblRecuperar);
            this.Controls.Add(this.IconoMinimizar);
            this.Controls.Add(this.IconoCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecuperarContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarContrasena";
            this.Load += new System.EventHandler(this.RecuperarContrasena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton IconoMinimizar;
        private FontAwesome.Sharp.IconButton IconoCerrar;
        private System.Windows.Forms.Label LblRecuperar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblAvisoContrasena;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}