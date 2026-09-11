using GCommon;

namespace COW;

public class PayItemDisplay_iOS_Data : CSVBaseData
{
	public string ItemIdentifier;

	public string CostString;

	public string CostCurrency;

	public float CostAmount;

	public int VirtualCurrencyAmount;

	public int BonusVirtualCurrencyAmount;

	public int FirstTimeBonusVirtualCurrencyAmount;

	public string CdnUrlKey;

	public string ResourceName;

	public ResourceID ResourceId;

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
