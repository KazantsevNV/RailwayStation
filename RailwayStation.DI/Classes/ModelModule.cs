using Ninject.Modules;
using RailwayStation.Model;
using System;

namespace RailwayStation.DI
{
    public class ModelModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IStation>().To<Station>();
        }
    }
}
