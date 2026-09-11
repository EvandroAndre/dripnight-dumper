using GCommon;

namespace COW;

public class WorkShopShortLinkData : CSVBaseData
{
	public string Flag;

	public string ValueType;

	public string OriginalValue;

	public string MappedValue;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
