using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VehiclePositionProject.Data
{
  public class DataReader
  {
    private readonly string FilePath;
    public List<Position> DataPositions { get; set; }

    public DataReader(string path)
    {
      FilePath = path;
      DataPositions = new List<Position>();
    }

    public void ReadFile()
    {
      var postionBytes = GetFileBytes();
      int offset = 0;
      while (offset < postionBytes.Length)
      {
        ProcessPosition(postionBytes, ref offset);
      }
    }

    private void ProcessPosition(byte[] postionBytes, ref int offset)
    {
      Position position = new Position
      {
        PositionId = BitConverter.ToInt32(postionBytes, offset)
      };
      offset += 4;
      StringBuilder stringBuilder = new StringBuilder();
      while (postionBytes[offset] != 0)
      {
        stringBuilder.Append((char)postionBytes[offset]);
        ++offset;
      }
      position.VehicleRegistration = stringBuilder.ToString();
      ++offset;
      position.Latitude = BitConverter.ToSingle(postionBytes, offset);
      offset += 4;
      position.Longitude = BitConverter.ToSingle(postionBytes, offset);
      offset += 4;
      position.RecordedTimeUTC = Utilities.GetDTCTime(BitConverter.ToUInt64(postionBytes, offset));
      offset += 8;
      DataPositions.Add(position);
    }

    public byte[] GetFileBytes()
    {
      byte[] postionBytes = null;
      if (File.Exists(FilePath))
      {
        postionBytes = File.ReadAllBytes(FilePath);
      }
      return postionBytes;
    }
  }
}
