using OopTextTransformations.Library;
using OopTextTransformations.Library.Rules;
using System;

namespace OopTransformations.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world!";

            ProcessingEngine engine = new ProcessingEngine(
                new StringInsertRule(0, "TeSt "),
                new StringReplaceRule("world", "C#"),
                new StringRemoveRule("Hello "),
                new StringUpperCaseRule(),
                new StringLowerCaseRule(),);

            string transformed = engine.Transform(text);

            Console.WriteLine($"Original text= {text}");
            Console.WriteLine($"Transformed text= {transformed}");
        }
    }
}
