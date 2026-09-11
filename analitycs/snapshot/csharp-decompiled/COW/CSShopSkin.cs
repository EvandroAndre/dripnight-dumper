using GCommon;

namespace COW;

public class CSShopSkin : CSVBaseData, IGetId
{
	public float[] TitleLabelOffset;

	public string PowerUpAbilityPointLine;

	public string PowerUpPanalTipBg;

	public string PowerUpPanalAbilityPointLine;

	public string PowerUpPanalAbilityPointBg;

	public string PowerUpTipAbilityPoint;

	public string PowerUpTipAbilityPointLine;

	public string CloseBtn;

	public float[] CloseBtnLocalPos;

	public float[] CountDownLocalPos;

	public uint[] CountDownColor;

	public string PowerUpAbilityPointBg;

	public string BuyBtn;

	public ResourceID[] SkinnedItemAdditional;

	public string[] SkinnedItemCategoryKey;

	public string[] SkinnedItemCategoryBullet;

	public uint[] SkinnedItemFilters;

	public uint[] AskLabelColor;

	public string AskBtn;

	public uint[] BuyLabelColor;

	public string TitleBg;

	public uint[] TitleLabelColor;

	public ResourceID Additional;

	public ResourceID PowerUpShelterFX;

	public uint TitleEffect;

	public ResourceID PowerUpAbilityBgFX;

	public ResourceID PowerUpAbilityPointUnlockFX;

	public ResourceID PowerUpBG;

	public uint SkinType;

	public ResourceID OpenSoundResID;

	public ResourceID PowerUpAbilityPointFX;

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
