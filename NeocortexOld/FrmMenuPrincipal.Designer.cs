namespace Neocortex
{
    partial class FrmMenuPrincipal
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btMaximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelSubMenuCatalogo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMenu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btReportes = new Bunifu.Framework.UI.BunifuTileButton();
            this.btProcesos = new Bunifu.Framework.UI.BunifuTileButton();
            this.btCatalogos = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelContenidoPrincipal = new System.Windows.Forms.Panel();
            this.logoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizar)).BeginInit();
            this.panelSubMenuCatalogo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(100)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.panel3);
            this.logoTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 33);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btCerrar);
            this.panel3.Controls.Add(this.btMaximizar);
            this.panel3.Controls.Add(this.btMinimizar);
            this.logoTransition.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1097, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 33);
            this.panel3.TabIndex = 3;
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.Color.Transparent;
            this.logoTransition.SetDecoration(this.btCerrar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btCerrar, BunifuAnimatorNS.DecorationType.None);
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
            // btMaximizar
            // 
            this.btMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.logoTransition.SetDecoration(this.btMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.btMaximizar.Image = global::NeoCortexOld.Properties.Resources.Maximize_Window_32px;
            this.btMaximizar.ImageActive = null;
            this.btMaximizar.Location = new System.Drawing.Point(118, 3);
            this.btMaximizar.Name = "btMaximizar";
            this.btMaximizar.Size = new System.Drawing.Size(32, 32);
            this.btMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMaximizar.TabIndex = 1;
            this.btMaximizar.TabStop = false;
            this.btMaximizar.Zoom = 10;
            this.btMaximizar.Click += new System.EventHandler(this.btMaximizar_Click);
            // 
            // btMinimizar
            // 
            this.btMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.logoTransition.SetDecoration(this.btMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btMinimizar.Image = global::NeoCortexOld.Properties.Resources.Minimize_Window_32px;
            this.btMinimizar.ImageActive = null;
            this.btMinimizar.Location = new System.Drawing.Point(83, 3);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(32, 32);
            this.btMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMinimizar.TabIndex = 2;
            this.btMinimizar.TabStop = false;
            this.btMinimizar.Zoom = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel3;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = null;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 1F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // panelSubMenuCatalogo
            // 
            this.panelSubMenuCatalogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSubMenuCatalogo.BackgroundImage")));
            this.panelSubMenuCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSubMenuCatalogo.Controls.Add(this.panelSubMenu);
            this.panelSubMenuCatalogo.Controls.Add(this.panel2);
            this.logoTransition.SetDecoration(this.panelSubMenuCatalogo, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelSubMenuCatalogo, BunifuAnimatorNS.DecorationType.None);
            this.panelSubMenuCatalogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSubMenuCatalogo.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(100)))), ((int)(((byte)(77)))));
            this.panelSubMenuCatalogo.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(100)))), ((int)(((byte)(77)))));
            this.panelSubMenuCatalogo.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(100)))), ((int)(((byte)(77)))));
            this.panelSubMenuCatalogo.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(100)))), ((int)(((byte)(77)))));
            this.panelSubMenuCatalogo.Location = new System.Drawing.Point(55, 33);
            this.panelSubMenuCatalogo.Name = "panelSubMenuCatalogo";
            this.panelSubMenuCatalogo.Quality = 10;
            this.panelSubMenuCatalogo.Size = new System.Drawing.Size(211, 579);
            this.panelSubMenuCatalogo.TabIndex = 5;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.logoTransition.SetDecoration(this.panelSubMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelSubMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 89);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(211, 490);
            this.panelSubMenu.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.labelMenu);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.btMenu);
            this.logoTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 89);
            this.panel2.TabIndex = 4;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.labelMenu, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.labelMenu, BunifuAnimatorNS.DecorationType.None);
            this.labelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(0, 64);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(96, 25);
            this.labelMenu.TabIndex = 8;
            this.labelMenu.Text = "Catalogos";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(100)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Neo Cortex";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Enabled = false;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::NeoCortexOld.Properties.Resources.Knight_96px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(100)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(183, 43);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "Neo Cortex";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btMenu
            // 
            this.btMenu.BackColor = System.Drawing.Color.Transparent;
            this.logoTransition.SetDecoration(this.btMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btMenu, BunifuAnimatorNS.DecorationType.None);
            this.btMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMenu.Image = global::NeoCortexOld.Properties.Resources.Menu_96px;
            this.btMenu.ImageActive = null;
            this.btMenu.Location = new System.Drawing.Point(177, 0);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(34, 89);
            this.btMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMenu.TabIndex = 5;
            this.btMenu.TabStop = false;
            this.btMenu.Zoom = 10;
            this.btMenu.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.btReportes);
            this.panelMenu.Controls.Add(this.btProcesos);
            this.panelMenu.Controls.Add(this.btCatalogos);
            this.panelMenu.Controls.Add(this.panel4);
            this.logoTransition.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(100)))), ((int)(((byte)(77)))));
            this.panelMenu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(100)))), ((int)(((byte)(77)))));
            this.panelMenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(100)))), ((int)(((byte)(77)))));
            this.panelMenu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(100)))), ((int)(((byte)(77)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 33);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Quality = 10;
            this.panelMenu.Size = new System.Drawing.Size(55, 579);
            this.panelMenu.TabIndex = 1;
            // 
            // btReportes
            // 
            this.btReportes.BackColor = System.Drawing.Color.Transparent;
            this.btReportes.color = System.Drawing.Color.Transparent;
            this.btReportes.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.btReportes, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btReportes, BunifuAnimatorNS.DecorationType.None);
            this.btReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btReportes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportes.ForeColor = System.Drawing.Color.White;
            this.btReportes.Image = global::NeoCortexOld.Properties.Resources.Report_Card_96px;
            this.btReportes.ImagePosition = 12;
            this.btReportes.ImageZoom = 50;
            this.btReportes.LabelPosition = 26;
            this.btReportes.LabelText = "Reportes";
            this.btReportes.Location = new System.Drawing.Point(0, 215);
            this.btReportes.Margin = new System.Windows.Forms.Padding(6);
            this.btReportes.Name = "btReportes";
            this.btReportes.Size = new System.Drawing.Size(55, 63);
            this.btReportes.TabIndex = 10;
            this.btReportes.Click += new System.EventHandler(this.btReportes_Click);
            // 
            // btProcesos
            // 
            this.btProcesos.BackColor = System.Drawing.Color.Transparent;
            this.btProcesos.color = System.Drawing.Color.Transparent;
            this.btProcesos.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btProcesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.btProcesos, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btProcesos, BunifuAnimatorNS.DecorationType.None);
            this.btProcesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btProcesos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcesos.ForeColor = System.Drawing.Color.White;
            this.btProcesos.Image = global::NeoCortexOld.Properties.Resources.Process_96px;
            this.btProcesos.ImagePosition = 12;
            this.btProcesos.ImageZoom = 50;
            this.btProcesos.LabelPosition = 26;
            this.btProcesos.LabelText = "Procesos";
            this.btProcesos.Location = new System.Drawing.Point(0, 152);
            this.btProcesos.Margin = new System.Windows.Forms.Padding(6);
            this.btProcesos.Name = "btProcesos";
            this.btProcesos.Size = new System.Drawing.Size(55, 63);
            this.btProcesos.TabIndex = 9;
            this.btProcesos.Click += new System.EventHandler(this.btProcesos_Click_1);
            // 
            // btCatalogos
            // 
            this.btCatalogos.BackColor = System.Drawing.Color.Transparent;
            this.btCatalogos.color = System.Drawing.Color.Transparent;
            this.btCatalogos.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btCatalogos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.btCatalogos, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btCatalogos, BunifuAnimatorNS.DecorationType.None);
            this.btCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCatalogos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCatalogos.ForeColor = System.Drawing.Color.White;
            this.btCatalogos.Image = global::NeoCortexOld.Properties.Resources.List_96px;
            this.btCatalogos.ImagePosition = 12;
            this.btCatalogos.ImageZoom = 50;
            this.btCatalogos.LabelPosition = 26;
            this.btCatalogos.LabelText = "Catálogos";
            this.btCatalogos.Location = new System.Drawing.Point(0, 89);
            this.btCatalogos.Margin = new System.Windows.Forms.Padding(6);
            this.btCatalogos.Name = "btCatalogos";
            this.btCatalogos.Size = new System.Drawing.Size(55, 63);
            this.btCatalogos.TabIndex = 8;
            this.btCatalogos.Click += new System.EventHandler(this.btMenuGenerico_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.logoTransition.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(55, 89);
            this.panel4.TabIndex = 4;
            // 
            // panelContenidoPrincipal
            // 
            this.logoTransition.SetDecoration(this.panelContenidoPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelContenidoPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.panelContenidoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenidoPrincipal.Location = new System.Drawing.Point(266, 33);
            this.panelContenidoPrincipal.Name = "panelContenidoPrincipal";
            this.panelContenidoPrincipal.Size = new System.Drawing.Size(1030, 579);
            this.panelContenidoPrincipal.TabIndex = 7;
            // 
            // logoTransition
            // 
            this.logoTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.logoTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.logoTransition.DefaultAnimation = animation1;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1296, 612);
            this.Controls.Add(this.panelContenidoPrincipal);
            this.Controls.Add(this.panelSubMenuCatalogo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizar)).EndInit();
            this.panelSubMenuCatalogo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMenu)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuImageButton btCerrar;
        private Bunifu.Framework.UI.BunifuImageButton btMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btMaximizar;
        private System.Windows.Forms.Panel panel3;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private BunifuAnimatorNS.BunifuTransition logoTransition;
        private Bunifu.Framework.UI.BunifuGradientPanel panelMenu;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuTileButton btCatalogos;
        private Bunifu.Framework.UI.BunifuTileButton btReportes;
        private Bunifu.Framework.UI.BunifuTileButton btProcesos;
        private Bunifu.Framework.UI.BunifuGradientPanel panelSubMenuCatalogo;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuImageButton btMenu;
        private Bunifu.Framework.UI.BunifuCustomLabel labelMenu;
        private System.Windows.Forms.Panel panelContenidoPrincipal;
        private System.Windows.Forms.Panel panelSubMenu;
    }
}

