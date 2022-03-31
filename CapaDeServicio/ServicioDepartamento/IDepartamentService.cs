using CapaDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeServicio.ServicioDepartamento
{
    interface IDepartamentService
    {
        void ValidateModel(Departamento departamento);
    }
}
