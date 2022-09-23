using Flunt.Validations;
using Locatudo.Dominio.Executores.Comandos.Entradas;

namespace Locatudo.Dominio.Executores.Comandos.Contratos
{
    public class ContratoComandoAprovarLocacao : Contract<ComandoAprovarLocacao>
    {
        public ContratoComandoAprovarLocacao(ComandoAprovarLocacao comando)
        {
            Requires()
                .IsNotNull(comando.IdLocacao, "IdLocacao", "É necessário informar o IdEquipamento da locação que se pretende aprovar")
                .IsNotNull(comando.IdAprovador, "IdAprovador", "É necessário informar o IdEquipamento do funcionário que está aprovando a locacação");
        }
    }
}
