using GCommon;

namespace COW;

public class WorkshopModerationViolationTypeData : CSVBaseData, IGetId
{
	public uint TypeID;

	public string TypeName;

	public string TypeTransify;

	public uint GetId()
	{
		return 0u;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
