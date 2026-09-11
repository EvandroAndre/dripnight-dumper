using GCommon;

namespace COW;

public class VoucherData : CSVBaseData
{
	public uint ID;

	public uint VoucherType;

	public uint DeductItemType;

	public uint DeductItemID;

	public uint Maxmount;

	public uint Deductmount;

	public bool isUse;

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
