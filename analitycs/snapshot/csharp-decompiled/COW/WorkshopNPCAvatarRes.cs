using GCommon;

namespace COW;

public class WorkshopNPCAvatarRes : CSVBaseData
{
	public int ID;

	public string NameKey;

	public int Type;

	public string IconRes;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
