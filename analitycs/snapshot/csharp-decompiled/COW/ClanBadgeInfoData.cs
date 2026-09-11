using GCommon;

namespace COW;

public class ClanBadgeInfoData : CSVBaseData, IGetId
{
	public uint BadgeId;

	public uint BadgeType;

	public string BadgeName;

	public string BadgeGetWay;

	public string ResourceId;

	public string SmallResourceId;

	public string IngameResourceId;

	public string SmallIngameResourceId;

	public uint IsDefault;

	public uint UnlockCdt;

	public uint UnlockCdtValue;

	public uint FrameReplaceId;

	public uint IsNew;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
