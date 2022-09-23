using Flunt.Validations;
using Locatudo.Dominio.Executores.Comandos.Entradas;

namespace Locatudo.Dominio.Executores.Comandos.Contratos
{
    public class ContratoComandoCadastrarEquipamento : Contract<ComandoCadastrarEquipamento>
    {
        public ContratoComandoCadastrarEquipamento(ComandoCadastrarEquipamento comando)
        {
            Requires()
                .IsNotNull(comando.Nome, "Nome", "É necessário informar um nome para o equipamento")
                .IsGreaterOrEqualsThan(comando.Nome.Length, 3, "O nome do equipamento precisa conter no mínimo 3 caracteres");
        }
    }
}
