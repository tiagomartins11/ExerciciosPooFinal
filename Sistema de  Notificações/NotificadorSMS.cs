public class NotificadorSMS : INotificador
{
    public string FormatoSuportado => "SMS";

    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        if (ValidarDestinatario(destinatario))
        {
            Console.WriteLine($"Enviando SMS para {destinatario}: {mensagem}");
        }
        else
        {
            Console.WriteLine("Destinatário de SMS inválido.");
        }
    }

    public bool ValidarDestinatario(string destinatario)
    {
        return destinatario.Length == 10 && destinatario.All(char.IsDigit);
    }
}
