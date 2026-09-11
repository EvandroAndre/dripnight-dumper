using GCommon;

namespace COW;

public class ClothesTriggerData : CSVBaseData, IGetId
{
	public uint[] TriggerID;

	public uint[] MultiStateTriggerID;

	public float MultiStateTransTime;

	public uint MultiState;

	public uint ID;

	public ResourceID IngameFemaleSkeletonAnimation;

	public ResourceID IngameMaleSkeletonAnimation;

	public ResourceID FemaleSkeletonAnimation;

	public ResourceID MaleSkeletonAnimation;

	public bool HideResidentEffect;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
