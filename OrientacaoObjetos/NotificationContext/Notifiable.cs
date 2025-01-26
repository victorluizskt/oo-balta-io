namespace OrientacaoObjetos.NotificationContext;

public abstract class Notifiable
{
    public bool IsValid => Notifications.Count != 0;   
    public List<Notification> Notifications { get; set; } = [];

    public void AddNotification(Notification notification)
    {
        Notifications.Add(notification);
    }

    public void AddNotifications(IList<Notification> notifications)
    {
        Notifications.AddRange(notifications);
    }
}
