using AppAhorcado.AppAhorcadoBackend.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AppAhorcado.AppAhorcadoBackend.Data.Interface
{
    interface IRegister
    {
        bool InsertUser(User oUser);
    }
}
