using GCommon;

namespace COW;

public class UGCTimelineEditRule : CSVBaseData
{
	public string TipName;

	public string TipDesc;

	public int TipID;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
