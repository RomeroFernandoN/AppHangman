using AppAhorcado.AppAhorcadoBackend.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AppAhorcado.AppAhorcadoFrontend
{
    public class FrmControl
    {
        public static FrmControl oControl;
        public static FrmControl ObtenerInstancia()
        {
            if (oControl == null)
                oControl = new FrmControl();
            return oControl;
        }
        public bool MessageExit()
        {
            bool close = false;
            Message oMessage;
            using ( oMessage = new Message("Want to exit?", "Yes", "No", "", AppAhorcado.Properties.Resources.Question))
            {
                oMessage.ShowDialog();
                if (oMessage.leave == 0)
                {
                    return close;
                }
                else
                {
                    close = true;
                }
            }
            return close;
        }
        public void OpenLogin(Login oLogin, FactoryService oFactory)
        {
         if (oLogin.IsDisposed)
            {
                oLogin = new Login(oFactory);
            }
            Program.context.MainForm = oLogin;
            oLogin.Show();
        }
        public void OpenRegister(Register oRegister, FactoryService oFactory)
        {
            if (oRegister.IsDisposed)
            {
                oRegister = new Register(oFactory);
            }
            Program.context.MainForm = oRegister;
            oRegister.Show();
        }
        public void OpenOptions(Options oOptions, FactoryService oFactory, string email)
        {
            if (oOptions.IsDisposed)
            {
                oOptions = new Options(oFactory, email);
            }

            Program.context.MainForm = oOptions;
            oOptions.Show();
        }
        public void OpenStart(Start oStart,FactoryService oFactory)
        {
            if (oStart.IsDisposed)
            {
                oStart = new Start(oFactory);
            }
            Program.context.MainForm = oStart;
            oStart.Show();
        }
        public void OpenGame(Game oGame, FactoryService oFactory, string email)
        {
            if (oGame.IsDisposed)
            {
                oGame = new Game(oFactory, email);
            }
            oGame.Show();
        }
        public void OpenPunctuation(Punctuation oPunctuation, FactoryService oFactory)
        {
            if (oPunctuation.IsDisposed)
            {
                oPunctuation = new Punctuation(oFactory);
            }
            oPunctuation.Show();
        }
    }
}
