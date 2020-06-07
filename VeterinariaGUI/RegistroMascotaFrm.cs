using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
using System.Configuration;

namespace VeterinariaGUI
{
    public partial class RegistroMascotaFrm : Form
    {
        MascotaService mascotaService;

        public RegistroMascotaFrm()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionRochety"].ConnectionString;
            mascotaService = new MascotaService(connectionString);

            InitializeComponent();
        }

        private void MinimizarBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void RegistroMascotaFrm_Load(object sender, EventArgs e)
        {

        }

        private void GuardarMascotaBtn_Click(object sender, EventArgs e)
        {
            Mascota mascota = MapearMascota();
            string mensaje = mascotaService.Guardar(mascota);
            MessageBox.Show(mensaje);


        }

        private Mascota MapearMascota()
        {
            Mascota mascota = new Mascota();
            mascota.IdCliente = IdClientetxt.Text;
            mascota.TipoMascota = TipoMascotacmb.Text;
            mascota.NombreMascota = nombretxt.Text;
            mascota.laRaza = raxatxt.Text;
            mascota.Color = colortxt.Text;
            mascota.FechaNacimiento = datemascota.Value;
            return mascota;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void CANCELARBTN_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            nombretxt.Text = "";
            IdClientetxt.Text = "";
            TipoMascotacmb.Text = "";
            raxatxt.Text = "";
            colortxt.Text = "";


        }

        private void BuscarMascotaBtn_Click(object sender, EventArgs e)
        {
            

            }
            
        

        private void ModificarMascotaBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}

