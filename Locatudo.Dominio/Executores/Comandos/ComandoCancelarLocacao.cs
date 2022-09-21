using Flunt.Notifications;
using Locatudo.Compartilhado.Executores.Comandos;
using Locatudo.Dominio.Executores.Comandos.Contratos;

namespace Locatudo.Dominio.Executores.Comandos
{
    public class ComandoCancelarLocacao : Notifiable<Notification>, IComandoExecutor
    {
        public Guid IdLocacao { get; set; }

        public ComandoCancelarLocacao()
        {
        }

        public ComandoCancelarLocacao(Guid idLocacao)
        {
            IdLocacao = idLocacao;
        }

        public bool Validar()
        {
            AddNotifications(new ContratoComandoCancelarLocacao(this));

            return IsValid;
        }
    }
}
