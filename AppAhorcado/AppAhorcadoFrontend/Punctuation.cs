using AppAhorcado.AppAhorcadoBackend.Service;
using AppAhorcado.AppAhorcadoBackend.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppAhorcado.AppAhorcadoFrontend
{
    public partial class Punctuation : Form
    {
        private IService oService;
        public Punctuation(FactoryService oFactory)
        {
            InitializeComponent();
            oService = oFactory.CreateService();
            lblPunctuation.Select();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Punctuation_Load(object sender, EventArgs e)
        {
            dgvPunctuation.DataSource = oService.BestScores();
        }
    }
}
