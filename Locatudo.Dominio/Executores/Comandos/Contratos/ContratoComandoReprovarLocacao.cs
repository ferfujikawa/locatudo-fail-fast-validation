using Flunt.Validations;

namespace Locatudo.Dominio.Executores.Comandos.Contratos
{
    public class ContratoComandoReprovarLocacao : Contract<ComandoReprovarLocacao>
    {
        public ContratoComandoReprovarLocacao(ComandoReprovarLocacao comando)
        {
            Requires()
                .IsNotNull(comando.IdLocacao, "IdLocacao", "É necessário informar o Id da locação que se pretende reprovar")
                .IsNotNull(comando.IdAprovador, "IdAprovador", "É necessário informar o Id do funcionário que está reprovando a locacação");
        }
    }
}
