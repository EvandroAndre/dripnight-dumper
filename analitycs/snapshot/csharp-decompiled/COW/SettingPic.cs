using GCommon;

namespace COW;

public class SettingPic : CSVBaseData
{
	public uint Id;

	public uint State;

	public string CDN;

	public string AdditionalDesc;

	public string AdditionalDescInPic;

	public float XOffSet;

	public float YOffset;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
