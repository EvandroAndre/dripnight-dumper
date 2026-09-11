using GCommon;

namespace COW;

public class SyncLoadResData : CSVBaseData
{
	public ResourceID ResID;

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
