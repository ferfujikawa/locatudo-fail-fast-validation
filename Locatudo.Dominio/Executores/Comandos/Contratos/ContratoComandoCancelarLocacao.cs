using Flunt.Validations;
using Locatudo.Dominio.Executores.Comandos.Entradas;

namespace Locatudo.Dominio.Executores.Comandos.Contratos
{
    public class ContratoComandoCancelarLocacao : Contract<ComandoCancelarLocacao>
    {
        public ContratoComandoCancelarLocacao(ComandoCancelarLocacao comando)
        {
            Requires()
                .IsNotNull(comando.IdLocacao, "IdLocacao", "É necessário informar o IdEquipamento da locação que se pretende cancelar");
        }
    }
}
