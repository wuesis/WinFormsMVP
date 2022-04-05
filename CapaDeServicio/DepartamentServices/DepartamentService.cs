using CapaDeDominio;
using CapaDeServicio.ServiciosEnComun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeServicio.ServicioDepartamento
{
    public  class ServicioDepartamento: IDepartamentServices, IDepartamentRepository
    {
        private IDepartamentRepository _departamentoRepository;

        private IRevicionDataAnotations _revisionModeloDeDatos;

        public ServicioDepartamento(IDepartamentRepository departamentoRepository, IRevicionDataAnotations revisionModeloDeDatos)
        {
            _departamentoRepository = departamentoRepository;
            _revisionModeloDeDatos = revisionModeloDeDatos;
        }

        public void Add(Departament departamento)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Departament> GetAll()
        {
            throw new NotImplementedException();
        }

        public Departament GetDepartamentById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Departament departamento)
        {
            throw new NotImplementedException();
        }

        public void Update(Departament departamento)
        {
            throw new NotImplementedException();
        }

        public void ValidateModel(Departament departamento)
        {
            throw new NotImplementedException();
        }
    }
}
