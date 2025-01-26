﻿using OrientacaoObjetos.ContentContext.Enums;
using OrientacaoObjetos.SharedContext;

namespace OrientacaoObjetos.ContentContext;

public class Lecture : Base
{
    public int Order { get; set; }
    public string? Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
}
