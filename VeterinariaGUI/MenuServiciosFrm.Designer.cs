namespace VeterinariaGUI
{
    partial class MenuServiciosFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuServiciosFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CerrarBtn = new System.Windows.Forms.PictureBox();
            this.MinimizarBtn = new System.Windows.Forms.PictureBox();
            this.VeterinarioCmb = new System.Windows.Forms.Panel();
            this.AgregarServicioBtn = new System.Windows.Forms.Button();
            this.BuscarServiciosBtn = new System.Windows.Forms.Button();
            this.Servicioscmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serviciosDtg = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).BeginInit();
            this.VeterinarioCmb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CerrarBtn);
            this.panel1.Controls.Add(this.MinimizarBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menu Mascotas";
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBtn.Image")));
            this.CerrarBtn.Location = new System.Drawing.Point(763, 10);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(25, 25);
            this.CerrarBtn.TabIndex = 7;
            this.CerrarBtn.TabStop = false;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // MinimizarBtn
            // 
            this.MinimizarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinimizarBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarBtn.Image")));
            this.MinimizarBtn.Location = new System.Drawing.Point(732, 10);
            this.MinimizarBtn.Name = "MinimizarBtn";
            this.MinimizarBtn.Size = new System.Drawing.Size(25, 25);
            this.MinimizarBtn.TabIndex = 6;
            this.MinimizarBtn.TabStop = false;
            this.MinimizarBtn.Click += new System.EventHandler(this.MinimizarBtn_Click);
            // 
            // VeterinarioCmb
            // 
            this.VeterinarioCmb.BackColor = System.Drawing.Color.DarkOrange;
            this.VeterinarioCmb.Controls.Add(this.AgregarServicioBtn);
            this.VeterinarioCmb.Controls.Add(this.BuscarServiciosBtn);
            this.VeterinarioCmb.Controls.Add(this.Servicioscmb);
            this.VeterinarioCmb.Controls.Add(this.label2);
            this.VeterinarioCmb.Location = new System.Drawing.Point(0, 38);
            this.VeterinarioCmb.Name = "VeterinarioCmb";
            this.VeterinarioCmb.Size = new System.Drawing.Size(959, 181);
            this.VeterinarioCmb.TabIndex = 5;
            // 
            // AgregarServicioBtn
            // 
            this.AgregarServicioBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.AgregarServicioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarServicioBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarServicioBtn.Image = ((System.Drawing.Image)(resources.GetObject("AgregarServicioBtn.Image")));
            this.AgregarServicioBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarServicioBtn.Location = new System.Drawing.Point(137, 89);
            this.AgregarServicioBtn.Name = "AgregarServicioBtn";
            this.AgregarServicioBtn.Size = new System.Drawing.Size(89, 70);
            this.AgregarServicioBtn.TabIndex = 16;
            this.AgregarServicioBtn.Text = "Agregar Servicio";
            this.AgregarServicioBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarServicioBtn.UseVisualStyleBackColor = false;
            this.AgregarServicioBtn.Click += new System.EventHandler(this.AgregarServicioBtn_Click);
            // 
            // BuscarServiciosBtn
            // 
            this.BuscarServiciosBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.BuscarServiciosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuscarServiciosBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuscarServiciosBtn.Image")));
            this.BuscarServiciosBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarServiciosBtn.Location = new System.Drawing.Point(557, 102);
            this.BuscarServiciosBtn.Name = "BuscarServiciosBtn";
            this.BuscarServiciosBtn.Size = new System.Drawing.Size(75, 57);
            this.BuscarServiciosBtn.TabIndex = 2;
            this.BuscarServiciosBtn.Text = "Consultar";
            this.BuscarServiciosBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarServiciosBtn.UseVisualStyleBackColor = false;
            this.BuscarServiciosBtn.Click += new System.EventHandler(this.BuscarServiciosBtn_Click);
            // 
            // Servicioscmb
            // 
            this.Servicioscmb.FormattingEnabled = true;
            this.Servicioscmb.Items.AddRange(new object[] {
            "Servicios"});
            this.Servicioscmb.Location = new System.Drawing.Point(378, 125);
            this.Servicioscmb.Name = "Servicioscmb";
            this.Servicioscmb.Size = new System.Drawing.Size(121, 21);
            this.Servicioscmb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Servicios Activos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // serviciosDtg
            // 
            this.serviciosDtg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.serviciosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviciosDtg.Location = new System.Drawing.Point(0, 216);
            this.serviciosDtg.Name = "serviciosDtg";
            this.serviciosDtg.Size = new System.Drawing.Size(798, 321);
            this.serviciosDtg.TabIndex = 15;
            // 
            // MenuServiciosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.serviciosDtg);
            this.Controls.Add(this.VeterinarioCmb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuServiciosFrm";
            this.Text = "MenuServiciosFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).EndInit();
            this.VeterinarioCmb.ResumeLayout(false);
            this.VeterinarioCmb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosDtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CerrarBtn;
        private System.Windows.Forms.PictureBox MinimizarBtn;
        private System.Windows.Forms.Panel VeterinarioCmb;
        private System.Windows.Forms.Button BuscarServiciosBtn;
        private System.Windows.Forms.ComboBox Servicioscmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AgregarServicioBtn;
        private System.Windows.Forms.DataGridView serviciosDtg;
    }
}