namespace VeterinariaGUI
{
    partial class RegistroMascotaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroMascotaFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CerrarBtn = new System.Windows.Forms.PictureBox();
            this.MinimizarBtn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.colortxt = new System.Windows.Forms.TextBox();
            this.GuardarMascotaBtn = new System.Windows.Forms.Button();
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.CANCELARBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datemascota = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.TipoMascotacmb = new System.Windows.Forms.ComboBox();
            this.BuscarMascotaBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ModificarMascotaBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.IdClientetxt = new System.Windows.Forms.TextBox();
            this.raxatxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CerrarBtn);
            this.panel1.Controls.Add(this.MinimizarBtn);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 35);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "Registro de Mascotas";
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBtn.Image")));
            this.CerrarBtn.Location = new System.Drawing.Point(470, 7);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(25, 25);
            this.CerrarBtn.TabIndex = 5;
            this.CerrarBtn.TabStop = false;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // MinimizarBtn
            // 
            this.MinimizarBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinimizarBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarBtn.Image")));
            this.MinimizarBtn.Location = new System.Drawing.Point(503, 7);
            this.MinimizarBtn.Name = "MinimizarBtn";
            this.MinimizarBtn.Size = new System.Drawing.Size(25, 25);
            this.MinimizarBtn.TabIndex = 4;
            this.MinimizarBtn.TabStop = false;
            this.MinimizarBtn.Click += new System.EventHandler(this.MinimizarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Mascota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Raza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(261, 184);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(100, 20);
            this.nombretxt.TabIndex = 9;
            // 
            // colortxt
            // 
            this.colortxt.Location = new System.Drawing.Point(261, 308);
            this.colortxt.Name = "colortxt";
            this.colortxt.Size = new System.Drawing.Size(100, 20);
            this.colortxt.TabIndex = 13;
            // 
            // GuardarMascotaBtn
            // 
            this.GuardarMascotaBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.GuardarMascotaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GuardarMascotaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GuardarMascotaBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarMascotaBtn.Image = ((System.Drawing.Image)(resources.GetObject("GuardarMascotaBtn.Image")));
            this.GuardarMascotaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarMascotaBtn.Location = new System.Drawing.Point(35, 403);
            this.GuardarMascotaBtn.Name = "GuardarMascotaBtn";
            this.GuardarMascotaBtn.Size = new System.Drawing.Size(69, 54);
            this.GuardarMascotaBtn.TabIndex = 18;
            this.GuardarMascotaBtn.Text = "Guardar";
            this.GuardarMascotaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarMascotaBtn.UseVisualStyleBackColor = false;
            this.GuardarMascotaBtn.Click += new System.EventHandler(this.GuardarMascotaBtn_Click);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.BackColor = System.Drawing.Color.DarkOrange;
            this.LIMPIAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LIMPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LIMPIAR.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIMPIAR.Image = ((System.Drawing.Image)(resources.GetObject("LIMPIAR.Image")));
            this.LIMPIAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LIMPIAR.Location = new System.Drawing.Point(343, 403);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(69, 54);
            this.LIMPIAR.TabIndex = 19;
            this.LIMPIAR.Text = "Limpiar";
            this.LIMPIAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LIMPIAR.UseVisualStyleBackColor = false;
            this.LIMPIAR.Click += new System.EventHandler(this.LIMPIAR_Click);
            // 
            // CANCELARBTN
            // 
            this.CANCELARBTN.BackColor = System.Drawing.Color.DarkOrange;
            this.CANCELARBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CANCELARBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CANCELARBTN.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCELARBTN.Image = ((System.Drawing.Image)(resources.GetObject("CANCELARBTN.Image")));
            this.CANCELARBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CANCELARBTN.Location = new System.Drawing.Point(424, 403);
            this.CANCELARBTN.Name = "CANCELARBTN";
            this.CANCELARBTN.Size = new System.Drawing.Size(71, 54);
            this.CANCELARBTN.TabIndex = 20;
            this.CANCELARBTN.Text = "Cancelar";
            this.CANCELARBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CANCELARBTN.UseVisualStyleBackColor = false;
            this.CANCELARBTN.Click += new System.EventHandler(this.CANCELARBTN_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(198, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 74);
            this.panel2.TabIndex = 21;
            // 
            // datemascota
            // 
            this.datemascota.Location = new System.Drawing.Point(261, 356);
            this.datemascota.Name = "datemascota";
            this.datemascota.Size = new System.Drawing.Size(200, 20);
            this.datemascota.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(107, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 14);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tipo Mascota";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TipoMascotacmb
            // 
            this.TipoMascotacmb.FormattingEnabled = true;
            this.TipoMascotacmb.Items.AddRange(new object[] {
            "Perro",
            "Loro",
            "Gato"});
            this.TipoMascotacmb.Location = new System.Drawing.Point(261, 229);
            this.TipoMascotacmb.Name = "TipoMascotacmb";
            this.TipoMascotacmb.Size = new System.Drawing.Size(100, 21);
            this.TipoMascotacmb.TabIndex = 24;
            // 
            // BuscarMascotaBtn
            // 
            this.BuscarMascotaBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.BuscarMascotaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuscarMascotaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuscarMascotaBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarMascotaBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuscarMascotaBtn.Image")));
            this.BuscarMascotaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarMascotaBtn.Location = new System.Drawing.Point(189, 403);
            this.BuscarMascotaBtn.Name = "BuscarMascotaBtn";
            this.BuscarMascotaBtn.Size = new System.Drawing.Size(71, 54);
            this.BuscarMascotaBtn.TabIndex = 25;
            this.BuscarMascotaBtn.Text = "Buscar";
            this.BuscarMascotaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarMascotaBtn.UseVisualStyleBackColor = false;
            this.BuscarMascotaBtn.Click += new System.EventHandler(this.BuscarMascotaBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrange;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(112, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 54);
            this.button4.TabIndex = 26;
            this.button4.Text = "Eliminar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ModificarMascotaBtn
            // 
            this.ModificarMascotaBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.ModificarMascotaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ModificarMascotaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ModificarMascotaBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarMascotaBtn.Image = ((System.Drawing.Image)(resources.GetObject("ModificarMascotaBtn.Image")));
            this.ModificarMascotaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ModificarMascotaBtn.Location = new System.Drawing.Point(266, 403);
            this.ModificarMascotaBtn.Name = "ModificarMascotaBtn";
            this.ModificarMascotaBtn.Size = new System.Drawing.Size(71, 54);
            this.ModificarMascotaBtn.TabIndex = 27;
            this.ModificarMascotaBtn.Text = "Editar";
            this.ModificarMascotaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ModificarMascotaBtn.UseVisualStyleBackColor = false;
            this.ModificarMascotaBtn.Click += new System.EventHandler(this.ModificarMascotaBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(109, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 14);
            this.label10.TabIndex = 28;
            this.label10.Text = "Id Cliente";
            // 
            // IdClientetxt
            // 
            this.IdClientetxt.Location = new System.Drawing.Point(261, 138);
            this.IdClientetxt.Name = "IdClientetxt";
            this.IdClientetxt.Size = new System.Drawing.Size(100, 20);
            this.IdClientetxt.TabIndex = 29;
            // 
            // raxatxt
            // 
            this.raxatxt.Location = new System.Drawing.Point(261, 271);
            this.raxatxt.Name = "raxatxt";
            this.raxatxt.Size = new System.Drawing.Size(100, 20);
            this.raxatxt.TabIndex = 31;
            // 
            // RegistroMascotaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(540, 499);
            this.Controls.Add(this.raxatxt);
            this.Controls.Add(this.IdClientetxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ModificarMascotaBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BuscarMascotaBtn);
            this.Controls.Add(this.TipoMascotacmb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.datemascota);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CANCELARBTN);
            this.Controls.Add(this.LIMPIAR);
            this.Controls.Add(this.GuardarMascotaBtn);
            this.Controls.Add(this.colortxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroMascotaFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CitasFrm";
            this.Load += new System.EventHandler(this.RegistroMascotaFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox colortxt;
        private System.Windows.Forms.Button GuardarMascotaBtn;
        private System.Windows.Forms.PictureBox MinimizarBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox CerrarBtn;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.Button CANCELARBTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker datemascota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TipoMascotacmb;
        private System.Windows.Forms.Button BuscarMascotaBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ModificarMascotaBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IdClientetxt;
        private System.Windows.Forms.TextBox raxatxt;
    }
}