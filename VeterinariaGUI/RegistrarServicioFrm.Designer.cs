namespace VeterinariaGUI
{
    partial class RegistrarServicioFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarServicioFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CerrarBtn = new System.Windows.Forms.PictureBox();
            this.MinimizarBtn = new System.Windows.Forms.PictureBox();
            this.CancelarCancelarBtn = new System.Windows.Forms.Button();
            this.LimpiarServicioBtn = new System.Windows.Forms.Button();
            this.GuardarServicioBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(449, 35);
            this.panel1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "Registro de Servicios";
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBtn.Image")));
            this.CerrarBtn.Location = new System.Drawing.Point(408, 7);
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
            this.MinimizarBtn.Location = new System.Drawing.Point(377, 3);
            this.MinimizarBtn.Name = "MinimizarBtn";
            this.MinimizarBtn.Size = new System.Drawing.Size(25, 25);
            this.MinimizarBtn.TabIndex = 4;
            this.MinimizarBtn.TabStop = false;
            this.MinimizarBtn.Click += new System.EventHandler(this.MinimizarBtn_Click);
            // 
            // CancelarCancelarBtn
            // 
            this.CancelarCancelarBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.CancelarCancelarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelarCancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelarCancelarBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarCancelarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CancelarCancelarBtn.Image")));
            this.CancelarCancelarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CancelarCancelarBtn.Location = new System.Drawing.Point(69, 266);
            this.CancelarCancelarBtn.Name = "CancelarCancelarBtn";
            this.CancelarCancelarBtn.Size = new System.Drawing.Size(71, 54);
            this.CancelarCancelarBtn.TabIndex = 36;
            this.CancelarCancelarBtn.Text = "Eliminar";
            this.CancelarCancelarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelarCancelarBtn.UseVisualStyleBackColor = false;
            this.CancelarCancelarBtn.Click += new System.EventHandler(this.CancelarCancelarBtn_Click);
            // 
            // LimpiarServicioBtn
            // 
            this.LimpiarServicioBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.LimpiarServicioBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LimpiarServicioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LimpiarServicioBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarServicioBtn.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarServicioBtn.Image")));
            this.LimpiarServicioBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LimpiarServicioBtn.Location = new System.Drawing.Point(301, 195);
            this.LimpiarServicioBtn.Name = "LimpiarServicioBtn";
            this.LimpiarServicioBtn.Size = new System.Drawing.Size(69, 54);
            this.LimpiarServicioBtn.TabIndex = 35;
            this.LimpiarServicioBtn.Text = "Limpiar";
            this.LimpiarServicioBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LimpiarServicioBtn.UseVisualStyleBackColor = false;
            this.LimpiarServicioBtn.Click += new System.EventHandler(this.LimpiarServicioBtn_Click);
            // 
            // GuardarServicioBtn
            // 
            this.GuardarServicioBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.GuardarServicioBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GuardarServicioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GuardarServicioBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarServicioBtn.Image = ((System.Drawing.Image)(resources.GetObject("GuardarServicioBtn.Image")));
            this.GuardarServicioBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarServicioBtn.Location = new System.Drawing.Point(69, 195);
            this.GuardarServicioBtn.Name = "GuardarServicioBtn";
            this.GuardarServicioBtn.Size = new System.Drawing.Size(69, 54);
            this.GuardarServicioBtn.TabIndex = 34;
            this.GuardarServicioBtn.Text = "Guardar";
            this.GuardarServicioBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarServicioBtn.UseVisualStyleBackColor = false;
            this.GuardarServicioBtn.Click += new System.EventHandler(this.GuardarServicioBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 14);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre del Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 14);
            this.label2.TabIndex = 38;
            this.label2.Text = "Precio del Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 14);
            this.label3.TabIndex = 39;
            this.label3.Text = "Codigo Servicio";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(227, 55);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(100, 20);
            this.NombreTxt.TabIndex = 40;
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Location = new System.Drawing.Point(227, 98);
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.Size = new System.Drawing.Size(100, 20);
            this.CodigoTxt.TabIndex = 41;
            // 
            // preciotxt
            // 
            this.preciotxt.Location = new System.Drawing.Point(227, 141);
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(100, 20);
            this.preciotxt.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(189, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 54);
            this.button1.TabIndex = 47;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(299, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 54);
            this.button2.TabIndex = 48;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(189, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 54);
            this.button3.TabIndex = 49;
            this.button3.Text = "Editar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RegistrarServicioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(449, 355);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.CodigoTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarCancelarBtn);
            this.Controls.Add(this.LimpiarServicioBtn);
            this.Controls.Add(this.GuardarServicioBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarServicioFrm";
            this.Text = "RegistrarServicioFrm";
            this.Load += new System.EventHandler(this.RegistrarServicioFrm_Load);
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
        private System.Windows.Forms.Button CancelarCancelarBtn;
        private System.Windows.Forms.Button LimpiarServicioBtn;
        private System.Windows.Forms.Button GuardarServicioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox CodigoTxt;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}