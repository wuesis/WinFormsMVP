using CapaDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeServicio.ServicioDepartamento
{
    public interface IDepartamentRepository
    {
        void Add(Departament departamento);

        void Remove(Departament departamento);

        void Update(Departament departamento);

        IEnumerable<Departament> GetAll();

        Departament GetDepartamentById(int id);
    }
}
