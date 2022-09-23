using Flunt.Validations;
using Locatudo.Dominio.Executores.Comandos.Entradas;

namespace Locatudo.Dominio.Executores.Comandos.Contratos
{
    public class ContratoComandoCadastrarLocacao : Contract<ComandoCadastrarLocacao>
    {
        public ContratoComandoCadastrarLocacao(ComandoCadastrarLocacao comando)
        {
            var inicio = new DateTime(comando.Inicio.Year, comando.Inicio.Month, comando.Inicio.Day, comando.Inicio.Hour, 0, 0);

            Requires()
                .IsNotNull(comando.IdEquipamento, "IdEquipamento", "É necessário informar o IdEquipamento do equipamento que está sendo locado")
                .IsNotNull(comando.IdLocatario, "IdLocatario", "É necessário informar o IdEquipamento da usuário que está locando o equipamento")
                .IsNotNull(comando.Inicio, "Inicio", "É necessário informar o horário de início da locação")
                .IsGreaterThan(inicio, DateTime.Now, "Inicio", "Início da locação não pode ser no passado");
        }
    }
}
