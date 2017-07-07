namespace Neocortex
{
    partial class ucCorteDiario
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem4 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem5 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel5 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Litros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faltante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superTabControl2 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabItem6 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel6 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleLitros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl2)).BeginInit();
            this.superTabControl2.SuspendLayout();
            this.superTabControlPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // superTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel5);
            this.superTabControl1.Controls.Add(this.superTabControlPanel4);
            this.superTabControl1.Controls.Add(this.superTabControlPanel3);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.Location = new System.Drawing.Point(0, 0);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 1;
            this.superTabControl1.Size = new System.Drawing.Size(965, 615);
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabIndex = 0;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem5,
            this.superTabItem2,
            this.superTabItem3,
            this.superTabItem4});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Dock;
            this.superTabControl1.Text = "superTabControl1";
            this.superTabControl1.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.superTabControl1_SelectedTabChanged);
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "Corte Global";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(965, 518);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "Cortes por Turno";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(965, 518);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.superTabControlPanel3;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "Cortes por Isla";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(965, 518);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.superTabItem3;
            // 
            // superTabItem4
            // 
            this.superTabItem4.AttachedControl = this.superTabControlPanel4;
            this.superTabItem4.GlobalItem = false;
            this.superTabItem4.Name = "superTabItem4";
            this.superTabItem4.Text = "Cortes por Bomba";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(965, 518);
            this.superTabControlPanel4.TabIndex = 0;
            this.superTabControlPanel4.TabItem = this.superTabItem4;
            // 
            // superTabItem5
            // 
            this.superTabItem5.AttachedControl = this.superTabControlPanel5;
            this.superTabItem5.GlobalItem = false;
            this.superTabItem5.Name = "superTabItem5";
            this.superTabItem5.Text = "Cortes por despachador";
            // 
            // superTabControlPanel5
            // 
            this.superTabControlPanel5.Controls.Add(this.tableLayoutPanel3);
            this.superTabControlPanel5.Controls.Add(this.tableLayoutPanel4);
            this.superTabControlPanel5.Controls.Add(this.panel1);
            this.superTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel5.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel5.Name = "superTabControlPanel5";
            this.superTabControlPanel5.Size = new System.Drawing.Size(965, 590);
            this.superTabControlPanel5.TabIndex = 0;
            this.superTabControlPanel5.TabItem = this.superTabItem5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 40);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 11);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Despachador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(195, 40);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtBuscar, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(195, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.80645F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.19355F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(770, 40);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBuscar.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtBuscar.BorderThickness = 3;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.isPassword = false;
            this.txtBuscar.Location = new System.Drawing.Point(4, 12);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(377, 25);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.224576F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.77542F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.486188F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.51381F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(965, 312);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.SaldoIni,
            this.SaldoFin,
            this.Turno,
            this.Hora,
            this.Precio,
            this.Litros,
            this.IVA,
            this.Faltante,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(24, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.118644F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.88136F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.superTabControl2, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 352);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.19048F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(965, 238);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // SaldoIni
            // 
            this.SaldoIni.HeaderText = "Saldo Inicial";
            this.SaldoIni.Name = "SaldoIni";
            // 
            // SaldoFin
            // 
            this.SaldoFin.HeaderText = "Saldo Final";
            this.SaldoFin.Name = "SaldoFin";
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.Width = 50;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.Width = 50;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 50;
            // 
            // Litros
            // 
            this.Litros.HeaderText = "Litros";
            this.Litros.Name = "Litros";
            this.Litros.Width = 75;
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.Width = 75;
            // 
            // Faltante
            // 
            this.Faltante.HeaderText = "Faltante";
            this.Faltante.Name = "Faltante";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // superTabControl2
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl2.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl2.ControlBox.MenuBox.Name = "";
            this.superTabControl2.ControlBox.Name = "";
            this.superTabControl2.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl2.ControlBox.MenuBox,
            this.superTabControl2.ControlBox.CloseBox});
            this.superTabControl2.Controls.Add(this.superTabControlPanel6);
            this.superTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl2.Location = new System.Drawing.Point(23, 3);
            this.superTabControl2.Name = "superTabControl2";
            this.superTabControl2.ReorderTabsEnabled = true;
            this.superTabControl2.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl2.SelectedTabIndex = 0;
            this.superTabControl2.Size = new System.Drawing.Size(918, 175);
            this.superTabControl2.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl2.TabIndex = 0;
            this.superTabControl2.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem6});
            this.superTabControl2.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Dock;
            this.superTabControl2.Text = "superTabControl2";
            // 
            // superTabItem6
            // 
            this.superTabItem6.AttachedControl = this.superTabControlPanel6;
            this.superTabItem6.GlobalItem = false;
            this.superTabItem6.Name = "superTabItem6";
            this.superTabItem6.Text = "superTabItem6";
            // 
            // superTabControlPanel6
            // 
            this.superTabControlPanel6.Controls.Add(this.dataGridView2);
            this.superTabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel6.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel6.Name = "superTabControlPanel6";
            this.superTabControlPanel6.Size = new System.Drawing.Size(918, 150);
            this.superTabControlPanel6.TabIndex = 1;
            this.superTabControlPanel6.TabItem = this.superTabItem6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Tipo,
            this.TipoPago,
            this.DetalleTotal,
            this.DetalleLitros,
            this.DetalleProducto});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(918, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // TipoPago
            // 
            this.TipoPago.HeaderText = "Tipo de Pago";
            this.TipoPago.Name = "TipoPago";
            // 
            // DetalleTotal
            // 
            this.DetalleTotal.HeaderText = "Total";
            this.DetalleTotal.Name = "DetalleTotal";
            // 
            // DetalleLitros
            // 
            this.DetalleLitros.HeaderText = "Litros";
            this.DetalleLitros.Name = "DetalleLitros";
            // 
            // DetalleProducto
            // 
            this.DetalleProducto.HeaderText = "Producto";
            this.DetalleProducto.Name = "DetalleProducto";
            // 
            // ucCorteDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.superTabControl1);
            this.Name = "ucCorteDiario";
            this.Size = new System.Drawing.Size(965, 615);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl2)).EndInit();
            this.superTabControl2.ResumeLayout(false);
            this.superTabControlPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel5;
        private DevComponents.DotNetBar.SuperTabItem superTabItem5;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem superTabItem4;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Litros;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faltante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevComponents.DotNetBar.SuperTabControl superTabControl2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleLitros;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleProducto;
        private DevComponents.DotNetBar.SuperTabItem superTabItem6;
    }
}
