using OrientacaoObjetos.ContentContext;

var articles = new List<Article>
{
    new("Artigo sobre OOP", "orientacao-objetos"),
    new("Artigo sobre C#", "orientacao-objetos"),
    new("Artigo sobre .NET", "orientacao-objetos")
};

foreach (var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);
}