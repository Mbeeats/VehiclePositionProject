using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehiclePositionProject.Data;

namespace VehiclePositionProject
{
  public class PositionFinder
  {
    internal static readonly GeoCoordinate[] TestCoordinates =  {
          new GeoCoordinate { Latitude = 34.54491f,    Longitude = -102.100845f},
          new GeoCoordinate { Latitude = 32.3455429f,  Longitude = -99.12312f},
          new GeoCoordinate { Latitude = 33.2342339f,  Longitude = -100.214127f},
          new GeoCoordinate { Latitude = 35.19574f,    Longitude = -95.3489f},
          new GeoCoordinate { Latitude = 31.89584f,    Longitude = -97.78957f},
          new GeoCoordinate { Latitude = 32.89584f,    Longitude = -101.789574f},
          new GeoCoordinate { Latitude = 34.1158371f,  Longitude = -100.225731f},
          new GeoCoordinate { Latitude = 32.33584f,    Longitude = -99.99223f},
          new GeoCoordinate { Latitude = 33.53534f,    Longitude = -94.79223f},
          new GeoCoordinate { Latitude = 32.2342339f,  Longitude = -100.222221f},
    };
    internal DataReader DataReader { get; private set; }

    public PositionFinder()
    {
      DataReader = new DataReader("Data/VehiclePositions.dat");
    }

    public void FindClosestsPoition()
    {
      var watch = new System.Diagnostics.Stopwatch();
      watch.Start();
      Parallel.ForEach(TestCoordinates, Coordinate =>
      {
        var closest = DataReader.DataPositions
                      .OrderBy(x => Pow2(Coordinate.Latitude - x.Latitude) + Pow2(Coordinate.Longitude - x.Longitude))
                      .FirstOrDefault();
        var positionCoord = new GeoCoordinate(closest.Latitude, closest.Longitude);
        var distance = Coordinate.GetDistanceTo(positionCoord);
        Console.WriteLine($"Coordinate {Coordinate.Latitude}, {Coordinate.Longitude}. Shortest distance :{distance} Latitude : {closest.Latitude} - Longitude : {closest.Longitude}");
      });
      Console.WriteLine($"end time : {watch.ElapsedMilliseconds} ms");
    }

    public void LoadData()
    {
      Console.WriteLine("Loading Data/VehiclePositions.dat file");
      var watch = new System.Diagnostics.Stopwatch();
      watch.Start();
      DataReader.ReadFile();
      watch.Stop();
      Console.WriteLine($"file reader time : {watch.ElapsedMilliseconds} ms");
      Console.WriteLine("Done loading positions from Data/VehiclePositions.dat file");
    }

    private static double Pow2(double x)
    {
      return x * x;
    }
  }
}
