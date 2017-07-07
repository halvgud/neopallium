namespace Neocortex
{
    partial class FrmLogin
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.fader = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.barra = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btLogIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btLogo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(67)))), ((int)(((byte)(48)))));
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(136)))), ((int)(((byte)(112)))));
            this.bunifuColorTransition1.ProgessValue = 1;
            // 
            // fader
            // 
            this.fader.Enabled = true;
            this.fader.Interval = 25;
            this.fader.Tick += new System.EventHandler(this.fader_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(100)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 33);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btCerrar);
            this.panel3.Controls.Add(this.btMinimizar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(220, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 33);
            this.panel3.TabIndex = 3;
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btCerrar.Image = global::NeoCortexOld.Properties.Resources.Delete_48px;
            this.btCerrar.ImageActive = null;
            this.btCerrar.Location = new System.Drawing.Point(156, 3);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(32, 32);
            this.btCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btCerrar.TabIndex = 0;
            this.btCerrar.TabStop = false;
            this.btCerrar.Zoom = 10;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // btMinimizar
            // 
            this.btMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btMinimizar.Image = global::NeoCortexOld.Properties.Resources.Minimize_Window_32px;
            this.btMinimizar.ImageActive = null;
            this.btMinimizar.Location = new System.Drawing.Point(118, 3);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(32, 32);
            this.btMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMinimizar.TabIndex = 2;
            this.btMinimizar.TabStop = false;
            this.btMinimizar.Zoom = 10;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.HintForeColor = System.Drawing.Color.White;
            this.txtUsuario.HintText = "Usuario";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(136)))), ((int)(((byte)(112)))));
            this.txtUsuario.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(67)))), ((int)(((byte)(48)))));
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(136)))), ((int)(((byte)(112)))));
            this.txtUsuario.LineThickness = 4;
            this.txtUsuario.Location = new System.Drawing.Point(59, 178);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(302, 44);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColorFocused = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.txtPassword.BorderThickness = 3;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(59, 233);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(302, 44);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.Transparent;
            this.barra.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(67)))), ((int)(((byte)(48)))));
            this.barra.LineThickness = 4;
            this.barra.Location = new System.Drawing.Point(59, 265);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(302, 35);
            this.barra.TabIndex = 10;
            this.barra.Transparency = 255;
            this.barra.Vertical = false;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.panel3;
            this.bunifuDragControl3.Vertical = true;
            // 
            // btLogIn
            // 
            this.btLogIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLogIn.BorderRadius = 0;
            this.btLogIn.ButtonText = "Autenticar";
            this.btLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogIn.DisabledColor = System.Drawing.Color.Gray;
            this.btLogIn.Iconcolor = System.Drawing.Color.Transparent;
            this.btLogIn.Iconimage = global::NeoCortexOld.Properties.Resources.Fingerprint_Scan_96px;
            this.btLogIn.Iconimage_right = null;
            this.btLogIn.Iconimage_right_Selected = null;
            this.btLogIn.Iconimage_Selected = null;
            this.btLogIn.IconMarginLeft = 0;
            this.btLogIn.IconMarginRight = 0;
            this.btLogIn.IconRightVisible = true;
            this.btLogIn.IconRightZoom = 0D;
            this.btLogIn.IconVisible = true;
            this.btLogIn.IconZoom = 90D;
            this.btLogIn.IsTab = false;
            this.btLogIn.Location = new System.Drawing.Point(88, 306);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btLogIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btLogIn.OnHoverTextColor = System.Drawing.Color.White;
            this.btLogIn.selected = false;
            this.btLogIn.Size = new System.Drawing.Size(241, 39);
            this.btLogIn.TabIndex = 3;
            this.btLogIn.Text = "Autenticar";
            this.btLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btLogIn.Textcolor = System.Drawing.Color.White;
            this.btLogIn.TextFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // btLogo
            // 
            this.btLogo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btLogo.BackColor = System.Drawing.Color.Transparent;
            this.btLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLogo.BorderRadius = 0;
            this.btLogo.ButtonText = "Neo Cortex";
            this.btLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogo.DisabledColor = System.Drawing.Color.Transparent;
            this.btLogo.Enabled = false;
            this.btLogo.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.btLogo.Iconcolor = System.Drawing.Color.Transparent;
            this.btLogo.Iconimage = global::NeoCortexOld.Properties.Resources.Knight_96px;
            this.btLogo.Iconimage_right = null;
            this.btLogo.Iconimage_right_Selected = null;
            this.btLogo.Iconimage_Selected = null;
            this.btLogo.IconMarginLeft = 0;
            this.btLogo.IconMarginRight = 0;
            this.btLogo.IconRightVisible = true;
            this.btLogo.IconRightZoom = 0D;
            this.btLogo.IconVisible = true;
            this.btLogo.IconZoom = 90D;
            this.btLogo.IsTab = true;
            this.btLogo.Location = new System.Drawing.Point(59, 82);
            this.btLogo.Margin = new System.Windows.Forms.Padding(6);
            this.btLogo.Name = "btLogo";
            this.btLogo.Normalcolor = System.Drawing.Color.Transparent;
            this.btLogo.OnHovercolor = System.Drawing.Color.Transparent;
            this.btLogo.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btLogo.selected = false;
            this.btLogo.Size = new System.Drawing.Size(302, 94);
            this.btLogo.TabIndex = 7;
            this.btLogo.TabStop = false;
            this.btLogo.Text = "Neo Cortex";
            this.btLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btLogo.Textcolor = System.Drawing.Color.White;
            this.btLogo.TextFont = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 357);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btLogo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private System.Windows.Forms.Timer fader;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton btCerrar;
        private Bunifu.Framework.UI.BunifuImageButton btMinimizar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton btLogo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuSeparator barra;
        private Bunifu.Framework.UI.BunifuFlatButton btLogIn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
    }
}