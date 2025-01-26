using OrientacaoObjetos.NotificationContext;

namespace OrientacaoObjetos.SharedContext;

public abstract class Base : Notifiable
{
    public Guid Id { get; set; } = Guid.NewGuid(); // SPOF: Single point of failure
}
