using GCommon;

namespace COW;

public class WorkshopNPCRigName : CSVBaseData
{
	public string BoneName;

	public string BoneNameKet;

	public int Owner;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
