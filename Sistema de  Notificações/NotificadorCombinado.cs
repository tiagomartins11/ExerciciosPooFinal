public interface INotificadorEmail
{
    void EnviarNotificacaoEmail(string destinatario, string mensagem);
}

public interface INotificadorSMS
{
    void EnviarNotificacaoSMS(string destinatario, string mensagem);
}

public class NotificadorCombinado : INotificadorEmail, INotificadorSMS
{
    public void EnviarNotificacaoEmail(string destinatario, string mensagem)
    {
        Console.WriteLine($"Enviando e-mail (explicitamente) para {destinatario}: {mensagem}");
    }

    public void EnviarNotificacaoSMS(string destinatario, string mensagem)
    {
        Console.WriteLine($"Enviando SMS (explicitamente) para {destinatario}: {mensagem}");
    }
}
