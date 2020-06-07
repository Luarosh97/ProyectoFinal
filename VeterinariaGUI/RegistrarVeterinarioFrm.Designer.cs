namespace VeterinariaGUI
{
    partial class RegistrarVeterinarioFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarVeterinarioFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CerrarBtn = new System.Windows.Forms.PictureBox();
            this.MinimizarBtn = new System.Windows.Forms.PictureBox();
            this.CorreoTxt = new System.Windows.Forms.TextBox();
            this.TelefonoTxt = new System.Windows.Forms.TextBox();
            this.DireccionTxt = new System.Windows.Forms.TextBox();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.NombreClienteTxt = new System.Windows.Forms.TextBox();
            this.CedulaTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.LimpiarVeterinarioBtn = new System.Windows.Forms.Button();
            this.GuardarVeterinarioBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.TipoCmb = new System.Windows.Forms.ComboBox();
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
            this.panel1.Size = new System.Drawing.Size(445, 35);
            this.panel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "Registro de Veterinario";
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBtn.Image")));
            this.CerrarBtn.Location = new System.Drawing.Point(411, 3);
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
            this.MinimizarBtn.Location = new System.Drawing.Point(380, 3);
            this.MinimizarBtn.Name = "MinimizarBtn";
            this.MinimizarBtn.Size = new System.Drawing.Size(25, 25);
            this.MinimizarBtn.TabIndex = 4;
            this.MinimizarBtn.TabStop = false;
            this.MinimizarBtn.Click += new System.EventHandler(this.MinimizarBtn_Click);
            // 
            // CorreoTxt
            // 
            this.CorreoTxt.Location = new System.Drawing.Point(174, 284);
            this.CorreoTxt.Name = "CorreoTxt";
            this.CorreoTxt.Size = new System.Drawing.Size(100, 20);
            this.CorreoTxt.TabIndex = 25;
            // 
            // TelefonoTxt
            // 
            this.TelefonoTxt.Location = new System.Drawing.Point(174, 216);
            this.TelefonoTxt.Name = "TelefonoTxt";
            this.TelefonoTxt.Size = new System.Drawing.Size(100, 20);
            this.TelefonoTxt.TabIndex = 24;
            // 
            // DireccionTxt
            // 
            this.DireccionTxt.Location = new System.Drawing.Point(174, 182);
            this.DireccionTxt.Name = "DireccionTxt";
            this.DireccionTxt.Size = new System.Drawing.Size(100, 20);
            this.DireccionTxt.TabIndex = 23;
            this.DireccionTxt.TextChanged += new System.EventHandler(this.DireccionTxt_TextChanged);
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Location = new System.Drawing.Point(174, 148);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(100, 20);
            this.ApellidoTxt.TabIndex = 22;
            // 
            // NombreClienteTxt
            // 
            this.NombreClienteTxt.Location = new System.Drawing.Point(174, 114);
            this.NombreClienteTxt.Name = "NombreClienteTxt";
            this.NombreClienteTxt.Size = new System.Drawing.Size(100, 20);
            this.NombreClienteTxt.TabIndex = 21;
            // 
            // CedulaTxt
            // 
            this.CedulaTxt.Location = new System.Drawing.Point(174, 80);
            this.CedulaTxt.Name = "CedulaTxt";
            this.CedulaTxt.Size = new System.Drawing.Size(100, 20);
            this.CedulaTxt.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cedula";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 14);
            this.label9.TabIndex = 27;
            this.label9.Text = "Cargo";
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.EliminarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EliminarBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBtn.Image = ((System.Drawing.Image)(resources.GetObject("EliminarBtn.Image")));
            this.EliminarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarBtn.Location = new System.Drawing.Point(284, 370);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(71, 54);
            this.EliminarBtn.TabIndex = 33;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarBtn.UseVisualStyleBackColor = false;
            this.EliminarBtn.Click += new System.EventHandler(this.CancelarVeterinarioBtn_Click);
            // 
            // LimpiarVeterinarioBtn
            // 
            this.LimpiarVeterinarioBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.LimpiarVeterinarioBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LimpiarVeterinarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LimpiarVeterinarioBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarVeterinarioBtn.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarVeterinarioBtn.Image")));
            this.LimpiarVeterinarioBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LimpiarVeterinarioBtn.Location = new System.Drawing.Point(191, 443);
            this.LimpiarVeterinarioBtn.Name = "LimpiarVeterinarioBtn";
            this.LimpiarVeterinarioBtn.Size = new System.Drawing.Size(69, 54);
            this.LimpiarVeterinarioBtn.TabIndex = 32;
            this.LimpiarVeterinarioBtn.Text = "Limpiar";
            this.LimpiarVeterinarioBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LimpiarVeterinarioBtn.UseVisualStyleBackColor = false;
            this.LimpiarVeterinarioBtn.Click += new System.EventHandler(this.LimpiarVeterinarioBtn_Click);
            // 
            // GuardarVeterinarioBtn
            // 
            this.GuardarVeterinarioBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.GuardarVeterinarioBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GuardarVeterinarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GuardarVeterinarioBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarVeterinarioBtn.Image = ((System.Drawing.Image)(resources.GetObject("GuardarVeterinarioBtn.Image")));
            this.GuardarVeterinarioBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarVeterinarioBtn.Location = new System.Drawing.Point(92, 370);
            this.GuardarVeterinarioBtn.Name = "GuardarVeterinarioBtn";
            this.GuardarVeterinarioBtn.Size = new System.Drawing.Size(69, 54);
            this.GuardarVeterinarioBtn.TabIndex = 31;
            this.GuardarVeterinarioBtn.Text = "Guardar";
            this.GuardarVeterinarioBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarVeterinarioBtn.UseVisualStyleBackColor = false;
            this.GuardarVeterinarioBtn.Click += new System.EventHandler(this.GuardarVeterinarioBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(79, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 14);
            this.label10.TabIndex = 34;
            this.label10.Text = "Fecha De Ingreso";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(189, 317);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 35;
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.ModificarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ModificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ModificarBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarBtn.Image = ((System.Drawing.Image)(resources.GetObject("ModificarBtn.Image")));
            this.ModificarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ModificarBtn.Location = new System.Drawing.Point(92, 443);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(69, 54);
            this.ModificarBtn.TabIndex = 36;
            this.ModificarBtn.Text = "Editar";
            this.ModificarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ModificarBtn.UseVisualStyleBackColor = false;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.BuscarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BuscarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuscarBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuscarBtn.Image")));
            this.BuscarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarBtn.Location = new System.Drawing.Point(189, 370);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(71, 54);
            this.BuscarBtn.TabIndex = 37;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarBtn.UseVisualStyleBackColor = false;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.CancelarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelarBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CancelarBtn.Image")));
            this.CancelarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CancelarBtn.Location = new System.Drawing.Point(284, 443);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(71, 54);
            this.CancelarBtn.TabIndex = 38;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelarBtn.UseVisualStyleBackColor = false;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // TipoCmb
            // 
            this.TipoCmb.FormattingEnabled = true;
            this.TipoCmb.Items.AddRange(new object[] {
            "Peluquero",
            "Cirujano",
            "Medico general"});
            this.TipoCmb.Location = new System.Drawing.Point(174, 250);
            this.TipoCmb.Name = "TipoCmb";
            this.TipoCmb.Size = new System.Drawing.Size(121, 21);
            this.TipoCmb.TabIndex = 39;
            // 
            // RegistrarVeterinarioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(445, 516);
            this.Controls.Add(this.TipoCmb);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.LimpiarVeterinarioBtn);
            this.Controls.Add(this.GuardarVeterinarioBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CorreoTxt);
            this.Controls.Add(this.TelefonoTxt);
            this.Controls.Add(this.DireccionTxt);
            this.Controls.Add(this.ApellidoTxt);
            this.Controls.Add(this.NombreClienteTxt);
            this.Controls.Add(this.CedulaTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarVeterinarioFrm";
            this.Text = "RegistrarVeterinarioFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox CerrarBtn;
        private System.Windows.Forms.PictureBox MinimizarBtn;
        private System.Windows.Forms.TextBox CorreoTxt;
        private System.Windows.Forms.TextBox TelefonoTxt;
        private System.Windows.Forms.TextBox DireccionTxt;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.TextBox NombreClienteTxt;
        private System.Windows.Forms.TextBox CedulaTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button LimpiarVeterinarioBtn;
        private System.Windows.Forms.Button GuardarVeterinarioBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.ComboBox TipoCmb;
    }
}