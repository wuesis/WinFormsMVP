namespace CapaDeServicio.ServiciosEnComun
{
    public interface IRevicionDataAnotations
    {
        void ValidaModeloDataAnotations<TDomainModel>(TDomainModel domainModel);
    }
}