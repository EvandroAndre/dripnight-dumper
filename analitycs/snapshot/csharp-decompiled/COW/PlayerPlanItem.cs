using proto;

namespace COW;

public class PlayerPlanItem : BasicLoadoutPlanItem
{
	public int PlanIndex;

	public EProfile.EquipSource[] SkillSourceType;

	public uint AutoMode;

	public uint PetId;

	public bool IsSelected;

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	private bool IsV2Equals(uint value1, uint value2)
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return 0;
	}

	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return false;
	}
}
