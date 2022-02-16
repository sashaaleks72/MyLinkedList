﻿using Autofac;

namespace LinkedList
{
    public class Program
    {
        public static void Main()
        {
            var config = new DIConfig();
            var container = config.Build();
            var starter = container.Resolve<Starter>();

            starter.Run();
        }
    }
}
