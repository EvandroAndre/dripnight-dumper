using GCommon;

namespace COW;

public class WeaponSkinUpgradeInfoData : CSVBaseData, IGetId
{
	public WeaponSkinFeature FeatureInThisLevel;

	public ResourceID Icon;

	public string TitleKey;

	public string TitleDesc;

	public int EvoGun1;

	public int EvoGun2;

	public int EvoMelee;

	public int EvoGun2List;

	public WeaponSkinFeatureShowStyle Style;

	public ResourceID PrivilegeIcon;

	public bool[] IsItemDescShow;

	public int DescShowPrivilegeSortId;

	public string TipsKey;

	public int IsNew;

	public bool IsEvoGunNewPrivilege;

	public uint featureShowType;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
