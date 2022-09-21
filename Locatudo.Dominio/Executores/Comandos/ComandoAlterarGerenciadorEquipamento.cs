using Flunt.Notifications;
using Locatudo.Compartilhado.Executores.Comandos;

namespace Locatudo.Dominio.Executores.Comandos
{
    public class ComandoAlterarGerenciadorEquipamento : Notifiable<Notification>, IComandoExecutor
    {
        public Guid Id { get; set; }
        public Guid IdDepartamento { get; set; }

        public ComandoAlterarGerenciadorEquipamento()
        {
        }

        public ComandoAlterarGerenciadorEquipamento(Guid id, Guid idDepartamento)
        {
            Id = id;
            IdDepartamento = idDepartamento;
        }

        public bool Validar()
        {
            return IsValid;
        }
    }
}
