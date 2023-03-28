using Common.Komunikacija;
using KorisnickiInterfejs.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs.ServerKomunikacija
{
    public class Komunikacija
    {
        private Socket socket;
        private CommunicationHelper helper;
        private static Komunikacija instance; 

        private Komunikacija()
        {
        }
        public static Komunikacija Instance
        {
            get
            {
                if (instance == null) instance = new Komunikacija();
                return instance;
            }
        }

        public Output SendRequestGetResult<Output>(Operacija op, object i = null) where Output : class
        {
            SendRequest(op, i);
            return GetResult<Output>();
        }

        public void SendRequestNoResult(Operacija op, object i)
        {
            SendRequest(op, i);
            GetResult();
        }

        private T GetResult<T>() where T : class
        {
            Odgovor odgovor = helper.Primi<Odgovor>();
            if (odgovor.Uspesno)
            {
                return (T)odgovor.Rezultat;
            }
            else
            {
                throw new SystemOperationException(odgovor.Poruka);
            }
        }

        private void GetResult()
        {
            Odgovor odgovor = helper.Primi<Odgovor>();
            if (!odgovor.Uspesno)
            {
                throw new SystemOperationException(odgovor.Poruka);
            }
        }

        private void SendRequest(Operacija op, object requestObject = null)
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = op,
                    ZahtevaniObjekat = requestObject
                };
                helper.Posalji(z);
            }
            catch (IOException ex)
            {
                throw new ServerCommunicationException(ex.Message);
            }
        }

        public void Connect()
        {
            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                helper = new CommunicationHelper(socket);
            }
        }
        public void Close()
        {
            if (socket == null) return;
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.Kraj,
            };
            helper.Posalji(z);

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            socket = null;
        }
    }
}
