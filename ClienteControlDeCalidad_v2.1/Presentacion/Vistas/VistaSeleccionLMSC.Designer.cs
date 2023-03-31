
namespace Presentacion.Vistas
{
    partial class VistaSeleccionLMSC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vistaSeleccionTLP = new System.Windows.Forms.TableLayoutPanel();
            this.tituloPN = new System.Windows.Forms.Panel();
            this.tituloLB = new System.Windows.Forms.Label();
            this.tablaSeleccionPN = new System.Windows.Forms.Panel();
            this.listadoDG = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonesPN = new System.Windows.Forms.Panel();
            this.cancelarBTN = new System.Windows.Forms.Button();
            this.confirmarSeleccionBTN = new System.Windows.Forms.Button();
            this.vistaSeleccionTLP.SuspendLayout();
            this.tituloPN.SuspendLayout();
            this.tablaSeleccionPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDG)).BeginInit();
            this.botonesPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // vistaSeleccionTLP
            // 
            this.vistaSeleccionTLP.ColumnCount = 3;
            this.vistaSeleccionTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.vistaSeleccionTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.vistaSeleccionTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.vistaSeleccionTLP.Controls.Add(this.tituloPN, 1, 0);
            this.vistaSeleccionTLP.Controls.Add(this.tablaSeleccionPN, 1, 1);
            this.vistaSeleccionTLP.Controls.Add(this.botonesPN, 1, 2);
            this.vistaSeleccionTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaSeleccionTLP.Location = new System.Drawing.Point(0, 0);
            this.vistaSeleccionTLP.Name = "vistaSeleccionTLP";
            this.vistaSeleccionTLP.RowCount = 3;
            this.vistaSeleccionTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.vistaSeleccionTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.vistaSeleccionTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.vistaSeleccionTLP.Size = new System.Drawing.Size(946, 505);
            this.vistaSeleccionTLP.TabIndex = 0;
            // 
            // tituloPN
            // 
            this.tituloPN.Controls.Add(this.tituloLB);
            this.tituloPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tituloPN.Location = new System.Drawing.Point(286, 3);
            this.tituloPN.Name = "tituloPN";
            this.tituloPN.Size = new System.Drawing.Size(372, 95);
            this.tituloPN.TabIndex = 0;
            // 
            // tituloLB
            // 
            this.tituloLB.AutoSize = true;
            this.tituloLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tituloLB.Location = new System.Drawing.Point(77, 44);
            this.tituloLB.Name = "tituloLB";
            this.tituloLB.Size = new System.Drawing.Size(214, 24);
            this.tituloLB.TabIndex = 3;
            this.tituloLB.Text = "Seleccion de XXXXX";
            this.tituloLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablaSeleccionPN
            // 
            this.tablaSeleccionPN.Controls.Add(this.listadoDG);
            this.tablaSeleccionPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaSeleccionPN.Location = new System.Drawing.Point(286, 104);
            this.tablaSeleccionPN.Name = "tablaSeleccionPN";
            this.tablaSeleccionPN.Size = new System.Drawing.Size(372, 297);
            this.tablaSeleccionPN.TabIndex = 1;
            // 
            // listadoDG
            // 
            this.listadoDG.AllowUserToAddRows = false;
            this.listadoDG.AllowUserToDeleteRows = false;
            this.listadoDG.AllowUserToResizeColumns = false;
            this.listadoDG.AllowUserToResizeRows = false;
            this.listadoDG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listadoDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.opciones});
            this.listadoDG.Location = new System.Drawing.Point(34, 3);
            this.listadoDG.Name = "listadoDG";
            this.listadoDG.ReadOnly = true;
            this.listadoDG.RowHeadersVisible = false;
            this.listadoDG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.listadoDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoDG.Size = new System.Drawing.Size(290, 282);
            this.listadoDG.TabIndex = 6;
            this.listadoDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoDG_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // opciones
            // 
            this.opciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.opciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.opciones.HeaderText = "Opciones";
            this.opciones.Name = "opciones";
            this.opciones.ReadOnly = true;
            // 
            // botonesPN
            // 
            this.botonesPN.Controls.Add(this.cancelarBTN);
            this.botonesPN.Controls.Add(this.confirmarSeleccionBTN);
            this.botonesPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botonesPN.Location = new System.Drawing.Point(286, 407);
            this.botonesPN.Name = "botonesPN";
            this.botonesPN.Size = new System.Drawing.Size(372, 95);
            this.botonesPN.TabIndex = 2;
            // 
            // cancelarBTN
            // 
            this.cancelarBTN.BackColor = System.Drawing.Color.DarkRed;
            this.cancelarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelarBTN.FlatAppearance.BorderSize = 0;
            this.cancelarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelarBTN.Location = new System.Drawing.Point(34, 22);
            this.cancelarBTN.Name = "cancelarBTN";
            this.cancelarBTN.Size = new System.Drawing.Size(94, 40);
            this.cancelarBTN.TabIndex = 4;
            this.cancelarBTN.Text = "Cancelar";
            this.cancelarBTN.UseVisualStyleBackColor = false;
            this.cancelarBTN.UseWaitCursor = true;
            this.cancelarBTN.Click += new System.EventHandler(this.cancelarBTN_Click);
            // 
            // confirmarSeleccionBTN
            // 
            this.confirmarSeleccionBTN.BackColor = System.Drawing.Color.DarkGreen;
            this.confirmarSeleccionBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.confirmarSeleccionBTN.FlatAppearance.BorderSize = 0;
            this.confirmarSeleccionBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmarSeleccionBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarSeleccionBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.confirmarSeleccionBTN.Location = new System.Drawing.Point(184, 22);
            this.confirmarSeleccionBTN.Name = "confirmarSeleccionBTN";
            this.confirmarSeleccionBTN.Size = new System.Drawing.Size(140, 40);
            this.confirmarSeleccionBTN.TabIndex = 3;
            this.confirmarSeleccionBTN.Text = "Confirmar seleccion";
            this.confirmarSeleccionBTN.UseVisualStyleBackColor = false;
            this.confirmarSeleccionBTN.UseWaitCursor = true;
            this.confirmarSeleccionBTN.Click += new System.EventHandler(this.confirmarSeleccionBTN_Click);
            // 
            // VistaSeleccionLMSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(946, 505);
            this.Controls.Add(this.vistaSeleccionTLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaSeleccionLMSC";
            this.Text = "VistaSeleccionLMSC";
            this.vistaSeleccionTLP.ResumeLayout(false);
            this.tituloPN.ResumeLayout(false);
            this.tituloPN.PerformLayout();
            this.tablaSeleccionPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoDG)).EndInit();
            this.botonesPN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel vistaSeleccionTLP;
        private System.Windows.Forms.Panel tituloPN;
        private System.Windows.Forms.Panel tablaSeleccionPN;
        private System.Windows.Forms.Panel botonesPN;
        private System.Windows.Forms.Label tituloLB;
        private System.Windows.Forms.DataGridView listadoDG;
        private System.Windows.Forms.Button cancelarBTN;
        private System.Windows.Forms.Button confirmarSeleccionBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn opciones;
    }
}