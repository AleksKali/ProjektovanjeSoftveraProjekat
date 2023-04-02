using Domen;
using KorisnickiInterfejs.ServerKomunikacija;
using KorisnickiInterfejs.UserControls.Igrice;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.KontrolerKI
{
    class PretragaIgricaKontroler
    {
        private UCPretragaIgrica uc;

        public PretragaIgricaKontroler(UCPretragaIgrica uc)
        {
            this.uc = uc;
        }
        internal void Init()
        {
            try
            {
            uc.DgvPretragaIgrica.DataSource =  Komunikacija.Instance.SendRequestGetResult<List<Igrica>>(Common.Komunikacija.Operacija.VratiIgrice);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> " + ex.Message);

            }
            uc.TbImeIgrice.TextChanged += TbImeIgrice_TextChanged;
        }

        private void TbImeIgrice_TextChanged(object sender, EventArgs e)
        {

            Igrica i = new Igrica
            {
                uslovPretrage = uc.TbImeIgrice.Text
            };
           
            try
            {
                
                uc.DgvPretragaIgrica.DataSource = uc.DgvPretragaIgrica.DataSource = Komunikacija.Instance.SendRequestGetResult<List<Igrica>>(Common.Komunikacija.Operacija.PretraziIgrice, i);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da nađe igrice po zadatoj vrednosti.");
                Debug.WriteLine(">>> " + ex.Message);
            }
        }

       
    }
}
