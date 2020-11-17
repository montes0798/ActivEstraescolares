namespace Presentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IconoCerrar = new FontAwesome.Sharp.IconButton();
            this.IconoMinimizar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.BtnAcceder = new System.Windows.Forms.Button();
            this.LblAviso = new System.Windows.Forms.Label();
            this.iconoAviso = new FontAwesome.Sharp.IconPictureBox();
            this.LnkContrasena = new System.Windows.Forms.LinkLabel();
            this.ChckContrasena = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoAviso)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 450);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "EXTRAESCOLARES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACTIVIDADES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IconoCerrar
            // 
            this.IconoCerrar.FlatAppearance.BorderSize = 0;
            this.IconoCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.IconoCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.IconoCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconoCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconoCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.IconoCerrar.IconColor = System.Drawing.Color.Black;
            this.IconoCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoCerrar.IconSize = 20;
            this.IconoCerrar.Location = new System.Drawing.Point(772, 0);
            this.IconoCerrar.Name = "IconoCerrar";
            this.IconoCerrar.Rotation = 0D;
            this.IconoCerrar.Size = new System.Drawing.Size(28, 25);
            this.IconoCerrar.TabIndex = 1;
            this.IconoCerrar.UseVisualStyleBackColor = true;
            this.IconoCerrar.Click += new System.EventHandler(this.IconoCerrar_Click);
            // 
            // IconoMinimizar
            // 
            this.IconoMinimizar.FlatAppearance.BorderSize = 0;
            this.IconoMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.IconoMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.IconoMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconoMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconoMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.IconoMinimizar.IconColor = System.Drawing.Color.Black;
            this.IconoMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoMinimizar.IconSize = 20;
            this.IconoMinimizar.Location = new System.Drawing.Point(745, 0);
            this.IconoMinimizar.Name = "IconoMinimizar";
            this.IconoMinimizar.Rotation = 180D;
            this.IconoMinimizar.Size = new System.Drawing.Size(28, 25);
            this.IconoMinimizar.TabIndex = 2;
            this.IconoMinimizar.UseVisualStyleBackColor = true;
            this.IconoMinimizar.Click += new System.EventHandler(this.IconoMinimizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(538, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "LOGIN";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 450);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 424;
            this.lineShape2.X2 = 731;
            this.lineShape2.Y1 = 227;
            this.lineShape2.Y2 = 227;
            // 
            // lineShape1
            // 
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 423;
            this.lineShape1.X2 = 730;
            this.lineShape1.Y1 = 129;
            this.lineShape1.Y2 = 129;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUsuario.Location = new System.Drawing.Point(423, 104);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(308, 20);
            this.TxtUsuario.TabIndex = 8;
            this.TxtUsuario.Text = "USUARIO";
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasena.ForeColor = System.Drawing.Color.DimGray;
            this.TxtContrasena.Location = new System.Drawing.Point(424, 201);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(308, 20);
            this.TxtContrasena.TabIndex = 2;
            this.TxtContrasena.Text = "CONTRASEÑA";
            this.TxtContrasena.Enter += new System.EventHandler(this.TxtContrasena_Enter);
            this.TxtContrasena.Leave += new System.EventHandler(this.TxtContrasena_Leave);
            // 
            // BtnAcceder
            // 
            this.BtnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(85)))), ((int)(((byte)(87)))));
            this.BtnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(170)))), ((int)(((byte)(171)))));
            this.BtnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcceder.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAcceder.Location = new System.Drawing.Point(423, 322);
            this.BtnAcceder.Name = "BtnAcceder";
            this.BtnAcceder.Size = new System.Drawing.Size(308, 32);
            this.BtnAcceder.TabIndex = 3;
            this.BtnAcceder.Text = "ACCEDER";
            this.BtnAcceder.UseVisualStyleBackColor = true;
            this.BtnAcceder.Click += new System.EventHandler(this.BtnAcceder_Click);
            // 
            // LblAviso
            // 
            this.LblAviso.AutoSize = true;
            this.LblAviso.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.LblAviso.Location = new System.Drawing.Point(445, 260);
            this.LblAviso.Name = "LblAviso";
            this.LblAviso.Size = new System.Drawing.Size(41, 17);
            this.LblAviso.TabIndex = 8;
            this.LblAviso.Text = "Aviso";
            this.LblAviso.Visible = false;
            // 
            // iconoAviso
            // 
            this.iconoAviso.BackColor = System.Drawing.Color.White;
            this.iconoAviso.ForeColor = System.Drawing.Color.Red;
            this.iconoAviso.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.iconoAviso.IconColor = System.Drawing.Color.Red;
            this.iconoAviso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoAviso.IconSize = 25;
            this.iconoAviso.Location = new System.Drawing.Point(423, 260);
            this.iconoAviso.Name = "iconoAviso";
            this.iconoAviso.Size = new System.Drawing.Size(25, 25);
            this.iconoAviso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconoAviso.TabIndex = 9;
            this.iconoAviso.TabStop = false;
            this.iconoAviso.Visible = false;
            // 
            // LnkContrasena
            // 
            this.LnkContrasena.ActiveLinkColor = System.Drawing.Color.Black;
            this.LnkContrasena.AutoSize = true;
            this.LnkContrasena.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.LnkContrasena.LinkColor = System.Drawing.Color.Black;
            this.LnkContrasena.Location = new System.Drawing.Point(498, 370);
            this.LnkContrasena.Name = "LnkContrasena";
            this.LnkContrasena.Size = new System.Drawing.Size(169, 16);
            this.LnkContrasena.TabIndex = 10;
            this.LnkContrasena.TabStop = true;
            this.LnkContrasena.Text = "¿Ha olvidado la contraseña?";
            this.LnkContrasena.VisitedLinkColor = System.Drawing.Color.Black;
            this.LnkContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkContrasena_LinkClicked);
            // 
            // ChckContrasena
            // 
            this.ChckContrasena.AutoSize = true;
            this.ChckContrasena.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChckContrasena.Location = new System.Drawing.Point(648, 201);
            this.ChckContrasena.Name = "ChckContrasena";
            this.ChckContrasena.Size = new System.Drawing.Size(134, 20);
            this.ChckContrasena.TabIndex = 11;
            this.ChckContrasena.Text = "Mostrar Contraseña";
            this.ChckContrasena.UseVisualStyleBackColor = true;
            this.ChckContrasena.CheckedChanged += new System.EventHandler(this.ChckContrasena_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChckContrasena);
            this.Controls.Add(this.LnkContrasena);
            this.Controls.Add(this.iconoAviso);
            this.Controls.Add(this.LblAviso);
            this.Controls.Add(this.BtnAcceder);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IconoMinimizar);
            this.Controls.Add(this.IconoCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoAviso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton IconoCerrar;
        private FontAwesome.Sharp.IconButton IconoMinimizar;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Button BtnAcceder;
        private System.Windows.Forms.Label LblAviso;
        private FontAwesome.Sharp.IconPictureBox iconoAviso;
        private System.Windows.Forms.LinkLabel LnkContrasena;
        private System.Windows.Forms.CheckBox ChckContrasena;
    }
}

