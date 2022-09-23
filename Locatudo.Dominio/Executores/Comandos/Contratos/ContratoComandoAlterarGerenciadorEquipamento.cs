using Flunt.Validations;
using Locatudo.Dominio.Executores.Comandos.Entradas;

namespace Locatudo.Dominio.Executores.Comandos.Contratos
{
    public class ContratoComandoAlterarGerenciadorEquipamento : Contract<ComandoAlterarGerenciadorEquipamento>
    {
        public ContratoComandoAlterarGerenciadorEquipamento(ComandoAlterarGerenciadorEquipamento comando)
        {
            Requires()
                .IsNotNull(comando.Id, "IdEquipamento", "É necessário informar o IdEquipamento do equipamento para alterar seu gerenciador")
                .IsNotNull(comando.IdDepartamento, "IdDepartamento", "É necessário informar o IdEquipamento do novo gerenciador do equipamento");
        }
    }
}
