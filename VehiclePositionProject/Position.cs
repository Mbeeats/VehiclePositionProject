using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclePositionProject
{

  public class Position
  {
    public int PositionId { get; set; }
    public string VehicleRegistration { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public DateTime RecordedTimeUTC { get; set; }
  }
}
