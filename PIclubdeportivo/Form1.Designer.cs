namespace PIclubdeportivo
{
    partial class frmLogin
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
            if (disposing && (components != null)) {
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
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.pnlDer = new System.Windows.Forms.Panel();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.picLock = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.picCross = new System.Windows.Forms.PictureBox();
            this.pnlIzq = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlCentro.SuspendLayout();
            this.pnlDer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCross)).BeginInit();
            this.pnlIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.White;
            this.pnlCentro.Controls.Add(this.pnlDer);
            this.pnlCentro.Controls.Add(this.pnlIzq);
            this.pnlCentro.Location = new System.Drawing.Point(160, 138);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(971, 504);
            this.pnlCentro.TabIndex = 0;
            // 
            // pnlDer
            // 
            this.pnlDer.Controls.Add(this.picPass);
            this.pnlDer.Controls.Add(this.picUser);
            this.pnlDer.Controls.Add(this.picLock);
            this.pnlDer.Controls.Add(this.txtPass);
            this.pnlDer.Controls.Add(this.txtUsuario);
            this.pnlDer.Controls.Add(this.btnIngresar);
            this.pnlDer.Controls.Add(this.pnlTop);
            this.pnlDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDer.Location = new System.Drawing.Point(408, 0);
            this.pnlDer.Name = "pnlDer";
            this.pnlDer.Size = new System.Drawing.Size(563, 504);
            this.pnlDer.TabIndex = 1;
            // 
            // picPass
            // 
            this.picPass.Image = global::PIclubdeportivo.Properties.Resources.icons_lock_30;
            this.picPass.Location = new System.Drawing.Point(31, 261);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(62, 43);
            this.picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPass.TabIndex = 6;
            this.picPass.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Image = global::PIclubdeportivo.Properties.Resources.icons_user_24;
            this.picUser.Location = new System.Drawing.Point(31, 162);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(62, 43);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 5;
            this.picUser.TabStop = false;
            // 
            // picLock
            // 
            this.picLock.Image = global::PIclubdeportivo.Properties.Resources.icons_lock_50;
            this.picLock.Location = new System.Drawing.Point(229, 69);
            this.picLock.Name = "picLock";
            this.picLock.Size = new System.Drawing.Size(118, 64);
            this.picLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLock.TabIndex = 4;
            this.picLock.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtPass.Location = new System.Drawing.Point(89, 261);
            this.txtPass.MaxLength = 50;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(432, 38);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "CONTRASEÑA";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtUsuario.Location = new System.Drawing.Point(89, 162);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(432, 38);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(200)))), ((int)(((byte)(191)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.btnIngresar.Location = new System.Drawing.Point(46, 358);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(475, 58);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.picCross);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(563, 52);
            this.pnlTop.TabIndex = 0;
            // 
            // picCross
            // 
            this.picCross.Dock = System.Windows.Forms.DockStyle.Right;
            this.picCross.Image = global::PIclubdeportivo.Properties.Resources.icons_cross_50;
            this.picCross.Location = new System.Drawing.Point(482, 0);
            this.picCross.Name = "picCross";
            this.picCross.Size = new System.Drawing.Size(81, 52);
            this.picCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCross.TabIndex = 0;
            this.picCross.TabStop = false;
            this.picCross.Click += new System.EventHandler(this.picCross_Click);
            // 
            // pnlIzq
            // 
            this.pnlIzq.Controls.Add(this.picLogo);
            this.pnlIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzq.Location = new System.Drawing.Point(0, 0);
            this.pnlIzq.Name = "pnlIzq";
            this.pnlIzq.Size = new System.Drawing.Size(408, 504);
            this.pnlIzq.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = global::PIclubdeportivo.Properties.Resources.clubdepor1;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(408, 504);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(200)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1333, 827);
            this.Controls.Add(this.pnlCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1333, 827);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlCentro.ResumeLayout(false);
            this.pnlDer.ResumeLayout(false);
            this.pnlDer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCross)).EndInit();
            this.pnlIzq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Panel pnlIzq;
        private System.Windows.Forms.Panel pnlDer;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox picLock;
        private System.Windows.Forms.PictureBox picCross;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox picPass;
    }
}

