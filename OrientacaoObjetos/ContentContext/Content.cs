﻿namespace OrientacaoObjetos.ContentContext;

public abstract class Content(string title, string url)
{
    public Guid Id { get; set; } = Guid.NewGuid(); // SPOF: Single point of failure
    public string? Title { get; set; } = title;
    public string? Url { get; set; } = url;
}
