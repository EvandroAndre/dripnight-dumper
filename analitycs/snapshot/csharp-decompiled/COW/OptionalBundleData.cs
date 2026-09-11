using GCommon;
using proto;

namespace COW;

public class OptionalBundleData : CsvDataIndexedReading
{
	public uint ID;

	public uint Order;

	public EInventory.AwardType AwardType;

	public uint AwardID;

	public uint AwardNum;

	public uint AwardTime;

	public EInventory.AwardType ReturnType;

	public uint ReturnID;

	public uint ReturnNum;

	public bool IsPreview;

	public uint PreviewAvatar;

	public uint DefaultMaleRole;

	public uint DefaultFemaleRole;

	public uint OriginalPrice;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override string[] GetHeadColNames()
	{
		return null;
	}

	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
