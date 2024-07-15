namespace RailwayStation.PathFinder
{
    internal class Program
    {
        private static PathFinderPresenter _presenter = new PathFinderPresenter();
        static void Main(string[] args)
        {
            _presenter.Start();
        }
    }
}
