using AppAhorcado.AppAhorcadoBackend.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AppAhorcado.AppAhorcadoBackend.Service.Interface
{
    public interface IService
    {
        void ChangeImage(int attempt, PictureBox picBox);
        string AvailableWords();
        int AccountantLetters(int amount, string letter, List<char> list);
        List<(int, List<string>, bool)> Repeated(string letter, List<string> lettersRepeated);
        bool CountLetters(List<string> combinedList);
        bool UploadScore(int attemp, string email);
        DataTable BestScores();
        bool InsertUser(User oUser);
        int Session(string email);
    }
}
