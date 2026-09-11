using GCommon;

namespace COW;

public class WorkShopCollaborationResources : CSVBaseData
{
	public enum ETriggerType
	{
		Lobby = 1,
		UGCCenter
	}

	public enum ECollaborationResType
	{
		Object = 1,
		SkyEnvBox
	}

	public uint ActivityId;

	public uint ItemID;

	public uint ResType;

	public string ResID;

	public string ItemsDescKey;

	public string ResourcesPopupKey;

	public uint TriggerType;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
