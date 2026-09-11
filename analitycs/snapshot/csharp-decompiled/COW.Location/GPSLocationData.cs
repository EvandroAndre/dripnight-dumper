using System;
using UnityEngine;

namespace COW.Location;

[Serializable]
public class GPSLocationData
{
	public double latitude;

	public double longitude;

	public float accuracy;

	public double timestamp;

	public static GPSLocationData FromLatLon(double lat, double lon, double time, float acc)
	{
		return null;
	}

	public static GPSLocationData FromLocationInfo(LocationInfo locationInfo)
	{
		return null;
	}

	public bool IsValid()
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
