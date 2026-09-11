using GCommon;
using UnityEngine;

namespace COW;

public class SFRoleplayPlayerAbilityConfig : CSVBaseData, IGetId
{
	public Color32 RoleLabelColor;

	public string RoleIcon;

	public string NotificationIcon;

	public string NotificationBG;

	public string NotificationAnimation;

	public string EnergyNormalIcon;

	public string EnergyActivatedIcon;

	public string EnergyProfessionIcon;

	public string TeamRoleIcon;

	public ResourceID ChangeRoleVFX;

	public ResourceID ChangeRoleSound;

	public string ChangeRoleUIFXAnimation;

	public string Params;

	public string RoleName;

	public string RoleDesc;

	public string RoleSummary;

	public string LabelColor;

	public string NotificationDesc;

	public string RoleIcones;

	public uint[] GroupMode;

	public uint[] GameMode;

	public ResourceID CabinProjectionRes;

	public uint MaxEnergy;

	public uint Id;

	public uint EnergyConsumption;

	public uint Type;

	public uint MaxCount;

	public ResourceID GhostCircleVFX;

	public override void PostDeserializeData()
	{
	}

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

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
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
