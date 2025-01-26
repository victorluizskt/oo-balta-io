// See https://aka.ms/new-console-template for more information
using OrientacaoObjetos.ContentContext;

Console.WriteLine("Hello, World!");

var course = new Course();

foreach(var item in course.Modules)
{
    Console.WriteLine(item);
}