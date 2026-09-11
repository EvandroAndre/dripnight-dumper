using GCommon;

namespace COW;

public class EpicClothesTextData : CSVBaseData, IGetId
{
	public uint ClothesID;

	public string[] Conditions;

	public ResourceID WaitingRoomEffect;

	public ResourceID[] KillEffects;

	public ResourceID[] ActionEffects;

	public ResourceID[] InGameActionEffects;

	public ResourceID Flag;

	public ResourceID ToggleIcon;

	public uint ChickenSprite;

	public uint LootBox;

	public uint GetId()
	{
		return 0u;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public ResourceID GetEffect(ResourceID[] reses, int level)
	{
		return default(ResourceID);
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
