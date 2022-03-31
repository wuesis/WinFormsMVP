using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeServicio.ServiciosEnComun
{
    public class ModeloRevisionDeDatos : IRevisionModeloDeDatos
    {
        public void ValidaModelo<TDomainModel>(TDomainModel domainModel)
        {
            ICollection<ValidationResult> validationResultsList = new List<ValidationResult>();

            ValidationContext validationContext = new ValidationContext(domainModel, null, null);

            StringBuilder stringBuilder = new StringBuilder();

            if (!Validator.TryValidateObject(domainModel, validationContext, validationResultsList, true))
            {

                foreach (ValidationResult item in validationResultsList)
                {
                    stringBuilder.Append(item.ErrorMessage).AppendLine();
                }
            }
            if (validationResultsList.Count > 0)
            {
                throw new ValidationException(stringBuilder.ToString());
            }
        }
    }
}
