using Flunt.Notifications;
using Locatudo.Compartilhado.Executores.Comandos;

namespace Locatudo.Dominio.Executores.Comandos
{
    public class ComandoCadastrarEquipamento : Notifiable<Notification>, IComandoExecutor
    {
        public string Nome { get; set; }

        public ComandoCadastrarEquipamento()
        {
        }

        public ComandoCadastrarEquipamento(string nome)
        {
            Nome = nome;
        }

        public bool Validar()
        {
            return IsValid;
        }
    }
}
