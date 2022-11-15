using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclePositionProject
{
  public static class Utilities
  {

    internal static DateTime GetDTCTime(ulong nanoseconds, ulong ticksPerNanosecond)
    {
      DateTime pointOfReference = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc);
      long ticks = (long)(nanoseconds / ticksPerNanosecond);
      return pointOfReference.AddTicks(ticks);
    }

    internal static DateTime GetDTCTime(ulong nanoseconds)
    {
      return GetDTCTime(nanoseconds, 100);
    }
  }

}
