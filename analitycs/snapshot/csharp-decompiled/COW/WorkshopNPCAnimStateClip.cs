using GCommon;

namespace COW;

public class WorkshopNPCAnimStateClip : CSVBaseData
{
	public string StateName;

	public string OwnerKey;

	public string StateNameKey;

	public string AnimResName;

	public string ClipName;

	public int SubItemType;

	public ResourceID IconRes;

	public int Owner;

	public int Order;

	public bool IsObsolote;

	public bool CraftlandShowControl;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
