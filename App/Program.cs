using System;
using AppLogger;
internal class Program
{
    private Logger logger = new Logger();
    private static void Main(string[] args)
    {
        Logger.Log("Tulosta tekstiä!");
        string text = "Tulostetaan lisää tekstiä";
        Logger.Log(text);
    }
}