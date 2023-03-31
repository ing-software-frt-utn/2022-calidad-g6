
namespace Presentacion.Vistas
{
    partial class VistaEliminarModelo
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
            this.subGestionarModelosTLP = new System.Windows.Forms.TableLayoutPanel();
            this.buscarModelosPN = new System.Windows.Forms.Panel();
            this.eliminarModeloBTN = new System.Windows.Forms.Button();
            this.eleccionBuscarModeloGB = new System.Windows.Forms.GroupBox();
            this.buscarModelosTB = new System.Windows.Forms.TextBox();
            this.buscarModelosLB = new System.Windows.Forms.Label();
            this.listadoModelosPN = new System.Windows.Forms.Panel();
            this.listadoModelosLB = new System.Windows.Forms.Label();
            this.listadoModelosDG = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteInferiorReproceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteInferiorObservado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteSuperiorReproceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteSuperiorObservado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarPorDescripcionRB = new System.Windows.Forms.RadioButton();
            this.buscarPorSKURB = new System.Windows.Forms.RadioButton();
            this.subGestionarModelosTLP.SuspendLayout();
            this.buscarModelosPN.SuspendLayout();
            this.eleccionBuscarModeloGB.SuspendLayout();
            this.listadoModelosPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoModelosDG)).BeginInit();
            this.SuspendLayout();
            // 
            // subGestionarModelosTLP
            // 
            this.subGestionarModelosTLP.ColumnCount = 1;
            this.subGestionarModelosTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.subGestionarModelosTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.subGestionarModelosTLP.Controls.Add(this.buscarModelosPN, 0, 1);
            this.subGestionarModelosTLP.Controls.Add(this.listadoModelosPN, 0, 0);
            this.subGestionarModelosTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subGestionarModelosTLP.Location = new System.Drawing.Point(0, 0);
            this.subGestionarModelosTLP.Name = "subGestionarModelosTLP";
            this.subGestionarModelosTLP.RowCount = 2;
            this.subGestionarModelosTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.66666F));
            this.subGestionarModelosTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.33333F));
            this.subGestionarModelosTLP.Size = new System.Drawing.Size(806, 505);
            this.subGestionarModelosTLP.TabIndex = 3;
            // 
            // buscarModelosPN
            // 
            this.buscarModelosPN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarModelosPN.Controls.Add(this.eliminarModeloBTN);
            this.buscarModelosPN.Controls.Add(this.eleccionBuscarModeloGB);
            this.buscarModelosPN.Controls.Add(this.buscarModelosTB);
            this.buscarModelosPN.Controls.Add(this.buscarModelosLB);
            this.buscarModelosPN.Location = new System.Drawing.Point(3, 380);
            this.buscarModelosPN.Name = "buscarModelosPN";
            this.buscarModelosPN.Size = new System.Drawing.Size(800, 122);
            this.buscarModelosPN.TabIndex = 7;
            // 
            // eliminarModeloBTN
            // 
            this.eliminarModeloBTN.BackColor = System.Drawing.Color.DarkRed;
            this.eliminarModeloBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.eliminarModeloBTN.FlatAppearance.BorderSize = 0;
            this.eliminarModeloBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarModeloBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarModeloBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.eliminarModeloBTN.Location = new System.Drawing.Point(608, 53);
            this.eliminarModeloBTN.Name = "eliminarModeloBTN";
            this.eliminarModeloBTN.Size = new System.Drawing.Size(136, 40);
            this.eliminarModeloBTN.TabIndex = 9;
            this.eliminarModeloBTN.Text = "Eliminar";
            this.eliminarModeloBTN.UseVisualStyleBackColor = false;
            this.eliminarModeloBTN.UseWaitCursor = true;
            this.eliminarModeloBTN.Click += new System.EventHandler(this.eliminarModeloBTN_Click);
            // 
            // eleccionBuscarModeloGB
            // 
            this.eleccionBuscarModeloGB.Controls.Add(this.buscarPorSKURB);
            this.eleccionBuscarModeloGB.Controls.Add(this.buscarPorDescripcionRB);
            this.eleccionBuscarModeloGB.ForeColor = System.Drawing.SystemColors.Control;
            this.eleccionBuscarModeloGB.Location = new System.Drawing.Point(23, 53);
            this.eleccionBuscarModeloGB.Name = "eleccionBuscarModeloGB";
            this.eleccionBuscarModeloGB.Size = new System.Drawing.Size(253, 51);
            this.eleccionBuscarModeloGB.TabIndex = 8;
            this.eleccionBuscarModeloGB.TabStop = false;
            this.eleccionBuscarModeloGB.Text = "Método de Búsqueda";
            // 
            // buscarModelosTB
            // 
            this.buscarModelosTB.Location = new System.Drawing.Point(23, 18);
            this.buscarModelosTB.Name = "buscarModelosTB";
            this.buscarModelosTB.Size = new System.Drawing.Size(362, 20);
            this.buscarModelosTB.TabIndex = 7;
            this.buscarModelosTB.TextChanged += new System.EventHandler(this.buscarModelosTB_TextChanged);
            // 
            // buscarModelosLB
            // 
            this.buscarModelosLB.AutoSize = true;
            this.buscarModelosLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarModelosLB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buscarModelosLB.Location = new System.Drawing.Point(20, 0);
            this.buscarModelosLB.Name = "buscarModelosLB";
            this.buscarModelosLB.Size = new System.Drawing.Size(103, 15);
            this.buscarModelosLB.TabIndex = 6;
            this.buscarModelosLB.Text = "Buscar modelo";
            // 
            // listadoModelosPN
            // 
            this.listadoModelosPN.Controls.Add(this.listadoModelosDG);
            this.listadoModelosPN.Controls.Add(this.listadoModelosLB);
            this.listadoModelosPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listadoModelosPN.Location = new System.Drawing.Point(3, 3);
            this.listadoModelosPN.Name = "listadoModelosPN";
            this.listadoModelosPN.Size = new System.Drawing.Size(800, 371);
            this.listadoModelosPN.TabIndex = 4;
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
            this.listadoModelosDG.Location = new System.Drawing.Point(23, 47);
            this.listadoModelosDG.MultiSelect = false;
            this.listadoModelosDG.Name = "listadoModelosDG";
            this.listadoModelosDG.ReadOnly = true;
            this.listadoModelosDG.RowHeadersVisible = false;
            this.listadoModelosDG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.listadoModelosDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoModelosDG.Size = new System.Drawing.Size(748, 307);
            this.listadoModelosDG.TabIndex = 6;
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
            // 
            // limiteInferiorObservado
            // 
            this.limiteInferiorObservado.HeaderText = "Limite inferior observado";
            this.limiteInferiorObservado.Name = "limiteInferiorObservado";
            this.limiteInferiorObservado.ReadOnly = true;
            // 
            // limiteSuperiorReproceso
            // 
            this.limiteSuperiorReproceso.HeaderText = "Limite superior reproceso";
            this.limiteSuperiorReproceso.Name = "limiteSuperiorReproceso";
            this.limiteSuperiorReproceso.ReadOnly = true;
            // 
            // limiteSuperiorObservado
            // 
            this.limiteSuperiorObservado.HeaderText = "Limite superior observado";
            this.limiteSuperiorObservado.Name = "limiteSuperiorObservado";
            this.limiteSuperiorObservado.ReadOnly = true;
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
            // buscarPorSKURB
            // 
            this.buscarPorSKURB.AutoSize = true;
            this.buscarPorSKURB.Location = new System.Drawing.Point(152, 23);
            this.buscarPorSKURB.Name = "buscarPorSKURB";
            this.buscarPorSKURB.Size = new System.Drawing.Size(47, 17);
            this.buscarPorSKURB.TabIndex = 11;
            this.buscarPorSKURB.TabStop = true;
            this.buscarPorSKURB.Text = "SKU";
            this.buscarPorSKURB.UseVisualStyleBackColor = true;
            this.buscarPorSKURB.CheckedChanged += new System.EventHandler(this.buscarPorSKURB_CheckedChanged);
            // 
            // VistaEliminarModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(806, 505);
            this.Controls.Add(this.subGestionarModelosTLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaEliminarModelo";
            this.Text = "VistaEliminarModelo";
            this.subGestionarModelosTLP.ResumeLayout(false);
            this.buscarModelosPN.ResumeLayout(false);
            this.buscarModelosPN.PerformLayout();
            this.eleccionBuscarModeloGB.ResumeLayout(false);
            this.eleccionBuscarModeloGB.PerformLayout();
            this.listadoModelosPN.ResumeLayout(false);
            this.listadoModelosPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoModelosDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel subGestionarModelosTLP;
        private System.Windows.Forms.Panel listadoModelosPN;
        private System.Windows.Forms.Label listadoModelosLB;
        private System.Windows.Forms.Panel buscarModelosPN;
        private System.Windows.Forms.GroupBox eleccionBuscarModeloGB;
        private System.Windows.Forms.TextBox buscarModelosTB;
        private System.Windows.Forms.Label buscarModelosLB;
        private System.Windows.Forms.Button eliminarModeloBTN;
        private System.Windows.Forms.DataGridView listadoModelosDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sku;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteInferiorReproceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteInferiorObservado;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteSuperiorReproceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteSuperiorObservado;
        private System.Windows.Forms.RadioButton buscarPorSKURB;
        private System.Windows.Forms.RadioButton buscarPorDescripcionRB;
    }
}