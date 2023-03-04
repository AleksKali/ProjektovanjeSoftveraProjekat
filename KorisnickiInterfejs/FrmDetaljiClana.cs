using AplikacionaLogika;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class FrmDetaljiClana : Form
    {
        public FrmDetaljiClana(Clan izabranClan)
        {
            InitializeComponent();
            Init(izabranClan);
        }

        private void Init(Clan izabranClan)
        {
            try
            {
                /*
                
                cbManufacturer.DataSource = Kontroler.Instance.GetAllManufacturers();
                cbMeasurementUnit.DataSource = Kontroler.Instance.GetAllMeasurementUnits();*/
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

        }
    }
}
