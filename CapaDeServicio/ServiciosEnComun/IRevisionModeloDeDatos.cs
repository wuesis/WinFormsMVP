namespace CapaDeServicio.ServiciosEnComun
{
    public interface IRevisionModeloDeDatos
    {
        void ValidaModelo<TDomainModel>(TDomainModel domainModel);
    }
}