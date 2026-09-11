using GCommon;

namespace COW;

public class WorkshopBannerPopup : CSVBaseData
{
	public uint ChoiceId;

	public string PopupTitle;

	public string PopupDescription;

	public string DirectGoposKey;

	public uint[] TagID;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
