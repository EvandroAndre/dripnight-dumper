using GCommon;

namespace COW;

public class UGCSelectionPageCDN : CSVBaseData
{
	public string Language;

	public string CDNType;

	public string CDN;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
