using GCommon;

namespace COW;

public class PayWindowSubImages_Android_Data : CSVBaseData
{
	public int ID;

	public string IAPCdnUrlKey;

	public string AdCdnUrlKey;

	public string IAPResourceName;

	public string AdResourceName;

	public ResourceID IAPResourceId;

	public ResourceID AdResourceId;

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
