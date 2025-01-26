namespace OrientacaoObjetos.ContentContext;

public class Course : Content
{
    public string? Tag { get; set; }
    public IList<Module> Modules { get; set; } = [];
}

public class Module
{
    public int Order { get; set; }
    public string? Title { get; set; }
    public IList<Lecture> Lectures { get; set; } = [];
}

public class Lecture
{
    public int Order { get; set; }
    public string? Title { get; set; }
}
