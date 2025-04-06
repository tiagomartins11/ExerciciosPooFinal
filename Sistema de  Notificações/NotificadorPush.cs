public class NotificadorPush : INotificador
{
    public string FormatoSuportado => "Push";

    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        Console.WriteLine($"Enviando notificação push para {destinatario}: {mensagem}");
    }

    public bool ValidarDestinatario(string destinatario)
    {
        // No caso de push, validamos apenas se não está vazio
        return !string.IsNullOrWhiteSpace(destinatario);
    }
}
