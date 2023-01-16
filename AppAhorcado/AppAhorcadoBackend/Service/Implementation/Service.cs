using AppAhorcado.AppAhorcadoBackend.Data.Implementation;
using AppAhorcado.AppAhorcadoBackend.Data.Interface;
using AppAhorcado.AppAhorcadoBackend.Domain;
using AppAhorcado.AppAhorcadoBackend.Implementation;
using AppAhorcado.AppAhorcadoBackend.Interface;
using AppAhorcado.AppAhorcadoBackend.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AppAhorcado.AppAhorcadoBackend.Service.Implementation
{
    class Service : IService
    {
        private IAppAhorcadoDao ahorcadoDao;
        private IRegister oRegister;
        private ILogin oLogin;
        public Service()
        {
            ahorcadoDao = new AppAhorcadoDao();
            oRegister = new Register();
            oLogin = new Login();
        }

        public void ChangeImage(int attempt, PictureBox picBox)
        {
            ahorcadoDao.ChangeImage(attempt, picBox);
        }

        public string AvailableWords()
        {
            return ahorcadoDao.AvailableWords();
        }

        public int AccountantLetters(int amount, string letter, List<char> list)
        {
            return ahorcadoDao.AccountantLetters(amount, letter, list);
        }
        public List<(int, List<string>, bool)> Repeated(string letter, List<string> lettersRepeated)
        {
            return ahorcadoDao.Repeated(letter, lettersRepeated);
        }
        public bool CountLetters(List<string> combinedList)
        {
            return ahorcadoDao.CountLetters(combinedList);
        }
        public bool UploadScore(int attemp, string email)
        {
            return ahorcadoDao.UploadScore(attemp, email);
        }
        public DataTable BestScores()
        {
            return ahorcadoDao.BestScores();
        }

        public bool InsertUser(User oUser)
        {
            return oRegister.InsertUser(oUser);
        }
        public int Session(string email)
        {
            return oLogin.Session(email);
        }

    }
}
