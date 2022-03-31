using CapaDeDominio;
using CapaDeServicio.ServiciosEnComun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeServicio.ServicioDepartamento
{
    public  class ServicioDepartamento: IDepartamentService, IDepartamentoRepository
    {
        private IDepartamentoRepository _departamentoRepository;

        private IRevisionModeloDeDatos _revisionModeloDeDatos;

        public ServicioDepartamento(IDepartamentoRepository departamentoRepository, IRevisionModeloDeDatos revisionModeloDeDatos)
        {
            _departamentoRepository = departamentoRepository;
            _revisionModeloDeDatos = revisionModeloDeDatos;
        }

        public void Add(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Departamento> GetAll()
        {
            throw new NotImplementedException();
        }

        public Departamento GetDepartamentById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public void Update(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public void ValidateModel(Departamento departamento)
        {
            throw new NotImplementedException();
        }
    }
}
