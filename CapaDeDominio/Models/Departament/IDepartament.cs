namespace CapaDeDominio
{
    public interface IDepartament
    {
        string Ciudad { get; set; }
        string Email { get; set; }
        string Estado { get; set; }
        int IdDepartamento { get; set; }
        string NombreDepartamento { get; set; }
        string NumeroTelefono { get; set; }
    }
}