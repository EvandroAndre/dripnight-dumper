using GCommon;

namespace COW;

public class AvatarSuitData : CSVBaseData, IGetId
{
	public uint SuitID;

	public string SuitName;

	public ResourceID SuitIcon;

	public uint HeadSlotItemID;

	public uint ChestSlotItemID;

	public uint LegsSlotItemID;

	public uint FeetSlotItemID;

	public uint HeadAdditiveItemID;

	public uint AvatarID;

	public bool IsDefault;

	public ResourceID SuitAnimation;

	public uint SkillID;

	public ResourceID SuitAnimationEffect;

	public uint[] GetClothesIDs()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
