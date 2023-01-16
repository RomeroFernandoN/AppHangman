using AppAhorcado.AppAhorcadoBackend.Service;
using AppAhorcado.AppAhorcadoBackend.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAhorcado.AppAhorcadoFrontend
{
    public partial class Login : Form
    {
        private IService oService;
        private Options oOptions;
        private Message oMessage;
        private Start oStart;
        public FactoryService oFactory;
        public Login(FactoryService oFactory)
        {
            InitializeComponent();
            this.oFactory = oFactory;
            oService = oFactory.CreateService();
            lblHangman.Select();

        }
        private void Login_Load(object sender, EventArgs e)
        {
            CompleteFields();
            oStart = new Start(this.oFactory);
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmControl.ObtenerInstancia().OpenStart(oStart, this.oFactory);
            this.Dispose();
        }
        public void CompleteFields()
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Enter your name.";
            }
        }

        public bool Validation()
        {
            bool aux = true;

            if (txtEmail.Text == "" || txtEmail.Text == "Enter your name.")
            {
                aux = false;
                txtEmail.Focus();
                return aux;
            }

            return aux;
        }

        async void btnConfirm_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                string email = txtEmail.Text;
                oOptions = new Options(oFactory, email);

                if (oService.Session(email) == 1)
                {
                    await Task.Delay(500);
                    oMessage = new Message("Session started.", "", "", "Ok.", AppAhorcado.Properties.Resources.Correct);
                    oMessage.Show();
                    FrmControl.ObtenerInstancia().OpenOptions(oOptions, this.oFactory, email);
                    this.Dispose();
                    oMessage.Focus();
                }
                else
                {
                    await Task.Delay(500);
                    oMessage = new Message("Login error.", "", "", "Ok.", AppAhorcado.Properties.Resources.Incorrect);
                    oMessage.Show();
                    return;
                }
            }
        }
    }
}
