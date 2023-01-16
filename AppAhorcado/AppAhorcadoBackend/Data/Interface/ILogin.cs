using System;
using System.Collections.Generic;
using System.Text;

namespace AppAhorcado.AppAhorcadoBackend.Data.Interface
{
    interface ILogin
    {
        int Session(string email);
    }
}
