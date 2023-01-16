using AppAhorcado.AppAhorcadoBackend.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppAhorcado.AppAhorcadoFrontend
{
    public partial class Options : Form
    {
        private Game oGame;
        private Punctuation oPunctuation;
        public FactoryService oFactory;
        private string email;
        public Options(FactoryService oFactory, string email)
        {
            InitializeComponent();
            this.oFactory = oFactory;
            this.email = email;
            lblHangman.Select();
        }
        private void Options_Load(object sender, EventArgs e)
        {
            oGame = new Game(this.oFactory, this.email);
            oPunctuation = new Punctuation(this.oFactory);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            FrmControl.ObtenerInstancia().OpenGame(oGame, this.oFactory, email);
            lblHangman.Select();
        }

        private void btnPunctuation_Click(object sender, EventArgs e)
        {
            FrmControl.ObtenerInstancia().OpenPunctuation(oPunctuation, this.oFactory);
            lblHangman.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (FrmControl.ObtenerInstancia().MessageExit())
            {
                this.Dispose();
            }
        }
    }
}
