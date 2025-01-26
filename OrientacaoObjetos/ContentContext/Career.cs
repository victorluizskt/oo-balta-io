namespace OrientacaoObjetos.ContentContext;

public class Career : Content
{
    public int Courses { get; set; }
    public IList<CareerItem> Careers { get; set; } = [];
    public int TotalCourses => Careers.Count; // Expression body
}