
namespace Presentacion.Vistas
{
    partial class VistaContenedor
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
            this.logoIMG = new System.Windows.Forms.PictureBox();
            this.tituloLB = new System.Windows.Forms.Label();
            this.maximizarBTN = new System.Windows.Forms.Button();
            this.cerrarBTN = new System.Windows.Forms.Button();
            this.normalBTN = new System.Windows.Forms.Button();
            this.minimizarBTN = new System.Windows.Forms.Button();
            this.ventanaPN = new System.Windows.Forms.Panel();
            this.vistaActivaPN = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logoIMG)).BeginInit();
            this.ventanaPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoIMG
            // 
            this.logoIMG.Enabled = false;
            this.logoIMG.Location = new System.Drawing.Point(5, 2);
            this.logoIMG.Name = "logoIMG";
            this.logoIMG.Size = new System.Drawing.Size(48, 48);
            this.logoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoIMG.TabIndex = 0;
            this.logoIMG.TabStop = false;
            // 
            // tituloLB
            // 
            this.tituloLB.AutoSize = true;
            this.tituloLB.Font = new System.Drawing.Font("Segoe Print", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLB.ForeColor = System.Drawing.Color.MintCream;
            this.tituloLB.Location = new System.Drawing.Point(59, 2);
            this.tituloLB.Name = "tituloLB";
            this.tituloLB.Size = new System.Drawing.Size(189, 44);
            this.tituloLB.TabIndex = 1;
            this.tituloLB.Text = "Work System";
            this.tituloLB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tituloLB_MouseDown);
            this.tituloLB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tituloLB_MouseMove);
            this.tituloLB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tituloLB_MouseUp);
            // 
            // maximizarBTN
            // 
            this.maximizarBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maximizarBTN.BackgroundImage = global::Presentacion.Properties.Resources.MaximizeButton_v2;
            this.maximizarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maximizarBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.maximizarBTN.FlatAppearance.BorderSize = 0;
            this.maximizarBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(49)))));
            this.maximizarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizarBTN.Location = new System.Drawing.Point(1162, 4);
            this.maximizarBTN.Margin = new System.Windows.Forms.Padding(0);
            this.maximizarBTN.Name = "maximizarBTN";
            this.maximizarBTN.Size = new System.Drawing.Size(40, 40);
            this.maximizarBTN.TabIndex = 2;
            this.maximizarBTN.UseVisualStyleBackColor = true;
            this.maximizarBTN.Click += new System.EventHandler(this.maximizarBTN_Click);
            // 
            // cerrarBTN
            // 
            this.cerrarBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cerrarBTN.BackgroundImage = global::Presentacion.Properties.Resources.Exit_v2;
            this.cerrarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cerrarBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cerrarBTN.FlatAppearance.BorderSize = 0;
            this.cerrarBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(49)))));
            this.cerrarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarBTN.Location = new System.Drawing.Point(1212, 4);
            this.cerrarBTN.Margin = new System.Windows.Forms.Padding(0);
            this.cerrarBTN.MaximumSize = new System.Drawing.Size(40, 40);
            this.cerrarBTN.MinimumSize = new System.Drawing.Size(40, 40);
            this.cerrarBTN.Name = "cerrarBTN";
            this.cerrarBTN.Size = new System.Drawing.Size(40, 40);
            this.cerrarBTN.TabIndex = 3;
            this.cerrarBTN.UseVisualStyleBackColor = true;
            this.cerrarBTN.Click += new System.EventHandler(this.cerrarBTN_Click);
            // 
            // normalBTN
            // 
            this.normalBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.normalBTN.BackgroundImage = global::Presentacion.Properties.Resources.Normal;
            this.normalBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.normalBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.normalBTN.FlatAppearance.BorderSize = 0;
            this.normalBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(49)))));
            this.normalBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalBTN.Location = new System.Drawing.Point(1162, 4);
            this.normalBTN.Margin = new System.Windows.Forms.Padding(0);
            this.normalBTN.Name = "normalBTN";
            this.normalBTN.Size = new System.Drawing.Size(40, 40);
            this.normalBTN.TabIndex = 4;
            this.normalBTN.UseVisualStyleBackColor = true;
            this.normalBTN.Click += new System.EventHandler(this.normalBTN_Click);
            // 
            // minimizarBTN
            // 
            this.minimizarBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimizarBTN.BackgroundImage = global::Presentacion.Properties.Resources.Minimizar;
            this.minimizarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizarBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.minimizarBTN.FlatAppearance.BorderSize = 0;
            this.minimizarBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(144)))), ((int)(((byte)(49)))));
            this.minimizarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizarBTN.Location = new System.Drawing.Point(1112, 4);
            this.minimizarBTN.Margin = new System.Windows.Forms.Padding(0);
            this.minimizarBTN.Name = "minimizarBTN";
            this.minimizarBTN.Size = new System.Drawing.Size(40, 40);
            this.minimizarBTN.TabIndex = 5;
            this.minimizarBTN.UseVisualStyleBackColor = true;
            this.minimizarBTN.Click += new System.EventHandler(this.minimizarBTN_Click);
            // 
            // ventanaPN
            // 
            this.ventanaPN.Controls.Add(this.minimizarBTN);
            this.ventanaPN.Controls.Add(this.normalBTN);
            this.ventanaPN.Controls.Add(this.cerrarBTN);
            this.ventanaPN.Controls.Add(this.maximizarBTN);
            this.ventanaPN.Controls.Add(this.tituloLB);
            this.ventanaPN.Controls.Add(this.logoIMG);
            this.ventanaPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ventanaPN.Location = new System.Drawing.Point(0, 0);
            this.ventanaPN.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ventanaPN.Name = "ventanaPN";
            this.ventanaPN.Size = new System.Drawing.Size(1262, 52);
            this.ventanaPN.TabIndex = 1;
            this.ventanaPN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ventanaPN_MouseDown);
            this.ventanaPN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ventanaPN_MouseMove);
            this.ventanaPN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ventanaPN_MouseUp);
            // 
            // vistaActivaPN
            // 
            this.vistaActivaPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaActivaPN.Location = new System.Drawing.Point(0, 52);
            this.vistaActivaPN.Margin = new System.Windows.Forms.Padding(0);
            this.vistaActivaPN.Name = "vistaActivaPN";
            this.vistaActivaPN.Size = new System.Drawing.Size(1262, 621);
            this.vistaActivaPN.TabIndex = 2;
            // 
            // VistaContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.vistaActivaPN);
            this.Controls.Add(this.ventanaPN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaContenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaContenedor";
            this.Load += new System.EventHandler(this.VistaContenedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoIMG)).EndInit();
            this.ventanaPN.ResumeLayout(false);
            this.ventanaPN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoIMG;
        private System.Windows.Forms.Label tituloLB;
        private System.Windows.Forms.Button maximizarBTN;
        private System.Windows.Forms.Button cerrarBTN;
        private System.Windows.Forms.Button normalBTN;
        private System.Windows.Forms.Button minimizarBTN;
        private System.Windows.Forms.Panel ventanaPN;
        private System.Windows.Forms.Panel vistaActivaPN;
    }
}