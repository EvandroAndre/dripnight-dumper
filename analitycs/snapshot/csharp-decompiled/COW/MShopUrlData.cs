using GCommon;

namespace COW;

public class MShopUrlData : CSVBaseData
{
	public uint ProcutionID;

	public int ServerID;

	public string AndroidMSHOPUrl;

	public string AndroidMaxMSHOPUrl;

	public string IOSMSHOPUrl;

	public string IOSMaxMSHOPUrl;

	public string AndroidThirdPartyMSHOPUrl;

	public string HuaWeiMSHOPUrl;

	public string SamsungMSHOPUrl;

	public override string GetPrimaryKey()
	{
		return null;
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
