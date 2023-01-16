using AppAhorcado.AppAhorcadoBackend.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppAhorcado.AppAhorcadoBackend.Service
{
    class FactoryServiceImp : FactoryService
    {
        public override IService CreateService()
        {
            return new Implementation.Service();
        }
    }
}
