using System.Collections.Generic;
using Autofac;

namespace LinkedList
{
    public class DIConfig
    {
        public IContainer Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<List<int>>().As<IList<int>>();
            builder.RegisterType<Starter>();

            var container = builder.Build();

            return container;
        }
    }
}
