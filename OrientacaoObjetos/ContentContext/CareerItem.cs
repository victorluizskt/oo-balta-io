using OrientacaoObjetos.NotificationContext;
using OrientacaoObjetos.SharedContext;

namespace OrientacaoObjetos.ContentContext;

public class CareerItem : Base
{
    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Course? Course { get; set; }

    public CareerItem(int order, string title, string description, Course? course)
    {
        Order = order;
        Title = title;
        Description = description;

        if (course != null)
            Course = course;
        else
            AddNotification(new Notification("Course", "Invalid course."));
    }
}