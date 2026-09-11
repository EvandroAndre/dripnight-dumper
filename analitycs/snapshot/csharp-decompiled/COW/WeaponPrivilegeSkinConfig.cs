using GCommon;

namespace COW;

public class WeaponPrivilegeSkinConfig : CSVBaseData, IGetId
{
	public uint SkinID;

	public ResourceID StackedKill;

	public ResourceID TeamWipeoutTextBG;

	public ResourceID KillerNameBG;

	public ResourceID TeamWipeOutIcon;

	public ResourceID QuadraHeadShootKillIcon;

	public ResourceID QuadraKillIcon;

	public ResourceID TripleHeadShootKillIcon;

	public ResourceID TripleKillIcon;

	public ResourceID DoubleHeadShootKillIcon;

	public ResourceID DoubleKillIcon;

	public ResourceID HeadShootKillIcon;

	public ResourceID KillIcon;

	public ResourceID KnockDownIcon;

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
