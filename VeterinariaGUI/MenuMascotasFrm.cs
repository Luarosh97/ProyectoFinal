using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BLL;
using Entity;


namespace VeterinariaGUI
{    
    public partial class MenuMascotasFrm : Form
    {


        MascotaService mascotaService;
        ResponseConsultaMascota respuestaconsulta;
        public MenuMascotasFrm()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionRochety"].ConnectionString;
            mascotaService = new MascotaService(connectionString);
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AgregarMascotaBtn_Click(object sender, EventArgs e)
        {
            RegistroMascotaFrm registroMascotaFrm = new RegistroMascotaFrm();
            registroMascotaFrm.Show();
        }

        private void MinimizarBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarMascotaBtn_Click(object sender, EventArgs e)
        {
            MascotaDtg.DataSource = null;
            respuestaconsulta = mascotaService.Consultar();

            consultar();
        }

        private void consultar()
        {
            if (Mascotacmb.SelectedIndex == 0)
            {
              MascotaDtg.DataSource = respuestaconsulta.mascotas;
            }
        }
    }
}
