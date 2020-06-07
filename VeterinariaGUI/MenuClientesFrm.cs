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
    public partial class MenuClientesFrm : Form
    {

        ClienteService clienteservice;

        ResponseClienteConsulta respuestaConsulta = new ResponseClienteConsulta();
       
        public MenuClientesFrm(ClienteService _Cs)
        {
            //ESTO DEBE SER INGRESADO POR EL CONSTRUCTOR DESDE EL FORMULARIO PRINCIPAL PARA EVITAR MULTIPLES INSTANCIAS
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionRochety"].ConnectionString;
            clienteservice = _Cs;
            //clienteservice = new ClienteService(connectionString);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroClienteFrm registroClienteFrm = new RegistroClienteFrm();
            registroClienteFrm.Show();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MinimizarBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            respuestaConsulta = clienteservice.Consultar();

            consultar();
        }

        private void consultar()
        {
            if (TipoConsultaCmb.SelectedIndex == 0)
            {
                dataGridView1.DataSource = respuestaConsulta.clientes;
            }
        }
    }
}
