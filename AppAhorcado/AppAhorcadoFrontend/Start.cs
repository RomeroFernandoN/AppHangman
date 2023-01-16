using AppAhorcado.AppAhorcadoBackend.Service;
using AppAhorcado.AppAhorcadoBackend.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAhorcado.AppAhorcadoFrontend
{
    public partial class Start : Form
    {
        private IService oService;
        private Register oRegister;
        private Login oLogin;
        public FactoryService oFactory;
        public Start(FactoryService oFactory)
        {
            InitializeComponent();
            this.oFactory = oFactory;
            oService = oFactory.CreateService();
            lblH.Select();
        }
        private void Start_Load(object sender, EventArgs e)
        {
            oLogin = new Login(this.oFactory);
            oRegister = new Register(this.oFactory);
            WaitForMilliseconds();
        }
        async void WaitForMilliseconds()
        {
            if(lblH.Visible == false)
            {
                await Task.Delay(2000);
                lblH.Visible = true;
                await Task.Delay(300);
                lblA.Visible = true;
                await Task.Delay(300);
                lblN.Visible = true;
                await Task.Delay(300);
                lblG.Visible = true;
                await Task.Delay(300);
                lblM.Visible = true;
                await Task.Delay(300);
                lblAT.Visible = true;
                await Task.Delay(300);
                lblNT.Visible = true;
            }    
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if(FrmControl.ObtenerInstancia().MessageExit())
            {
                this.Dispose();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmControl.ObtenerInstancia().OpenLogin(oLogin, this.oFactory);
            this.Dispose();
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            FrmControl.ObtenerInstancia().OpenRegister(oRegister, this.oFactory);
            this.Dispose();
        }
    }
}
