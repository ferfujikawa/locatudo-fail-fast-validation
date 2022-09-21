using Flunt.Validations;

namespace Locatudo.Dominio.Executores.Comandos.Contratos
{
    public class ContratoComandoAprovarLocacao : Contract<ComandoAprovarLocacao>
    {
        public ContratoComandoAprovarLocacao(ComandoAprovarLocacao comando)
        {
            Requires()
                .IsNotNull(comando.IdLocacao, "IdLocacao", "É necessário informar o Id da locação que se pretende aprovar")
                .IsNotNull(comando.IdAprovador, "IdAprovador", "É necessário informar o Id do funcionário que está aprovando a locacação");
        }
    }
}
