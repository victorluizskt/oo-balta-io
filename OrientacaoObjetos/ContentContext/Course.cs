using OrientacaoObjetos.ContentContext.Enums;

namespace OrientacaoObjetos.ContentContext;

public class Course(string title, string url) : Content(title, url)
{
    public string? Tag { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
    public IList<Module> Modules { get; set; } = [];
}