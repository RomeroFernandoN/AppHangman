using AppAhorcado.AppAhorcadoBackend.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppAhorcado.AppAhorcadoBackend.Service
{
    public abstract class FactoryService
    {
        public abstract IService CreateService();
    }
}
