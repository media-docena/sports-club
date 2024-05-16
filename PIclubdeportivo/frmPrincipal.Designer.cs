namespace PIclubdeportivo
{
    partial class frmPrincipal
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
            pnlNavbar = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            lblIngreso = new System.Windows.Forms.Label();
            btnSalirNav = new System.Windows.Forms.Button();
            pnlLogoNav = new System.Windows.Forms.Panel();
            btnRegistrarC = new System.Windows.Forms.Button();
            btnAbonar = new System.Windows.Forms.Button();
            btnListarCuotasVenc = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            picAbonar = new System.Windows.Forms.PictureBox();
            picRegistrarC = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pnlNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAbonar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRegistrarC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlNavbar
            // 
            pnlNavbar.BackColor = System.Drawing.Color.FromArgb(75, 91, 106);
            pnlNavbar.Controls.Add(pictureBox2);
            pnlNavbar.Controls.Add(lblIngreso);
            pnlNavbar.Controls.Add(btnSalirNav);
            pnlNavbar.Controls.Add(pnlLogoNav);
            pnlNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlNavbar.Location = new System.Drawing.Point(0, 0);
            pnlNavbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlNavbar.Name = "pnlNavbar";
            pnlNavbar.Size = new System.Drawing.Size(1318, 125);
            pnlNavbar.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons_user_32;
            pictureBox2.Location = new System.Drawing.Point(685, 40);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(36, 44);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblIngreso.ForeColor = System.Drawing.Color.Cyan;
            lblIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblIngreso.Location = new System.Drawing.Point(734, 49);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new System.Drawing.Size(399, 23);
            lblIngreso.TabIndex = 3;
            lblIngreso.Text = "USUARIO: usuarioPrueba (Administrador)";
            lblIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalirNav
            // 
            btnSalirNav.FlatAppearance.BorderSize = 0;
            btnSalirNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalirNav.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSalirNav.ForeColor = System.Drawing.Color.Cyan;
            btnSalirNav.Image = Properties.Resources.icons_log_out_321;
            btnSalirNav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSalirNav.Location = new System.Drawing.Point(1156, 4);
            btnSalirNav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSalirNav.Name = "btnSalirNav";
            btnSalirNav.Size = new System.Drawing.Size(175, 118);
            btnSalirNav.TabIndex = 2;
            btnSalirNav.Text = "SALIR";
            btnSalirNav.UseVisualStyleBackColor = true;
            btnSalirNav.Click += btnSalirNav_Click;
            // 
            // pnlLogoNav
            // 
            pnlLogoNav.BackColor = System.Drawing.SystemColors.Control;
            pnlLogoNav.Location = new System.Drawing.Point(50, 48);
            pnlLogoNav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlLogoNav.Name = "pnlLogoNav";
            pnlLogoNav.Size = new System.Drawing.Size(148, 225);
            pnlLogoNav.TabIndex = 1;
            // 
            // btnRegistrarC
            // 
            btnRegistrarC.BackColor = System.Drawing.Color.FromArgb(155, 193, 188);
            btnRegistrarC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnRegistrarC.ForeColor = System.Drawing.Color.FromArgb(63, 61, 86);
            btnRegistrarC.Location = new System.Drawing.Point(246, 416);
            btnRegistrarC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRegistrarC.Name = "btnRegistrarC";
            btnRegistrarC.Size = new System.Drawing.Size(237, 138);
            btnRegistrarC.TabIndex = 2;
            btnRegistrarC.Text = "REGISTRAR CLIENTE";
            btnRegistrarC.UseVisualStyleBackColor = false;
            btnRegistrarC.Click += btnRegistrarC_Click;
            // 
            // btnAbonar
            // 
            btnAbonar.BackColor = System.Drawing.Color.FromArgb(155, 193, 188);
            btnAbonar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAbonar.ForeColor = System.Drawing.Color.FromArgb(63, 61, 86);
            btnAbonar.Location = new System.Drawing.Point(557, 416);
            btnAbonar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAbonar.Name = "btnAbonar";
            btnAbonar.Size = new System.Drawing.Size(237, 138);
            btnAbonar.TabIndex = 3;
            btnAbonar.Text = "ABONAR";
            btnAbonar.UseVisualStyleBackColor = false;
            // 
            // btnListarCuotasVenc
            // 
            btnListarCuotasVenc.BackColor = System.Drawing.Color.FromArgb(155, 193, 188);
            btnListarCuotasVenc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnListarCuotasVenc.ForeColor = System.Drawing.Color.FromArgb(63, 61, 86);
            btnListarCuotasVenc.Location = new System.Drawing.Point(869, 416);
            btnListarCuotasVenc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnListarCuotasVenc.Name = "btnListarCuotasVenc";
            btnListarCuotasVenc.Size = new System.Drawing.Size(237, 138);
            btnListarCuotasVenc.TabIndex = 4;
            btnListarCuotasVenc.Text = "LISTAR SOCIOS CON CUOTAS A VENCER";
            btnListarCuotasVenc.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.piggy_bank;
            pictureBox3.Location = new System.Drawing.Point(921, 250);
            pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(129, 119);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // picAbonar
            // 
            picAbonar.Image = Properties.Resources.payment;
            picAbonar.Location = new System.Drawing.Point(610, 250);
            picAbonar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            picAbonar.Name = "picAbonar";
            picAbonar.Size = new System.Drawing.Size(129, 119);
            picAbonar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picAbonar.TabIndex = 6;
            picAbonar.TabStop = false;
            // 
            // picRegistrarC
            // 
            picRegistrarC.Image = Properties.Resources.snap;
            picRegistrarC.Location = new System.Drawing.Point(299, 250);
            picRegistrarC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            picRegistrarC.Name = "picRegistrarC";
            picRegistrarC.Size = new System.Drawing.Size(129, 119);
            picRegistrarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picRegistrarC.TabIndex = 5;
            picRegistrarC.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.clubdepor2;
            pictureBox1.Location = new System.Drawing.Point(53, 51);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(145, 192);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1318, 798);
            Controls.Add(pictureBox3);
            Controls.Add(picAbonar);
            Controls.Add(picRegistrarC);
            Controls.Add(btnListarCuotasVenc);
            Controls.Add(btnAbonar);
            Controls.Add(btnRegistrarC);
            Controls.Add(pictureBox1);
            Controls.Add(pnlNavbar);
            ForeColor = System.Drawing.Color.FromArgb(128, 64, 64);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "VENTANA PRINCIPAL";
            Load += frmPrincipal_Load;
            pnlNavbar.ResumeLayout(false);
            pnlNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAbonar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRegistrarC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlNavbar;
        private System.Windows.Forms.Panel pnlLogoNav;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalirNav;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRegistrarC;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.Button btnListarCuotasVenc;
        private System.Windows.Forms.PictureBox picRegistrarC;
        private System.Windows.Forms.PictureBox picAbonar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}