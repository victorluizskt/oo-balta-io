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

var courses = new List<Course>();
var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCsharp = new Course("Fundamentos C#", "fundamentos-oop");
var courseDotNet = new Course("Fundamentos .net", "fundamentos-oop");

courses.Add(courseOOP);
courses.Add(courseCsharp);
courses.Add(courseDotNet);

var careers = new List<Career>();
var career = new Career("Especialista .NET", "especialista-dotnet");
var careerItem = new CareerItem(1, "Comece por aqui", "", null);
career.Careers.Add(careerItem);    
careers.Add(career);
