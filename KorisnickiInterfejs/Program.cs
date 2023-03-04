﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region konacnaVerzija
            /*
            while (true)
            {
                try
                {
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.ShowDialog();
                    DialogResult result = frmLogin.DialogResult;
                    frmLogin.Dispose();

                    if (result == DialogResult.OK)
                    {
                        Application.Run(new FrmMain());
                    }
                    if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
                catch (Exception ex) //ovde treba da stoji ServerCommunicationException
                {
                    MessageBox.Show(ex.Message); //tekst je greska pri radu sa serverom!
                }
            } */
            #endregion

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            DialogResult result = frmLogin.DialogResult;
            frmLogin.Dispose();

            if (result == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }

        }
    }
}
