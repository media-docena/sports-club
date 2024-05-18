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
            pnlCentro = new System.Windows.Forms.Panel();
            pnlDer = new System.Windows.Forms.Panel();
            picPass = new System.Windows.Forms.PictureBox();
            picUser = new System.Windows.Forms.PictureBox();
            picLock = new System.Windows.Forms.PictureBox();
            txtPass = new System.Windows.Forms.TextBox();
            txtUsuario = new System.Windows.Forms.TextBox();
            btnIngresar = new System.Windows.Forms.Button();
            pnlTop = new System.Windows.Forms.Panel();
            picCross = new System.Windows.Forms.PictureBox();
            pnlIzq = new System.Windows.Forms.Panel();
            picLogo = new System.Windows.Forms.PictureBox();
            pnlCentro.SuspendLayout();
            pnlDer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLock).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCross).BeginInit();
            pnlIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlCentro
            // 
            pnlCentro.BackColor = System.Drawing.Color.White;
            pnlCentro.Controls.Add(pnlDer);
            pnlCentro.Controls.Add(pnlIzq);
            pnlCentro.Location = new System.Drawing.Point(160, 172);
            pnlCentro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlCentro.Name = "pnlCentro";
            pnlCentro.Size = new System.Drawing.Size(971, 630);
            pnlCentro.TabIndex = 0;
            // 
            // pnlDer
            // 
            pnlDer.Controls.Add(picPass);
            pnlDer.Controls.Add(picUser);
            pnlDer.Controls.Add(picLock);
            pnlDer.Controls.Add(txtPass);
            pnlDer.Controls.Add(txtUsuario);
            pnlDer.Controls.Add(btnIngresar);
            pnlDer.Controls.Add(pnlTop);
            pnlDer.Dock = System.Windows.Forms.DockStyle.Right;
            pnlDer.Location = new System.Drawing.Point(408, 0);
            pnlDer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDer.Name = "pnlDer";
            pnlDer.Size = new System.Drawing.Size(563, 630);
            pnlDer.TabIndex = 1;
            // 
            // picPass
            // 
            picPass.Image = Properties.Resources.icons_lock_30;
            picPass.Location = new System.Drawing.Point(31, 326);
            picPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            picPass.Name = "picPass";
            picPass.Size = new System.Drawing.Size(62, 54);
            picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picPass.TabIndex = 6;
            picPass.TabStop = false;
            // 
            // picUser
            // 
            picUser.Image = Properties.Resources.icons_user_24;
            picUser.Location = new System.Drawing.Point(31, 202);
            picUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            picUser.Name = "picUser";
            picUser.Size = new System.Drawing.Size(62, 54);
            picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picUser.TabIndex = 5;
            picUser.TabStop = false;
            // 
            // picLock
            // 
            picLock.Image = Properties.Resources.icons_lock_50;
            picLock.Location = new System.Drawing.Point(229, 86);
            picLock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            picLock.Name = "picLock";
            picLock.Size = new System.Drawing.Size(118, 80);
            picLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLock.TabIndex = 4;
            picLock.TabStop = false;
            // 
            // txtPass
            // 
            txtPass.BackColor = System.Drawing.Color.White;
            txtPass.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPass.ForeColor = System.Drawing.Color.FromArgb(63, 61, 83);
            txtPass.Location = new System.Drawing.Point(89, 326);
            txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPass.MaxLength = 50;
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(432, 38);
            txtPass.TabIndex = 3;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = System.Drawing.Color.White;
            txtUsuario.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = System.Drawing.Color.FromArgb(63, 61, 83);
            txtUsuario.Location = new System.Drawing.Point(89, 202);
            txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUsuario.MaxLength = 50;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(432, 38);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = System.Drawing.Color.FromArgb(56, 200, 191);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIngresar.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = System.Drawing.Color.FromArgb(63, 61, 86);
            btnIngresar.Location = new System.Drawing.Point(46, 448);
            btnIngresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(475, 72);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(picCross);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Location = new System.Drawing.Point(0, 0);
            pnlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(563, 65);
            pnlTop.TabIndex = 0;
            // 
            // picCross
            // 
            picCross.Dock = System.Windows.Forms.DockStyle.Right;
            picCross.Image = Properties.Resources.icons_cross_50;
            picCross.Location = new System.Drawing.Point(482, 0);
            picCross.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            picCross.Name = "picCross";
            picCross.Size = new System.Drawing.Size(81, 65);
            picCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            picCross.TabIndex = 0;
            picCross.TabStop = false;
            picCross.Click += picCross_Click;
            // 
            // pnlIzq
            // 
            pnlIzq.Controls.Add(picLogo);
            pnlIzq.Dock = System.Windows.Forms.DockStyle.Left;
            pnlIzq.Location = new System.Drawing.Point(0, 0);
            pnlIzq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlIzq.Name = "pnlIzq";
            pnlIzq.Size = new System.Drawing.Size(408, 630);
            pnlIzq.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = System.Drawing.Color.White;
            picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            picLogo.Image = Properties.Resources.clubdepor1;
            picLogo.Location = new System.Drawing.Point(0, 0);
            picLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(408, 630);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(56, 200, 191);
            ClientSize = new System.Drawing.Size(1333, 1034);
            Controls.Add(pnlCentro);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(1333, 1018);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LOGIN";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmLogin_Load;
            KeyPress += frmLogin_KeyPress;
            pnlCentro.ResumeLayout(false);
            pnlDer.ResumeLayout(false);
            pnlDer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLock).EndInit();
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCross).EndInit();
            pnlIzq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
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

