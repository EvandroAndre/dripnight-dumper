using GCommon;

namespace COW;

public class SparkPetConfig : CSVBaseData, IGetId
{
	public string PreviewCDN;

	public string PreviewLockedCDN;

	public ResourceID SparkAnimator;

	public ResourceID ShareIdle;

	public ResourceID CasualIdle;

	public ResourceID NormalIdle;

	public ResourceID SpecialAction;

	public ResourceID DeadAction;

	public ResourceID SleepAction;

	public ResourceID BuddyBeSummoned;

	public ResourceID BuddySummon;

	public ResourceID BuddyAction_3p;

	public ResourceID BuddyAction_1p;

	public ResourceID WalkAction;

	public ResourceID ActiveAction;

	public uint ID;

	public ResourceID SparkModel;

	public uint StageID;

	public uint SparkPetID;

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
