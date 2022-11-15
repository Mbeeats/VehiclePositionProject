using System;

namespace VehiclePositionProject
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Starting Location Finder Application");
      PositionFinder positionFinder = new PositionFinder();
      positionFinder.LoadData();
      Console.WriteLine("Process Position Finder");
      positionFinder.FindClosestsPoition();
    }

  }
}
