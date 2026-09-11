using GCommon;

namespace COW;

public class DMAPolicyLinkData : CSVBaseData
{
	public string CountryCode;

	public string Language;

	public string ContentLinkKey1;

	public string ContentLinkUrl1;

	public string ContentLinkKey2;

	public string ContentLinkUrl2;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
