
namespace Presentacion.Vistas
{
    partial class VistaModificarModelo
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
            this.listadoModelosLB = new System.Windows.Forms.Label();
            this.subGestionarModelosTLP = new System.Windows.Forms.TableLayoutPanel();
            this.listadoModelosPN = new System.Windows.Forms.Panel();
            this.listadoModelosDG = new System.Windows.Forms.DataGridView();
            this.buscarModelosPN = new System.Windows.Forms.Panel();
            this.buscarModelosTB = new System.Windows.Forms.TextBox();
            this.buscarModelosLB = new System.Windows.Forms.Label();
            this.informacionModelosPN = new System.Windows.Forms.Panel();
            this.limiteSuperiorObservadoTB = new System.Windows.Forms.TextBox();
            this.limiteInferiorObservadoTB = new System.Windows.Forms.TextBox();
            this.limiteSuperiorReprocesoTB = new System.Windows.Forms.TextBox();
            this.limiteInferiorReprocesoTB = new System.Windows.Forms.TextBox();
            this.limiteInferiorObservadoLB = new System.Windows.Forms.Label();
            this.limiteSuperiorObservadoLB = new System.Windows.Forms.Label();
            this.limiteInferiorReprocesoLB = new System.Windows.Forms.Label();
            this.limiteSuperiorReprocesoLB = new System.Windows.Forms.Label();
            this.limitesGeneralesLB = new System.Windows.Forms.Label();
            this.visualizarSkuLB = new System.Windows.Forms.Label();
            this.visualizarDenominacionTB = new System.Windows.Forms.TextBox();
            this.denominacionLB = new System.Windows.Forms.Label();
            this.skuLB = new System.Windows.Forms.Label();
            this.confirmarAccionPN = new System.Windows.Forms.Panel();
            this.guardarModificacionesBTN = new System.Windows.Forms.Button();
            this.eleccionBuscarModeloGB = new System.Windows.Forms.GroupBox();
            this.buscarPorSKURB = new System.Windows.Forms.RadioButton();
            this.buscarPorDescripcionRB = new System.Windows.Forms.RadioButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteInferiorReproceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteInferiorObservado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteSuperiorReproceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteSuperiorObservado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subGestionarModelosTLP.SuspendLayout();
            this.listadoModelosPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoModelosDG)).BeginInit();
            this.buscarModelosPN.SuspendLayout();
            this.informacionModelosPN.SuspendLayout();
            this.confirmarAccionPN.SuspendLayout();
            this.eleccionBuscarModeloGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // listadoModelosLB
            // 
            this.listadoModelosLB.AutoSize = true;
            this.listadoModelosLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoModelosLB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.listadoModelosLB.Location = new System.Drawing.Point(20, 17);
            this.listadoModelosLB.Name = "listadoModelosLB";
            this.listadoModelosLB.Size = new System.Drawing.Size(133, 15);
            this.listadoModelosLB.TabIndex = 2;
            this.listadoModelosLB.Text = "Listado de modelos";
            // 
            // subGestionarModelosTLP
            // 
            this.subGestionarModelosTLP.ColumnCount = 2;
            this.subGestionarModelosTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.591F));
            this.subGestionarModelosTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.409F));
            this.subGestionarModelosTLP.Controls.Add(this.listadoModelosPN, 0, 0);
            this.subGestionarModelosTLP.Controls.Add(this.buscarModelosPN, 0, 1);
            this.subGestionarModelosTLP.Controls.Add(this.informacionModelosPN, 1, 0);
            this.subGestionarModelosTLP.Controls.Add(this.confirmarAccionPN, 1, 1);
            this.subGestionarModelosTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subGestionarModelosTLP.Location = new System.Drawing.Point(0, 0);
            this.subGestionarModelosTLP.Name = "subGestionarModelosTLP";
            this.subGestionarModelosTLP.RowCount = 2;
            this.subGestionarModelosTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.33334F));
            this.subGestionarModelosTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.66667F));
            this.subGestionarModelosTLP.Size = new System.Drawing.Size(806, 505);
            this.subGestionarModelosTLP.TabIndex = 2;
            // 
            // listadoModelosPN
            // 
            this.listadoModelosPN.Controls.Add(this.listadoModelosLB);
            this.listadoModelosPN.Controls.Add(this.listadoModelosDG);
            this.listadoModelosPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoModelosPN.Location = new System.Drawing.Point(3, 3);
            this.listadoModelosPN.Name = "listadoModelosPN";
            this.listadoModelosPN.Size = new System.Drawing.Size(296, 374);
            this.listadoModelosPN.TabIndex = 4;
            // 
            // listadoModelosDG
            // 
            this.listadoModelosDG.AllowUserToAddRows = false;
            this.listadoModelosDG.AllowUserToDeleteRows = false;
            this.listadoModelosDG.AllowUserToResizeColumns = false;
            this.listadoModelosDG.AllowUserToResizeRows = false;
            this.listadoModelosDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listadoModelosDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoModelosDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.descripcion,
            this.sku,
            this.limiteInferiorReproceso,
            this.limiteInferiorObservado,
            this.limiteSuperiorReproceso,
            this.limiteSuperiorObservado});
            this.listadoModelosDG.Location = new System.Drawing.Point(23, 52);
            this.listadoModelosDG.MultiSelect = false;
            this.listadoModelosDG.Name = "listadoModelosDG";
            this.listadoModelosDG.ReadOnly = true;
            this.listadoModelosDG.RowHeadersVisible = false;
            this.listadoModelosDG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.listadoModelosDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoModelosDG.Size = new System.Drawing.Size(253, 293);
            this.listadoModelosDG.TabIndex = 5;
            this.listadoModelosDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoModelosDG_CellClick);
            // 
            // buscarModelosPN
            // 
            this.buscarModelosPN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarModelosPN.Controls.Add(this.eleccionBuscarModeloGB);
            this.buscarModelosPN.Controls.Add(this.buscarModelosTB);
            this.buscarModelosPN.Controls.Add(this.buscarModelosLB);
            this.buscarModelosPN.Location = new System.Drawing.Point(3, 383);
            this.buscarModelosPN.Name = "buscarModelosPN";
            this.buscarModelosPN.Size = new System.Drawing.Size(296, 119);
            this.buscarModelosPN.TabIndex = 0;
            // 
            // buscarModelosTB
            // 
            this.buscarModelosTB.Location = new System.Drawing.Point(23, 35);
            this.buscarModelosTB.Name = "buscarModelosTB";
            this.buscarModelosTB.Size = new System.Drawing.Size(253, 20);
            this.buscarModelosTB.TabIndex = 7;
            this.buscarModelosTB.TextChanged += new System.EventHandler(this.buscarModelosTB_TextChanged);
            // 
            // buscarModelosLB
            // 
            this.buscarModelosLB.AutoSize = true;
            this.buscarModelosLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarModelosLB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buscarModelosLB.Location = new System.Drawing.Point(23, 17);
            this.buscarModelosLB.Name = "buscarModelosLB";
            this.buscarModelosLB.Size = new System.Drawing.Size(103, 15);
            this.buscarModelosLB.TabIndex = 6;
            this.buscarModelosLB.Text = "Buscar modelo";
            // 
            // informacionModelosPN
            // 
            this.informacionModelosPN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informacionModelosPN.Controls.Add(this.limiteSuperiorObservadoTB);
            this.informacionModelosPN.Controls.Add(this.limiteInferiorObservadoTB);
            this.informacionModelosPN.Controls.Add(this.limiteSuperiorReprocesoTB);
            this.informacionModelosPN.Controls.Add(this.limiteInferiorReprocesoTB);
            this.informacionModelosPN.Controls.Add(this.limiteInferiorObservadoLB);
            this.informacionModelosPN.Controls.Add(this.limiteSuperiorObservadoLB);
            this.informacionModelosPN.Controls.Add(this.limiteInferiorReprocesoLB);
            this.informacionModelosPN.Controls.Add(this.limiteSuperiorReprocesoLB);
            this.informacionModelosPN.Controls.Add(this.limitesGeneralesLB);
            this.informacionModelosPN.Controls.Add(this.visualizarSkuLB);
            this.informacionModelosPN.Controls.Add(this.visualizarDenominacionTB);
            this.informacionModelosPN.Controls.Add(this.denominacionLB);
            this.informacionModelosPN.Controls.Add(this.skuLB);
            this.informacionModelosPN.Location = new System.Drawing.Point(305, 3);
            this.informacionModelosPN.Name = "informacionModelosPN";
            this.informacionModelosPN.Size = new System.Drawing.Size(498, 374);
            this.informacionModelosPN.TabIndex = 5;
            // 
            // limiteSuperiorObservadoTB
            // 
            this.limiteSuperiorObservadoTB.Location = new System.Drawing.Point(267, 289);
            this.limiteSuperiorObservadoTB.Name = "limiteSuperiorObservadoTB";
            this.limiteSuperiorObservadoTB.Size = new System.Drawing.Size(153, 20);
            this.limiteSuperiorObservadoTB.TabIndex = 24;
            this.limiteSuperiorObservadoTB.TextChanged += new System.EventHandler(this.limiteSuperiorObservadoTV_TextChanged);
            // 
            // limiteInferiorObservadoTB
            // 
            this.limiteInferiorObservadoTB.Location = new System.Drawing.Point(267, 247);
            this.limiteInferiorObservadoTB.Name = "limiteInferiorObservadoTB";
            this.limiteInferiorObservadoTB.Size = new System.Drawing.Size(153, 20);
            this.limiteInferiorObservadoTB.TabIndex = 23;
            this.limiteInferiorObservadoTB.TextChanged += new System.EventHandler(this.limiteInferiorObservadoTB_TextChanged);
            // 
            // limiteSuperiorReprocesoTB
            // 
            this.limiteSuperiorReprocesoTB.Location = new System.Drawing.Point(267, 206);
            this.limiteSuperiorReprocesoTB.Name = "limiteSuperiorReprocesoTB";
            this.limiteSuperiorReprocesoTB.Size = new System.Drawing.Size(153, 20);
            this.limiteSuperiorReprocesoTB.TabIndex = 22;
            this.limiteSuperiorReprocesoTB.TextChanged += new System.EventHandler(this.limiteSuperiorReprocesoLBTB_TextChanged);
            // 
            // limiteInferiorReprocesoTB
            // 
            this.limiteInferiorReprocesoTB.Location = new System.Drawing.Point(267, 167);
            this.limiteInferiorReprocesoTB.Name = "limiteInferiorReprocesoTB";
            this.limiteInferiorReprocesoTB.Size = new System.Drawing.Size(153, 20);
            this.limiteInferiorReprocesoTB.TabIndex = 21;
            this.limiteInferiorReprocesoTB.TextChanged += new System.EventHandler(this.limiteInferiorReprocesoTB_TextChanged);
            // 
            // limiteInferiorObservadoLB
            // 
            this.limiteInferiorObservadoLB.AutoSize = true;
            this.limiteInferiorObservadoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limiteInferiorObservadoLB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.limiteInferiorObservadoLB.Location = new System.Drawing.Point(67, 252);
            this.limiteInferiorObservadoLB.Name = "limiteInferiorObservadoLB";
            this.limiteInferiorObservadoLB.Size = new System.Drawing.Size(167, 15);
            this.limiteInferiorObservadoLB.TabIndex = 20;
            this.limiteInferiorObservadoLB.Text = "Limite inferior observado";
            // 
            // limiteSuperiorObservadoLB
            // 
            this.limiteSuperiorObservadoLB.AutoSize = true;
            this.limiteSuperiorObservadoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limiteSuperiorObservadoLB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.limiteSuperiorObservadoLB.Location = new System.Drawing.Point(65, 289);
            this.limiteSuperiorObservadoLB.Name = "limiteSuperiorObservadoLB";
            this.limiteSuperiorObservadoLB.Size = new System.Drawing.Size(174, 15);
            this.limiteSuperiorObservadoLB.TabIndex = 19;
            this.limiteSuperiorObservadoLB.Text = "Limite superior observado";
            // 
            // limiteInferiorReprocesoLB
            // 
            this.limiteInferiorReprocesoLB.AutoSize = true;
            this.limiteInferiorReprocesoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limiteInferiorReprocesoLB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.limiteInferiorReprocesoLB.Location = new System.Drawing.Point(67, 172);
            this.limiteInferiorReprocesoLB.Name = "limiteInferiorReprocesoLB";
            this.limiteInferiorReprocesoLB.Size = new System.Drawing.Size(165, 15);
            this.limiteInferiorReprocesoLB.TabIndex = 18;
            this.limiteInferiorReprocesoLB.Text = "Limite inferior reproceso";
            // 
            // limiteSuperiorReprocesoLB
            // 
            this.limiteSuperiorReprocesoLB.AutoSize = true;
            this.limiteSuperiorReprocesoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limiteSuperiorReprocesoLB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.limiteSuperiorReprocesoLB.Location = new System.Drawing.Point(67, 211);
            this.limiteSuperiorReprocesoLB.Name = "limiteSuperiorReprocesoLB";
            this.limiteSuperiorReprocesoLB.Size = new System.Drawing.Size(172, 15);
            this.limiteSuperiorReprocesoLB.TabIndex = 17;
            this.limiteSuperiorReprocesoLB.Text = "Limite superior reproceso";
            // 
            // limitesGeneralesLB
            // 
            this.limitesGeneralesLB.AutoSize = true;
            this.limitesGeneralesLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limitesGeneralesLB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.limitesGeneralesLB.Location = new System.Drawing.Point(67, 116);
            this.limitesGeneralesLB.Name = "limitesGeneralesLB";
            this.limitesGeneralesLB.Size = new System.Drawing.Size(130, 15);
            this.limitesGeneralesLB.TabIndex = 6;
            this.limitesGeneralesLB.Text = "Limites del modelo";
            // 
            // visualizarSkuLB
            // 
            this.visualizarSkuLB.AutoSize = true;
            this.visualizarSkuLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizarSkuLB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.visualizarSkuLB.Location = new System.Drawing.Point(170, 42);
            this.visualizarSkuLB.Name = "visualizarSkuLB";
            this.visualizarSkuLB.Size = new System.Drawing.Size(64, 13);
            this.visualizarSkuLB.TabIndex = 16;
            this.visualizarSkuLB.Text = "SKU (Fijo)";
            // 
            // visualizarDenominacionTB
            // 
            this.visualizarDenominacionTB.Location = new System.Drawing.Point(173, 66);
            this.visualizarDenominacionTB.Name = "visualizarDenominacionTB";
            this.visualizarDenominacionTB.Size = new System.Drawing.Size(249, 20);
            this.visualizarDenominacionTB.TabIndex = 13;
            // 
            // denominacionLB
            // 
            this.denominacionLB.AutoSize = true;
            this.denominacionLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denominacionLB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.denominacionLB.Location = new System.Drawing.Point(67, 66);
            this.denominacionLB.Name = "denominacionLB";
            this.denominacionLB.Size = new System.Drawing.Size(100, 15);
            this.denominacionLB.TabIndex = 7;
            this.denominacionLB.Text = "Denominacion";
            // 
            // skuLB
            // 
            this.skuLB.AutoSize = true;
            this.skuLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skuLB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.skuLB.Location = new System.Drawing.Point(67, 40);
            this.skuLB.Name = "skuLB";
            this.skuLB.Size = new System.Drawing.Size(35, 15);
            this.skuLB.TabIndex = 6;
            this.skuLB.Text = "SKU";
            // 
            // confirmarAccionPN
            // 
            this.confirmarAccionPN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmarAccionPN.Controls.Add(this.guardarModificacionesBTN);
            this.confirmarAccionPN.Location = new System.Drawing.Point(305, 383);
            this.confirmarAccionPN.Name = "confirmarAccionPN";
            this.confirmarAccionPN.Size = new System.Drawing.Size(498, 119);
            this.confirmarAccionPN.TabIndex = 6;
            // 
            // guardarModificacionesBTN
            // 
            this.guardarModificacionesBTN.BackColor = System.Drawing.Color.DarkGreen;
            this.guardarModificacionesBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guardarModificacionesBTN.FlatAppearance.BorderSize = 0;
            this.guardarModificacionesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarModificacionesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarModificacionesBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.guardarModificacionesBTN.Location = new System.Drawing.Point(328, 53);
            this.guardarModificacionesBTN.Name = "guardarModificacionesBTN";
            this.guardarModificacionesBTN.Size = new System.Drawing.Size(94, 40);
            this.guardarModificacionesBTN.TabIndex = 0;
            this.guardarModificacionesBTN.Text = "Guardar";
            this.guardarModificacionesBTN.UseVisualStyleBackColor = false;
            this.guardarModificacionesBTN.UseWaitCursor = true;
            this.guardarModificacionesBTN.Click += new System.EventHandler(this.guardarModificacionesBTN_Click);
            // 
            // eleccionBuscarModeloGB
            // 
            this.eleccionBuscarModeloGB.Controls.Add(this.buscarPorSKURB);
            this.eleccionBuscarModeloGB.Controls.Add(this.buscarPorDescripcionRB);
            this.eleccionBuscarModeloGB.ForeColor = System.Drawing.SystemColors.Control;
            this.eleccionBuscarModeloGB.Location = new System.Drawing.Point(23, 61);
            this.eleccionBuscarModeloGB.Name = "eleccionBuscarModeloGB";
            this.eleccionBuscarModeloGB.Size = new System.Drawing.Size(253, 51);
            this.eleccionBuscarModeloGB.TabIndex = 9;
            this.eleccionBuscarModeloGB.TabStop = false;
            this.eleccionBuscarModeloGB.Text = "Método de Búsqueda";
            // 
            // buscarPorSKURB
            // 
            this.buscarPorSKURB.AutoSize = true;
            this.buscarPorSKURB.Location = new System.Drawing.Point(152, 23);
            this.buscarPorSKURB.Name = "buscarPorSKURB";
            this.buscarPorSKURB.Size = new System.Drawing.Size(47, 17);
            this.buscarPorSKURB.TabIndex = 11;
            this.buscarPorSKURB.Text = "SKU";
            this.buscarPorSKURB.UseVisualStyleBackColor = true;
            this.buscarPorSKURB.CheckedChanged += new System.EventHandler(this.buscarPorSKURB_CheckedChanged);
            // 
            // buscarPorDescripcionRB
            // 
            this.buscarPorDescripcionRB.AutoSize = true;
            this.buscarPorDescripcionRB.Checked = true;
            this.buscarPorDescripcionRB.Location = new System.Drawing.Point(28, 23);
            this.buscarPorDescripcionRB.Name = "buscarPorDescripcionRB";
            this.buscarPorDescripcionRB.Size = new System.Drawing.Size(81, 17);
            this.buscarPorDescripcionRB.TabIndex = 10;
            this.buscarPorDescripcionRB.TabStop = true;
            this.buscarPorDescripcionRB.Text = "Descripción";
            this.buscarPorDescripcionRB.UseVisualStyleBackColor = true;
            this.buscarPorDescripcionRB.CheckedChanged += new System.EventHandler(this.buscarPorDescripcionRB_CheckedChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // sku
            // 
            this.sku.HeaderText = "SKU";
            this.sku.Name = "sku";
            this.sku.ReadOnly = true;
            // 
            // limiteInferiorReproceso
            // 
            this.limiteInferiorReproceso.HeaderText = "Límite inferior reproceso";
            this.limiteInferiorReproceso.Name = "limiteInferiorReproceso";
            this.limiteInferiorReproceso.ReadOnly = true;
            this.limiteInferiorReproceso.Visible = false;
            // 
            // limiteInferiorObservado
            // 
            this.limiteInferiorObservado.HeaderText = "Limite inferior observado";
            this.limiteInferiorObservado.Name = "limiteInferiorObservado";
            this.limiteInferiorObservado.ReadOnly = true;
            this.limiteInferiorObservado.Visible = false;
            // 
            // limiteSuperiorReproceso
            // 
            this.limiteSuperiorReproceso.HeaderText = "Limite superior reproceso";
            this.limiteSuperiorReproceso.Name = "limiteSuperiorReproceso";
            this.limiteSuperiorReproceso.ReadOnly = true;
            this.limiteSuperiorReproceso.Visible = false;
            // 
            // limiteSuperiorObservado
            // 
            this.limiteSuperiorObservado.HeaderText = "Limite superior observado";
            this.limiteSuperiorObservado.Name = "limiteSuperiorObservado";
            this.limiteSuperiorObservado.ReadOnly = true;
            this.limiteSuperiorObservado.Visible = false;
            // 
            // VistaModificarModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(806, 505);
            this.Controls.Add(this.subGestionarModelosTLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaModificarModelo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VistaModificarModelo_Load);
            this.subGestionarModelosTLP.ResumeLayout(false);
            this.listadoModelosPN.ResumeLayout(false);
            this.listadoModelosPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoModelosDG)).EndInit();
            this.buscarModelosPN.ResumeLayout(false);
            this.buscarModelosPN.PerformLayout();
            this.informacionModelosPN.ResumeLayout(false);
            this.informacionModelosPN.PerformLayout();
            this.confirmarAccionPN.ResumeLayout(false);
            this.eleccionBuscarModeloGB.ResumeLayout(false);
            this.eleccionBuscarModeloGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label listadoModelosLB;
        private System.Windows.Forms.TableLayoutPanel subGestionarModelosTLP;
        private System.Windows.Forms.Panel listadoModelosPN;
        private System.Windows.Forms.DataGridView listadoModelosDG;
        private System.Windows.Forms.Panel buscarModelosPN;
        private System.Windows.Forms.TextBox buscarModelosTB;
        private System.Windows.Forms.Label buscarModelosLB;
        private System.Windows.Forms.Panel informacionModelosPN;
        private System.Windows.Forms.Label denominacionLB;
        private System.Windows.Forms.Label skuLB;
        private System.Windows.Forms.TextBox visualizarDenominacionTB;
        private System.Windows.Forms.Panel confirmarAccionPN;
        private System.Windows.Forms.Button guardarModificacionesBTN;
        private System.Windows.Forms.Label visualizarSkuLB;
        private System.Windows.Forms.Label limitesGeneralesLB;
        private System.Windows.Forms.TextBox limiteSuperiorObservadoTB;
        private System.Windows.Forms.TextBox limiteInferiorObservadoTB;
        private System.Windows.Forms.TextBox limiteSuperiorReprocesoTB;
        private System.Windows.Forms.TextBox limiteInferiorReprocesoTB;
        private System.Windows.Forms.Label limiteInferiorObservadoLB;
        private System.Windows.Forms.Label limiteSuperiorObservadoLB;
        private System.Windows.Forms.Label limiteInferiorReprocesoLB;
        private System.Windows.Forms.Label limiteSuperiorReprocesoLB;
        private System.Windows.Forms.GroupBox eleccionBuscarModeloGB;
        private System.Windows.Forms.RadioButton buscarPorSKURB;
        private System.Windows.Forms.RadioButton buscarPorDescripcionRB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sku;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteInferiorReproceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteInferiorObservado;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteSuperiorReproceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteSuperiorObservado;
    }
}