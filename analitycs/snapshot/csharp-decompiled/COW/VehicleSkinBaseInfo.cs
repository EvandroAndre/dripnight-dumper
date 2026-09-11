using System;
using proto;

namespace COW;

public class VehicleSkinBaseInfo : CollectionBaseInfo, IComparable<VehicleSkinBaseInfo>
{
	public VehicleSkinData vehicle_skin_data;

	public uint vehicle_id;

	public VehicleSkinBaseInfo(uint itemid)
	{
	}

	public static implicit operator VehicleSkinBaseInfo(Item it)
	{
		return null;
	}

	public static implicit operator VehicleSkinBaseInfo(VehicleSkinData data)
	{
		return null;
	}

	public override uint GetCurrentId()
	{
		return 0u;
	}

	public int CompareTo(VehicleSkinBaseInfo other)
	{
		return 0;
	}

	public uint _003C_003EiFixBaseProxy_GetCurrentId()
	{
		return 0u;
	}
}
