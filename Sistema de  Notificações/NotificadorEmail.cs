public class NotificadorEmail : INotificador
{
    public string FormatoSuportado => "Email";

    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        if (ValidarDestinatario(destinatario))
        {
            Console.WriteLine($"Enviando e-mail para {destinatario}: {mensagem}");
        }
        else
        {
            Console.WriteLine("Destinatário de e-mail inválido.");
        }
    }

    public bool ValidarDestinatario(string destinatario)
    {
        return destinatario.Contains("@");
    }
}
