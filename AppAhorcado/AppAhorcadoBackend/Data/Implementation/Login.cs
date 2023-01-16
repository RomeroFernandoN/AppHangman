using AppAhorcado.AppAhorcadoBackend.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppAhorcado.AppAhorcadoBackend.Data.Implementation
{
    class Login : ILogin
    {
        public int Session(string email)
        {
            List<Parámetro> lstParameters = new List<Parámetro>();
            Parámetro parameterEmail = new Parámetro("@EMAIL", email);
            lstParameters.Add(parameterEmail);
            return HelperDB.ObtenerInstancia().ConsultaEscalarConParametros("SP_LOGIN", "@AUX", lstParameters);
        }
    }
}
