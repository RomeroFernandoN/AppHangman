using AppAhorcado.AppAhorcadoBackend.Service;
using AppAhorcado.AppAhorcadoBackend.Service.Interface;
using AppAhorcado.AppAhorcadoFrontend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAhorcado
{
    public partial class Game : Form
    {
        public FactoryService oFactory;
        private IService oService;
        private Message oMessage;
        private int amount;
        private int attempt = 7;
        private int guessed = 0;
        private int helps = 0;
        private List<char> list;
        private List<string> lettersRepeated;
        private List<string> newList;
        private List<Button> listButton = new List<Button>();
        private string newString;
        private string email;
        private string cadena;
        public Game(FactoryService oFactory, string email)
        {
            InitializeComponent();
            this.oFactory = oFactory;
            this.email = email;
            oService = oFactory.CreateService();
            lblResults.Select();
            lettersRepeated = new List<string>();
            oService.ChangeImage(attempt, picBox);
            Words();
            Button btn = new Button();
            Validation("", btn);
        }
        private void Words()
        {
            cadena = oService.AvailableWords().ToUpper();
            list = new List<char>();
            list.AddRange(cadena);
            amount = cadena.Length;
        }
        public void Validation(string letter, Button btn)
        {
            Decrease(letter);
            Hits(letter);
            btn.BackColor = Color.DarkGray;
            btn.ForeColor = Color.White;
            btn.Enabled = false;
            listButton.Add(btn);
            lblResults.Select();
        }
        public void Decrease(string letter)
        {
            var newList = oService.Repeated(letter, lettersRepeated);
            bool aux = newList[0].Item3;

            if (oService.AccountantLetters(amount, letter, list) == 0)
            {
                if (aux == false)
                {
                    attempt = attempt - 1;
                    oService.ChangeImage(attempt, picBox);
                }
            }
            else
            {

            }
        }
        public void Hits(string letter)
        {
            if (guessed == 0)
            {
                newString = String.Concat(Enumerable.Repeat("_ ", amount));
                newList = newString.Split(" ").ToList();
            }

            for (int i = 0; i < amount; i++)
            {
                if (list[i].ToString() == letter)
                {
                    newList[i] = letter;
                    guessed = guessed + 1;
                }
            }
            string combinedList = string.Join("  ", newList);
            lblResults.Text = combinedList;

            Punctuation(newList);
        }

        async void Punctuation(List<string> list)
        {
            if (attempt >= 1)
            {
                if (oService.CountLetters(list))
                {
                    oService.UploadScore(attempt, email);

                    lblResults.ForeColor = Color.LimeGreen;

                    await Task.Delay(1000);
                    this.Dispose();
                    oMessage = new Message("Won.", "", "", "Ok.", AppAhorcado.Properties.Resources.Correct);
                    oMessage.Show();
                }
            }
            else
            {
                List<string> lst = new List<string>();
                foreach (char l in cadena)
                {
                    string w =Convert.ToString(l) + " ";
                    lst.Add(w);
                }
                string a = string.Join(" ", lst);
                lblResults.Text = a;
                lblResults.ForeColor = Color.Red;

                await Task.Delay(1000);
                this.Dispose();
                oMessage = new Message("You lost.", "", "", "Ok.", AppAhorcado.Properties.Resources.Incorrect);
                oMessage.Show();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnA.Click += new EventHandler(this.Button_Click);
            btnB.Click += new EventHandler(this.Button_Click);
            btnC.Click += new EventHandler(this.Button_Click);
            btnD.Click += new EventHandler(this.Button_Click);
            btnE.Click += new EventHandler(this.Button_Click);
            btnF.Click += new EventHandler(this.Button_Click);
            btnG.Click += new EventHandler(this.Button_Click);
            btnH.Click += new EventHandler(this.Button_Click);
            btnI.Click += new EventHandler(this.Button_Click);
            btnJ.Click += new EventHandler(this.Button_Click);
            btnK.Click += new EventHandler(this.Button_Click);
            btnL.Click += new EventHandler(this.Button_Click);
            btnM.Click += new EventHandler(this.Button_Click);
            btnN.Click += new EventHandler(this.Button_Click);
            btnÑ.Click += new EventHandler(this.Button_Click);
            btnO.Click += new EventHandler(this.Button_Click);
            btnP.Click += new EventHandler(this.Button_Click);
            btnQ.Click += new EventHandler(this.Button_Click);
            btnR.Click += new EventHandler(this.Button_Click);
            btnS.Click += new EventHandler(this.Button_Click);
            btnT.Click += new EventHandler(this.Button_Click);
            btnU.Click += new EventHandler(this.Button_Click);
            btnV.Click += new EventHandler(this.Button_Click);
            btnW.Click += new EventHandler(this.Button_Click);
            btnX.Click += new EventHandler(this.Button_Click);
            btnY.Click += new EventHandler(this.Button_Click);
            btnZ.Click += new EventHandler(this.Button_Click);
        }
        void Button_Click(Object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnA":
                    Validation("A", btnA);
                    break;
                case "btnB":
                    Validation("B", btnB);
                    break;
                case "btnC":
                    Validation("C", btnC);
                    break;
                case "btnD":
                    Validation("D", btnD);
                    break;
                case "btnE":
                    Validation("E", btnE);
                    break;
                case "btnF":
                    Validation("F", btnF);
                    break;
                case "btnG":
                    Validation("G", btnG);
                    break;
                case "btnH":
                    Validation("H", btnH);
                    break;
                case "btnI":
                    Validation("I", btnI);
                    break;
                case "btnJ":
                    Validation("J", btnJ);
                    break;
                case "btnK":
                    Validation("K", btnK);
                    break;
                case "btnL":
                    Validation("L", btnL);
                    break;
                case "btnM":
                    Validation("M", btnM);
                    break;
                case "btnN":
                    Validation("N", btnN);
                    break;
                case "btnÑ":
                    Validation("Ñ", btnÑ);
                    break;
                case "btnO":
                    Validation("O", btnO);
                    break;
                case "btnP":
                    Validation("P", btnP);
                    break;
                case "btnQ":
                    Validation("Q", btnQ);
                    break;
                case "btnR":
                    Validation("R", btnR);
                    break;
                case "btnS":
                    Validation("S", btnS);
                    break;
                case "btnT":
                    Validation("T", btnT);
                    break;
                case "btnU":
                    Validation("U", btnU);
                    break;
                case "btnV":
                    Validation("V", btnV);
                    break;
                case "btnW":
                    Validation("W", btnW);
                    break;
                case "btnX":
                    Validation("X", btnX);
                    break;
                case "btnY":
                    Validation("Y", btnY);
                    break;
                case "btnZ":
                    Validation("Z", btnZ);
                    break;
            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            attempt = 7;
            guessed = 0;
            list.Clear();
            lettersRepeated.Clear();
            newList.Clear();

            oService.ChangeImage(attempt, picBox);
            Words();

            Button btn = new Button();
            Validation("", btn);

            foreach (Button button in listButton)
            {
                button.BackColor = Color.Transparent;
                button.ForeColor = Color.FromArgb(102, 102, 102, 102);
                button.Enabled = true;
            }

            listButton.Clear();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            string aux;
            if (helps == 0)
            {
                for (int i = 0; i < amount; i++)
                {
                    if (newList[i] == "_")
                    {
                        aux = list[i].ToString();
                        Hits(aux);
                        helps = helps + 1;
                        btnHelp.BackColor = Color.DarkGray;
                        btnHelp.ForeColor = Color.White;
                        btnHelp.Enabled = false;
                        break;
                    }
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (FrmControl.ObtenerInstancia().MessageExit())
            {
                this.Dispose();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
