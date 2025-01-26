using OrientacaoObjetos.SharedContext;

namespace OrientacaoObjetos.ContentContext;

public class Module : Base
{
    public int Order { get; set; }
    public string? Title { get; set; }
    public IList<Lecture> Lectures { get; set; } = [];
}
