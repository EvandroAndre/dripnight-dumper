using System.Collections.Generic;
using GCommon;

namespace COW;

internal class IceWallMakerData : CSVBaseData
{
	public uint Level;

	public ResourceID IceWallMakerIcon;

	public uint IceWallLimited;

	public uint IceWallChargeMax;

	public uint IceWallChargeSpeed;

	public uint NeedExp;

	public string Region;

	private static Dictionary<string, IceWallMakerData> CurrGameIceWallMakerDatas;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public static void LoadCurrGameCfgDatas()
	{
	}

	public static IceWallMakerData GetIceWallMakerData(int level)
	{
		return null;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}
