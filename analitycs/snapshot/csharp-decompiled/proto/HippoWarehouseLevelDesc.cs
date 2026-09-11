using System.Collections.Generic;

namespace proto;

public class HippoWarehouseLevelDesc
{
	public uint level;

	public uint capacity;

	public List<HippoCostDesc> costs;
}
