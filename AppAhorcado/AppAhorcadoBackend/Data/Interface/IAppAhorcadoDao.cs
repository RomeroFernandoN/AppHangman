using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AppAhorcado.AppAhorcadoBackend.Interface
{
    interface IAppAhorcadoDao
    {
        void ChangeImage(int attempt, PictureBox picBox);
        string AvailableWords();
        int AccountantLetters(int amount, string letter, List<char> list);
        List<(int, List<string>, bool)> Repeated(string letter, List<string> lettersRepeated);
        bool CountLetters(List<string> combinedList);

        bool UploadScore(int attemp, string email);
        DataTable BestScores();
    }
}
