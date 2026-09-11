using GCommon;

namespace COW;

public class WorkshopMapExposureRank : CSVBaseData
{
	public string LabelUI;

	public string TipKey;

	public string TitleKey;

	public int ExposureRank;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
