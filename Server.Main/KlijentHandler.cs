using AplikacionaLogika;
using Common.Komunikacija;
using Domen;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Main
{
    public class KlijentHandler
    {
        private Socket socket;
        private CommunicationHelper helper;

        public EventHandler OdjavljenKlijent;

        public KlijentHandler(Socket socket)
        {
            this.socket = socket;
            helper = new CommunicationHelper(socket);
        }

        private bool kraj = false;
        public void HandleRequests()
        {
            try
            {
                while (!kraj)
                {
                    Zahtev zahtev = helper.Primi<Zahtev>();
                    Odgovor odgovor = KreirajOdgovor(zahtev);
                    helper.Posalji(odgovor);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
            finally
            {
                CloseSocket();
            }
        }


        public Odgovor KreirajOdgovor(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor();
            try
            {
                switch (zahtev.Operacija)
                {
                    case Operacija.Login:
                        odgovor.Rezultat = Kontroler.Instance.Login((Korisnik)zahtev.ZahtevaniObjekat);
                        if (odgovor.Rezultat == null)
                        {
                            odgovor.Uspesno = false;
                            odgovor.Poruka = "Korisnik ne postoji!";
                        }
                        break;
                    case Operacija.VratiClanove:
                        odgovor.Rezultat = Kontroler.Instance.VratiClanove();
                        break;
                    case Operacija.VratiClanarine:
                        odgovor.Rezultat = Kontroler.Instance.VratiClanarine();
                        break;
                    case Operacija.VratiIgrice:
                        odgovor.Rezultat = Kontroler.Instance.VratiIgrice();
                        break;
                    case Operacija.PretraziIgrice:
                        odgovor.Rezultat = Kontroler.Instance.PretraziIgrice((Igrica)zahtev.ZahtevaniObjekat);
                        break;
                    case Operacija.ObrisiClana:
                        Kontroler.Instance.ObrisiClana((Clan)zahtev.ZahtevaniObjekat);
                        break;
                    case Operacija.KreirajClana:
                        odgovor.Rezultat = new List<int>() { Kontroler.Instance.DodajClana((Clan)zahtev.ZahtevaniObjekat) };
                        break;
                    case Operacija.PretraziClanove:
                        odgovor.Rezultat = Kontroler.Instance.PretraziClanove(((Clan)zahtev.ZahtevaniObjekat));
                        break;
                    case Operacija.IzmeniClana:
                        Kontroler.Instance.IzmeniClana((Clan)zahtev.ZahtevaniObjekat);
                        break;
                    case Operacija.VratiZaduzenjaClana:
                        odgovor.Rezultat = Kontroler.Instance.VratiZaduzenjaClana((ZaduzenjePrimerak)zahtev.ZahtevaniObjekat);
                        break;
                    case Operacija.IzbrisiClanarinu:
                        Kontroler.Instance.IzbrisiClanarinu((Clanarina)zahtev.ZahtevaniObjekat);
                        break;
                    case Operacija.EvidentirajClanarinu:
                        Kontroler.Instance.EvidentirajClanarinu((Clanarina)zahtev.ZahtevaniObjekat);
                        break;
                    case Operacija.KreirajZaduzenje:
                        Kontroler.Instance.SacuvajZaduzenje((Zaduzenje)zahtev.ZahtevaniObjekat);
                        break;
                    case Operacija.PretraziPrimerke:
                        odgovor.Rezultat = Kontroler.Instance.VratiPrimerke((Primerak)zahtev.ZahtevaniObjekat);
                        break;
                    case Operacija.VratiPrimerkeZaduzenja:
                        odgovor.Rezultat = Kontroler.Instance.VratiPrimerkeZaduzenja((ZaduzenjePrimerak)zahtev.ZahtevaniObjekat); 
                        break;
                    case Operacija.VratiZaduzenja:
                        odgovor.Rezultat = Kontroler.Instance.VratiZaduzenja(); 
                        break;
                    case Operacija.RazduziZaduzenje:
                        Kontroler.Instance.Razduzi((Zaduzenje)zahtev.ZahtevaniObjekat); //nije
                        break;
                    case Operacija.Kraj:
                        kraj = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                odgovor.Uspesno = false;
                odgovor.Poruka = ex.Message;
            }
            return odgovor;
        }
        private object lockobject = new object();
        internal void CloseSocket()
        {
            lock (lockobject)
            {
                if (socket != null)
                {
                    kraj = true;
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    socket = null;
                    OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
