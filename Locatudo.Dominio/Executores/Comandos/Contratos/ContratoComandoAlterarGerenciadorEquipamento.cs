using Flunt.Validations;

namespace Locatudo.Dominio.Executores.Comandos.Contratos
{
    public class ContratoComandoAlterarGerenciadorEquipamento : Contract<ComandoAlterarGerenciadorEquipamento>
    {
        public ContratoComandoAlterarGerenciadorEquipamento(ComandoAlterarGerenciadorEquipamento comando)
        {
            Requires()
                .IsNotNull(comando.Id, "Id", "É necessário informar o Id do equipamento para alterar seu gerenciador")
                .IsNotNull(comando.IdDepartamento, "IdDepartamento", "É necessário informar o Id do novo gerenciador do equipamento");
        }
    }
}
