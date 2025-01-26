using OrientacaoObjetos.ContentContext;
using OrientacaoObjetos.ContentContext.Enums;

var course = new Course
{
    Level = EContentLevel.Fundamental
};

foreach (var item in course.Modules)
{
    Console.WriteLine(item);
}