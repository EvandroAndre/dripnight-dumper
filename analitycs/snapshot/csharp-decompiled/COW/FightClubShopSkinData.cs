using GCommon;

namespace COW;

public class FightClubShopSkinData : CSVBaseData, IGetId
{
	public uint SkinType;

	public ResourceID Additional;

	public string TitleBg;

	public uint[] TitleLabelColor;

	public float[] TitleLabelOffset;

	public uint TitleEffect;

	public string CloseBtn;

	public float[] CloseBtnLocalPos;

	public string BuyBtn;

	public uint[] BuyLabelColor;

	public uint[] SkinnedItemFilters;

	public string[] SkinnedItemCategoryBullet;

	public string[] SkinnedItemCategoryKey;

	public ResourceID[] SkinnedItemAdditional;

	public ResourceID OpenSoundResID;

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
