
namespace Presentacion.Vistas
{
    partial class VistaGestionarModelos
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
            this.opcionesPN = new System.Windows.Forms.Panel();
            this.eliminarModeloBTN = new System.Windows.Forms.Button();
            this.modificarModeloBTN = new System.Windows.Forms.Button();
            this.nuevoModeloBTN = new System.Windows.Forms.Button();
            this.modificarPN = new System.Windows.Forms.Panel();
            this.opcionesPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // opcionesPN
            // 
            this.opcionesPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.opcionesPN.Controls.Add(this.eliminarModeloBTN);
            this.opcionesPN.Controls.Add(this.modificarModeloBTN);
            this.opcionesPN.Controls.Add(this.nuevoModeloBTN);
            this.opcionesPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.opcionesPN.Location = new System.Drawing.Point(0, 0);
            this.opcionesPN.Name = "opcionesPN";
            this.opcionesPN.Size = new System.Drawing.Size(140, 505);
            this.opcionesPN.TabIndex = 0;
            // 
            // eliminarModeloBTN
            // 
            this.eliminarModeloBTN.FlatAppearance.BorderSize = 0;
            this.eliminarModeloBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.eliminarModeloBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarModeloBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarModeloBTN.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.eliminarModeloBTN.Location = new System.Drawing.Point(0, 135);
            this.eliminarModeloBTN.Name = "eliminarModeloBTN";
            this.eliminarModeloBTN.Size = new System.Drawing.Size(140, 35);
            this.eliminarModeloBTN.TabIndex = 3;
            this.eliminarModeloBTN.Text = "Eliminar modelo";
            this.eliminarModeloBTN.UseVisualStyleBackColor = true;
            this.eliminarModeloBTN.Click += new System.EventHandler(this.eliminarModeloBTN_Click);
            // 
            // modificarModeloBTN
            // 
            this.modificarModeloBTN.FlatAppearance.BorderSize = 0;
            this.modificarModeloBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.modificarModeloBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.modificarModeloBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarModeloBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarModeloBTN.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.modificarModeloBTN.Location = new System.Drawing.Point(0, 94);
            this.modificarModeloBTN.Name = "modificarModeloBTN";
            this.modificarModeloBTN.Size = new System.Drawing.Size(140, 35);
            this.modificarModeloBTN.TabIndex = 1;
            this.modificarModeloBTN.Text = "Modificar modelo";
            this.modificarModeloBTN.UseVisualStyleBackColor = true;
            this.modificarModeloBTN.Click += new System.EventHandler(this.modificarModeloBTN_Click);
            // 
            // nuevoModeloBTN
            // 
            this.nuevoModeloBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.nuevoModeloBTN.FlatAppearance.BorderSize = 0;
            this.nuevoModeloBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.nuevoModeloBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.nuevoModeloBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoModeloBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoModeloBTN.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.nuevoModeloBTN.Location = new System.Drawing.Point(0, 53);
            this.nuevoModeloBTN.Name = "nuevoModeloBTN";
            this.nuevoModeloBTN.Size = new System.Drawing.Size(140, 35);
            this.nuevoModeloBTN.TabIndex = 0;
            this.nuevoModeloBTN.Text = "Nuevo modelo";
            this.nuevoModeloBTN.UseVisualStyleBackColor = false;
            this.nuevoModeloBTN.Click += new System.EventHandler(this.nuevoModeloBTN_Click);
            // 
            // modificarPN
            // 
            this.modificarPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modificarPN.Location = new System.Drawing.Point(140, 0);
            this.modificarPN.Name = "modificarPN";
            this.modificarPN.Size = new System.Drawing.Size(806, 505);
            this.modificarPN.TabIndex = 1;
            // 
            // VistaGestionarModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(946, 505);
            this.Controls.Add(this.modificarPN);
            this.Controls.Add(this.opcionesPN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaGestionarModelos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VistaGestionarModelos_Load);
            this.opcionesPN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel opcionesPN;
        private System.Windows.Forms.Panel modificarPN;
        private System.Windows.Forms.Button eliminarModeloBTN;
        private System.Windows.Forms.Button modificarModeloBTN;
        private System.Windows.Forms.Button nuevoModeloBTN;
    }
}