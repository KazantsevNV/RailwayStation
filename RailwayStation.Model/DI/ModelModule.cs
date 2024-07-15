using Ninject.Modules;

namespace RailwayStation.Model
{
    public class ModelModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IStation>().To<Station>();
        }
    }
}
