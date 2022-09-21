using Flunt.Validations;

namespace Locatudo.Dominio.Executores.Comandos.Contratos
{
    public class ContratoComandoCancelarLocacao : Contract<ComandoCancelarLocacao>
    {
        public ContratoComandoCancelarLocacao(ComandoCancelarLocacao comando)
        {
            Requires()
                .IsNotNull(comando.IdLocacao, "IdLocacao", "É necessário informar o Id da locação que se pretende cancelar");
        }
    }
}
