using System;
using System.Collections.Generic;

namespace Test.models;

public abstract class Element
{
    public int ID { get; set; }
    public int Number { get; set; }
    public string Identifier { get; set; }
    public string TestString { get; set; }
    public List<string> ListOfStrings { get; set; }
}
