public class GerenciadorNotificacoes
{
    private List<INotificador> _notificadores = new List<INotificador>();

    public void RegistrarNotificador(INotificador notificador)
    {
        _notificadores.Add(notificador);
    }

    public void EnviarNotificacoes(string destinatario, string mensagem)
    {
        foreach (var notificador in _notificadores)
        {
            if (notificador.ValidarDestinatario(destinatario))
            {
                notificador.EnviarNotificacao(destinatario, mensagem);
            }
            else
            {
                Console.WriteLine($"Destinatário inválido para o formato {notificador.FormatoSuportado}.");
            }
        }
    }
}
