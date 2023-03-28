using Domen;
using KorisnickiInterfejs.ServerKomunikacija;
using KorisnickiInterfejs.UserControls.Igrice;
using System;
using System.Collections.Generic;
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
            uc.DgvPretragaIgrica.DataSource =  Komunikacija.Instance.SendRequestGetResult<List<Igrica>>(Common.Komunikacija.Operacija.VratiIgrice);
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
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
