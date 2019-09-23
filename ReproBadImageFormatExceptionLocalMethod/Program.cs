using System;
using System.Collections.Generic;
public static class Program
{
    static void Main(string[] args)
    {
        var x = "hi";
        With(() =>
        {
            void explode<T>(IEnumerable<T> things) => UseInferred(things, p => { _ = x; });
            explode("sldkfjlksdfj");
        });
    }
    static void With(Action action) => action();
    static void UseInferred<T>(T value, Action<T> action)
    {
        action(value);
    }
}
