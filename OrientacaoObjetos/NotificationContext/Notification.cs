namespace OrientacaoObjetos.NotificationContext;

public sealed class Notification(string property, string message)
{
    public string Property { get; set; } = property;
    public string Message { get; set; } = message;
}
