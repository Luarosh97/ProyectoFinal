namespace VeterinariaGUI
{
    partial class MenuMascotasFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMascotasFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CerrarBtn = new System.Windows.Forms.PictureBox();
            this.MinimizarBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BuscarMascotaBtn = new System.Windows.Forms.Button();
            this.Mascotacmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MascotaDtg = new System.Windows.Forms.DataGridView();
            this.AgregarMascotaBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MascotaDtg)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(804, 35);
            this.panel1.TabIndex = 1;
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
            this.CerrarBtn.Location = new System.Drawing.Point(769, 6);
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
            this.MinimizarBtn.Location = new System.Drawing.Point(738, 6);
            this.MinimizarBtn.Name = "MinimizarBtn";
            this.MinimizarBtn.Size = new System.Drawing.Size(25, 25);
            this.MinimizarBtn.TabIndex = 6;
            this.MinimizarBtn.TabStop = false;
            this.MinimizarBtn.Click += new System.EventHandler(this.MinimizarBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.BuscarMascotaBtn);
            this.panel2.Controls.Add(this.Mascotacmb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 201);
            this.panel2.TabIndex = 3;
            // 
            // BuscarMascotaBtn
            // 
            this.BuscarMascotaBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.BuscarMascotaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuscarMascotaBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuscarMascotaBtn.Image")));
            this.BuscarMascotaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarMascotaBtn.Location = new System.Drawing.Point(577, 100);
            this.BuscarMascotaBtn.Name = "BuscarMascotaBtn";
            this.BuscarMascotaBtn.Size = new System.Drawing.Size(75, 57);
            this.BuscarMascotaBtn.TabIndex = 2;
            this.BuscarMascotaBtn.Text = "Consultar";
            this.BuscarMascotaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarMascotaBtn.UseVisualStyleBackColor = false;
            this.BuscarMascotaBtn.Click += new System.EventHandler(this.BuscarMascotaBtn_Click);
            // 
            // Mascotacmb
            // 
            this.Mascotacmb.FormattingEnabled = true;
            this.Mascotacmb.Items.AddRange(new object[] {
            "Mascotas"});
            this.Mascotacmb.Location = new System.Drawing.Point(427, 120);
            this.Mascotacmb.Name = "Mascotacmb";
            this.Mascotacmb.Size = new System.Drawing.Size(121, 21);
            this.Mascotacmb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mascotas Activos";
            // 
            // MascotaDtg
            // 
            this.MascotaDtg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MascotaDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MascotaDtg.Location = new System.Drawing.Point(0, 228);
            this.MascotaDtg.Name = "MascotaDtg";
            this.MascotaDtg.Size = new System.Drawing.Size(831, 312);
            this.MascotaDtg.TabIndex = 8;
            // 
            // AgregarMascotaBtn
            // 
            this.AgregarMascotaBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.AgregarMascotaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarMascotaBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarMascotaBtn.Image = ((System.Drawing.Image)(resources.GetObject("AgregarMascotaBtn.Image")));
            this.AgregarMascotaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarMascotaBtn.Location = new System.Drawing.Point(0, 157);
            this.AgregarMascotaBtn.Name = "AgregarMascotaBtn";
            this.AgregarMascotaBtn.Size = new System.Drawing.Size(75, 70);
            this.AgregarMascotaBtn.TabIndex = 16;
            this.AgregarMascotaBtn.Text = "Agregar Mascota";
            this.AgregarMascotaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarMascotaBtn.UseVisualStyleBackColor = false;
            this.AgregarMascotaBtn.Click += new System.EventHandler(this.AgregarMascotaBtn_Click);
            // 
            // MenuMascotasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(804, 540);
            this.Controls.Add(this.AgregarMascotaBtn);
            this.Controls.Add(this.MascotaDtg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuMascotasFrm";
            this.Text = "MenuMascotasFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MascotaDtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CerrarBtn;
        private System.Windows.Forms.PictureBox MinimizarBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BuscarMascotaBtn;
        private System.Windows.Forms.ComboBox Mascotacmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView MascotaDtg;
        private System.Windows.Forms.Button AgregarMascotaBtn;
    }
}