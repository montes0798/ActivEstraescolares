namespace Presentacion
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnListas = new FontAwesome.Sharp.IconButton();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.BtnConstancias = new FontAwesome.Sharp.IconButton();
            this.BtnGrupo = new FontAwesome.Sharp.IconButton();
            this.BtnActividad = new FontAwesome.Sharp.IconButton();
            this.BtnAgregarUsuario = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblPuesto = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.iconInicio = new FontAwesome.Sharp.IconButton();
            this.BtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.BtnTamaño = new FontAwesome.Sharp.IconButton();
            this.BtnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.BtnInicio = new System.Windows.Forms.PictureBox();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.BtnAlumnos = new FontAwesome.Sharp.IconButton();
            this.PanelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.PanelMenu.Controls.Add(this.BtnAlumnos);
            this.PanelMenu.Controls.Add(this.BtnListas);
            this.PanelMenu.Controls.Add(this.BtnSalir);
            this.PanelMenu.Controls.Add(this.BtnConstancias);
            this.PanelMenu.Controls.Add(this.BtnGrupo);
            this.PanelMenu.Controls.Add(this.BtnActividad);
            this.PanelMenu.Controls.Add(this.BtnAgregarUsuario);
            this.PanelMenu.Controls.Add(this.panel2);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(205, 640);
            this.PanelMenu.TabIndex = 0;
            // 
            // BtnListas
            // 
            this.BtnListas.FlatAppearance.BorderSize = 0;
            this.BtnListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnListas.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnListas.ForeColor = System.Drawing.Color.White;
            this.BtnListas.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.BtnListas.IconColor = System.Drawing.Color.White;
            this.BtnListas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnListas.IconSize = 48;
            this.BtnListas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListas.Location = new System.Drawing.Point(0, 318);
            this.BtnListas.Name = "BtnListas";
            this.BtnListas.Rotation = 0D;
            this.BtnListas.Size = new System.Drawing.Size(205, 48);
            this.BtnListas.TabIndex = 6;
            this.BtnListas.Text = "Listas";
            this.BtnListas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListas.UseVisualStyleBackColor = true;
            this.BtnListas.Click += new System.EventHandler(this.BtnListas_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.BtnSalir.IconColor = System.Drawing.Color.White;
            this.BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSalir.IconSize = 48;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(0, 426);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Rotation = 0D;
            this.BtnSalir.Size = new System.Drawing.Size(205, 48);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnConstancias
            // 
            this.BtnConstancias.FlatAppearance.BorderSize = 0;
            this.BtnConstancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConstancias.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnConstancias.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnConstancias.ForeColor = System.Drawing.Color.White;
            this.BtnConstancias.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.BtnConstancias.IconColor = System.Drawing.Color.White;
            this.BtnConstancias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConstancias.IconSize = 48;
            this.BtnConstancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConstancias.Location = new System.Drawing.Point(0, 372);
            this.BtnConstancias.Name = "BtnConstancias";
            this.BtnConstancias.Rotation = 0D;
            this.BtnConstancias.Size = new System.Drawing.Size(205, 48);
            this.BtnConstancias.TabIndex = 4;
            this.BtnConstancias.Text = "Constancias";
            this.BtnConstancias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConstancias.UseVisualStyleBackColor = true;
            this.BtnConstancias.Click += new System.EventHandler(this.BtnConstancias_Click);
            // 
            // BtnGrupo
            // 
            this.BtnGrupo.FlatAppearance.BorderSize = 0;
            this.BtnGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrupo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnGrupo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnGrupo.ForeColor = System.Drawing.Color.White;
            this.BtnGrupo.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnGrupo.IconColor = System.Drawing.Color.White;
            this.BtnGrupo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGrupo.IconSize = 48;
            this.BtnGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGrupo.Location = new System.Drawing.Point(0, 210);
            this.BtnGrupo.Name = "BtnGrupo";
            this.BtnGrupo.Rotation = 0D;
            this.BtnGrupo.Size = new System.Drawing.Size(205, 48);
            this.BtnGrupo.TabIndex = 3;
            this.BtnGrupo.Text = "Grupo";
            this.BtnGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGrupo.UseVisualStyleBackColor = true;
            this.BtnGrupo.Click += new System.EventHandler(this.BtnGrupo_Click);
            // 
            // BtnActividad
            // 
            this.BtnActividad.FlatAppearance.BorderSize = 0;
            this.BtnActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActividad.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnActividad.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnActividad.ForeColor = System.Drawing.Color.White;
            this.BtnActividad.IconChar = FontAwesome.Sharp.IconChar.Running;
            this.BtnActividad.IconColor = System.Drawing.Color.White;
            this.BtnActividad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnActividad.IconSize = 48;
            this.BtnActividad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActividad.Location = new System.Drawing.Point(0, 156);
            this.BtnActividad.Name = "BtnActividad";
            this.BtnActividad.Rotation = 0D;
            this.BtnActividad.Size = new System.Drawing.Size(205, 48);
            this.BtnActividad.TabIndex = 2;
            this.BtnActividad.Text = "Actividad";
            this.BtnActividad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnActividad.UseVisualStyleBackColor = true;
            this.BtnActividad.Click += new System.EventHandler(this.BtnActividad_Click);
            // 
            // BtnAgregarUsuario
            // 
            this.BtnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarUsuario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAgregarUsuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnAgregarUsuario.IconColor = System.Drawing.Color.White;
            this.BtnAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregarUsuario.IconSize = 48;
            this.BtnAgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarUsuario.Location = new System.Drawing.Point(0, 102);
            this.BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            this.BtnAgregarUsuario.Rotation = 0D;
            this.BtnAgregarUsuario.Size = new System.Drawing.Size(205, 48);
            this.BtnAgregarUsuario.TabIndex = 1;
            this.BtnAgregarUsuario.Text = "Usuario";
            this.BtnAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarUsuario.UseVisualStyleBackColor = true;
            this.BtnAgregarUsuario.Click += new System.EventHandler(this.BtnAgregarUsuario_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.LblPuesto);
            this.panel2.Controls.Add(this.LblApellido);
            this.panel2.Controls.Add(this.LblNombre);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 96);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(170)))), ((int)(((byte)(171)))));
            this.panel4.Location = new System.Drawing.Point(205, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(651, 4);
            this.panel4.TabIndex = 2;
            // 
            // LblPuesto
            // 
            this.LblPuesto.AutoSize = true;
            this.LblPuesto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuesto.ForeColor = System.Drawing.Color.White;
            this.LblPuesto.Location = new System.Drawing.Point(100, 50);
            this.LblPuesto.Name = "LblPuesto";
            this.LblPuesto.Size = new System.Drawing.Size(46, 16);
            this.LblPuesto.TabIndex = 3;
            this.LblPuesto.Text = "Puesto";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.ForeColor = System.Drawing.Color.White;
            this.LblApellido.Location = new System.Drawing.Point(100, 34);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(58, 16);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellido";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(100, 18);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 16);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.iconPictureBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 96;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(114, 96);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.PanelSuperior.Controls.Add(this.iconInicio);
            this.PanelSuperior.Controls.Add(this.BtnMinimizar);
            this.PanelSuperior.Controls.Add(this.BtnTamaño);
            this.PanelSuperior.Controls.Add(this.BtnCerrar);
            this.PanelSuperior.Controls.Add(this.label1);
            this.PanelSuperior.Controls.Add(this.pictureBox1);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(205, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(819, 56);
            this.PanelSuperior.TabIndex = 1;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // iconInicio
            // 
            this.iconInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconInicio.FlatAppearance.BorderSize = 0;
            this.iconInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconInicio.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconInicio.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.iconInicio.ForeColor = System.Drawing.Color.White;
            this.iconInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconInicio.IconColor = System.Drawing.Color.White;
            this.iconInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconInicio.IconSize = 40;
            this.iconInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconInicio.Location = new System.Drawing.Point(0, 3);
            this.iconInicio.Name = "iconInicio";
            this.iconInicio.Rotation = 0D;
            this.iconInicio.Size = new System.Drawing.Size(97, 52);
            this.iconInicio.TabIndex = 5;
            this.iconInicio.Text = "Inicio";
            this.iconInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconInicio.UseVisualStyleBackColor = true;
            this.iconInicio.Click += new System.EventHandler(this.iconInicio_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.BtnMinimizar.IconColor = System.Drawing.Color.White;
            this.BtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimizar.IconSize = 18;
            this.BtnMinimizar.Location = new System.Drawing.Point(749, 3);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Rotation = 180D;
            this.BtnMinimizar.Size = new System.Drawing.Size(25, 23);
            this.BtnMinimizar.TabIndex = 4;
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnTamaño
            // 
            this.BtnTamaño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTamaño.FlatAppearance.BorderSize = 0;
            this.BtnTamaño.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnTamaño.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BtnTamaño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTamaño.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnTamaño.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.BtnTamaño.IconColor = System.Drawing.Color.White;
            this.BtnTamaño.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTamaño.IconSize = 18;
            this.BtnTamaño.Location = new System.Drawing.Point(771, 3);
            this.BtnTamaño.Name = "BtnTamaño";
            this.BtnTamaño.Rotation = 0D;
            this.BtnTamaño.Size = new System.Drawing.Size(25, 23);
            this.BtnTamaño.TabIndex = 3;
            this.BtnTamaño.UseVisualStyleBackColor = true;
            this.BtnTamaño.Click += new System.EventHandler(this.BtnTamaño_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnCerrar.IconColor = System.Drawing.Color.White;
            this.BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCerrar.IconSize = 20;
            this.BtnCerrar.Location = new System.Drawing.Point(794, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Rotation = 0D;
            this.BtnCerrar.Size = new System.Drawing.Size(25, 23);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACTIVIDADES EXTRAESCOLARES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(170)))), ((int)(((byte)(171)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(205, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(819, 5);
            this.panel5.TabIndex = 2;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.White;
            this.PanelPrincipal.Controls.Add(this.panel1);
            this.PanelPrincipal.Controls.Add(this.LblFecha);
            this.PanelPrincipal.Controls.Add(this.LblHora);
            this.PanelPrincipal.Controls.Add(this.BtnInicio);
            this.PanelPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.PanelPrincipal.Location = new System.Drawing.Point(205, 61);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(819, 579);
            this.PanelPrincipal.TabIndex = 3;
            this.PanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPrincipal_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(170)))), ((int)(((byte)(171)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 579);
            this.panel1.TabIndex = 3;
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.LblFecha.Location = new System.Drawing.Point(220, 457);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(97, 33);
            this.LblFecha.TabIndex = 2;
            this.LblFecha.Text = "Fecha";
            // 
            // LblHora
            // 
            this.LblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.LblHora.Location = new System.Drawing.Point(308, 408);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(114, 49);
            this.LblHora.TabIndex = 1;
            this.LblHora.Text = "Hora";
            // 
            // BtnInicio
            // 
            this.BtnInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnInicio.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnInicio.Image = ((System.Drawing.Image)(resources.GetObject("BtnInicio.Image")));
            this.BtnInicio.Location = new System.Drawing.Point(149, 82);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(555, 354);
            this.BtnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.TabStop = false;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // BtnAlumnos
            // 
            this.BtnAlumnos.FlatAppearance.BorderSize = 0;
            this.BtnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlumnos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAlumnos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAlumnos.ForeColor = System.Drawing.Color.White;
            this.BtnAlumnos.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.BtnAlumnos.IconColor = System.Drawing.Color.White;
            this.BtnAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAlumnos.IconSize = 48;
            this.BtnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlumnos.Location = new System.Drawing.Point(0, 264);
            this.BtnAlumnos.Name = "BtnAlumnos";
            this.BtnAlumnos.Rotation = 0D;
            this.BtnAlumnos.Size = new System.Drawing.Size(205, 48);
            this.BtnAlumnos.TabIndex = 7;
            this.BtnAlumnos.Text = "Alumnos";
            this.BtnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAlumnos.UseVisualStyleBackColor = true;
            this.BtnAlumnos.Click += new System.EventHandler(this.BtnAlumnos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.PanelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelSuperior;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BtnConstancias;
        private FontAwesome.Sharp.IconButton BtnGrupo;
        private FontAwesome.Sharp.IconButton BtnActividad;
        private FontAwesome.Sharp.IconButton BtnAgregarUsuario;
        private System.Windows.Forms.Label LblPuesto;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton BtnMinimizar;
        private FontAwesome.Sharp.IconButton BtnTamaño;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer HoraFecha;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton iconInicio;
        private System.Windows.Forms.PictureBox BtnInicio;
        private FontAwesome.Sharp.IconButton BtnListas;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnAlumnos;
    }
}