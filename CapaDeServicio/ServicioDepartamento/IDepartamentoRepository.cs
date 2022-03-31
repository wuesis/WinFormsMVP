using CapaDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeServicio.ServicioDepartamento
{
    public interface IDepartamentoRepository
    {
        void Add(Departamento departamento);

        void Remove(Departamento departamento);

        void Update(Departamento departamento);

        IEnumerable<Departamento> GetAll();

        Departamento GetDepartamentById(int id);
    }
}
