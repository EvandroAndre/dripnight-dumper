using System;
using proto;

namespace COW;

public class FlightBaseInfo : CollectionBaseInfo, IComparable<FlightBaseInfo>
{
	public FlightData flight_data;

	public FlightBaseInfo()
	{
	}

	public FlightBaseInfo(uint itemid)
	{
	}

	public static implicit operator FlightBaseInfo(Item it)
	{
		return null;
	}

	public static implicit operator FlightBaseInfo(SkyboardData data)
	{
		return null;
	}

	public override uint GetCurrentId()
	{
		return 0u;
	}

	public int CompareTo(FlightBaseInfo other)
	{
		return 0;
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return 0u;
	}
}
