using AppAhorcado.AppAhorcadoBackend.Domain;
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
    public partial class Register : Form
    {
        private User oUser;
        private IService oService;
        private string day = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
        private Message oMessage;
        private Options oOptions;
        private Start oStart;
        public FactoryService oFactory;
        public Register(FactoryService oFactory)
        {
            InitializeComponent();
            this.oFactory = oFactory;
            oService = oFactory.CreateService();
            lblHangman.Select();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CompleteFields();
            oStart = new Start(oFactory);
            oOptions = new Options(oFactory, "");
        }
        public void CompleteFields()
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Enter your name.";
            }
            if (txtSurname.Text == "")
            {
                txtSurname.Text = "Enter your surname.";
            }
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Enter your email.";
            }
            if (txtBirthdate.Text == "")
            {
                txtBirthdate.Text = day;
            }
            if (txtCountry.Text == "")
            {
                txtCountry.Text = "Enter your country.";
            }
        }

        public bool Validation()
        {
            bool aux = true;

            if (txtName.Text == "" || txtName.Text == "Enter your name.")
            {
                aux = false;
                txtName.Focus();
                return aux;
            }

            if (txtSurname.Text == "" || txtSurname.Text == "Enter your name.")
            {
                aux = false;
                txtSurname.Focus();
                return aux;
            }

            if (txtEmail.Text == "" || txtEmail.Text == "Enter your name.")
            {
                aux = false;
                txtEmail.Focus();
                return aux;
            }

            if (txtBirthdate.Text == "" || txtBirthdate.Text == day)
            {
                aux = false;
                txtBirthdate.Focus();
                return aux;
            }
            else
            {
                try
                {
                    int.Parse(txtBirthdate.Text.Substring(0,2));
                    int.Parse(txtBirthdate.Text.Substring(3,2));
                    int.Parse(txtBirthdate.Text.Substring(6,4));
                    if (txtBirthdate.Text.Substring(2,1) == "/" || txtBirthdate.Text.Substring(5,1) == "/")
                    {

                    }
                }
                catch
                {
                    aux = false;
                    txtBirthdate.Focus();
                    return aux;
                }
            }

            if (txtCountry.Text == "" || txtCountry.Text == "Enter your country.")
            {
                aux = false;
                txtCountry.Focus();
                return aux;
            }

            return aux;
        }
        async void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                oUser = new User();
                oUser.Name = txtName.Text;
                oUser.Surname = txtSurname.Text;
                oUser.Email = txtEmail.Text;
                oUser.Birthdate = Convert.ToDateTime(txtBirthdate.Text);
                oUser.Points = 0;
                oUser.Country = txtCountry.Text;
                oOptions = new Options(oFactory, oUser.Email);

                if (oService.InsertUser(oUser))
                {
                    await Task.Delay(500);
                    oMessage = new Message("Registration complete.", "","","Ok.", AppAhorcado.Properties.Resources.Correct);
                    oMessage.Show();
                    FrmControl.ObtenerInstancia().OpenOptions(oOptions, this.oFactory, oUser.Email);
                    this.Dispose();
                    oMessage.Focus();
                }
                else
                {
                    await Task.Delay(500);
                    oMessage = new Message("Registration error.", "", "", "Ok.", AppAhorcado.Properties.Resources.Incorrect);
                    oMessage.Show();
                    return;
                }
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmControl.ObtenerInstancia().OpenStart(oStart, this.oFactory);
            this.Dispose();
        }
    }
}
