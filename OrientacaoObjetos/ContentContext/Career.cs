﻿namespace OrientacaoObjetos.ContentContext;

public class Career(string title, string url) : Content(title, url)
{
    public int Courses { get; set; }
    public IList<CareerItem> Careers { get; set; } = [];
    public int TotalCourses => Careers.Count; // Expression body
}