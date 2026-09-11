using GCommon;

namespace COW;

public class UGCWhiteListWordRegionControlData : CSVBaseData
{
	public string Region;

	public string[] Languages;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
