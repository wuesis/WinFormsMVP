using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDominio
{
    public class Departament : IDepartament
    {
        public int IdDepartamento { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se necesita un nombre para el departemento.")]
        [StringLength(20, ErrorMessage = "El departamento debe tener un nombre mas grande.", MinimumLength = 2)]
        public string NombreDepartamento { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se necesita el telefono del departemento.")]
        [StringLength(10, ErrorMessage = "El numero debe ser a 10 digitos.", MinimumLength = 10)]
        [RegularExpression(@"^([\+\d{1,2}\s]+\d{10})$")]
        public string NumeroTelefono { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se necesita el telefono del departemento.")]
        [RegularExpression(@"^[0-9a-zA-Z_\-\.]+)@([0-9a-zA-Z_\-\.])\.([a-zA-Z]{2,5})$")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se necesita el telefono del departemento.")]
        public string Ciudad { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Se necesita saber el estado donde se ubica el departemento.")]
        public string Estado { get; set; }

    }
}
