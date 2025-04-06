public interface INotificador
{
    void EnviarNotificacao(string destinatario, string mensagem);
    bool ValidarDestinatario(string destinatario);
    string FormatoSuportado { get; }
}
