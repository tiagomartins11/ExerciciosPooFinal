class Program
{
    static void Main()
    {
        // Instanciando os notificadores concretos
        var notificadorEmail = new NotificadorEmail();
        var notificadorSMS = new NotificadorSMS();
        var notificadorPush = new NotificadorPush();

        // Criando o gerenciador de notificações
        var gerenciador = new GerenciadorNotificacoes();

        // Registrando os notificadores
        gerenciador.RegistrarNotificador(notificadorEmail);
        gerenciador.RegistrarNotificador(notificadorSMS);
        gerenciador.RegistrarNotificador(notificadorPush);

        // Enviando mensagens
        gerenciador.EnviarNotificacoes("exemplo@dominio.com", "Olá, esta é uma mensagem por e-mail.");
        gerenciador.EnviarNotificacoes("9876543210", "Olá, esta é uma mensagem SMS.");
        gerenciador.EnviarNotificacoes("usuarioPush", "Olá, esta é uma notificação push.");

        // Testando as interfaces explícitas
        var notificadorCombinado = new NotificadorCombinado();
        INotificadorEmail emailNotifier = notificadorCombinado;
        INotificadorSMS smsNotifier = notificadorCombinado;

        emailNotifier.EnviarNotificacaoEmail("usuario@dominio.com", "Mensagem enviada via interface de email.");
        smsNotifier.EnviarNotificacaoSMS("1234567890", "Mensagem enviada via interface de SMS.");
    }
}
