using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class AvatarSkillData : CSVBaseData
{
	private string _003CAwakenSkillDesc_003Ek__BackingField;

	private string[] _003CSkillDescColorParam_003Ek__BackingField;

	private string m_SkillIconHudStrNoBlood;

	private float _003CSkillCheckHackParameter_003Ek__BackingField;

	private ResourceID m_SkillIconNoBlood;

	private ResourceID m_SkillIcon;

	private ResourceID m_SkillIconHud;

	private ResourceID m_SkillIconHudNoBlood;

	public char SkillIconThemeColor;

	private uint _003CPriority_003Ek__BackingField;

	public const int InvalidWeaponSubType = -1;

	public const int InvalidWeaponType = -1;

	private List<Vector2> _003CSkillSubtypeList_003Ek__BackingField;

	private bool m_IsZombieMode;

	public string[] SkillDescParam;

	public string SkillParameter6;

	public ResourceID[] m_3p_ResourceIds;

	public ResourceID[] m_3p_Team_ResourceIds;

	public string SkillSummary;

	public ResourceID[] m_1p_ResourceIds;

	public uint[] Tag;

	public string SkillParameter7;

	public string ThemeColor;

	public string m_SkillIconHudStr;

	public string SkillType;

	public string SkillName;

	public string SkillDesc;

	public float SkillParameter4;

	public float SkillParameter2;

	public float SkillParameter5;

	public uint OriginSkillId;

	public uint SkillAvatarID;

	public uint SkillId;

	public int SkillLevel;

	public uint AwakenSkillId;

	public uint AttachedSkill;

	public int InGameChooseOrder;

	public float SkillParameter1;

	public float SkillParameter3;

	public bool EnableSamoAI;

	public bool DontCreateAttached;

	public bool IsRecommend;

	public bool EnableNova;

	public bool IsActiveSkill;

	public string AwakenSkillDesc
	{
		get
		{
			return _003CAwakenSkillDesc_003Ek__BackingField;
		}
		private set
		{
			_003CAwakenSkillDesc_003Ek__BackingField = value;
		}
	}

	public string[] SkillDescColorParam
	{
		get
		{
			return _003CSkillDescColorParam_003Ek__BackingField;
		}
		private set
		{
			_003CSkillDescColorParam_003Ek__BackingField = value;
		}
	}

	public string SkillIconHudStr => null;

	public float SkillCheckHackParameter
	{
		get
		{
			return _003CSkillCheckHackParameter_003Ek__BackingField;
		}
		private set
		{
			_003CSkillCheckHackParameter_003Ek__BackingField = value;
		}
	}

	public ResourceID SkillIcon => default(ResourceID);

	public ResourceID SkillIconHud => default(ResourceID);

	public uint Priority
	{
		get
		{
			return _003CPriority_003Ek__BackingField;
		}
		private set
		{
			_003CPriority_003Ek__BackingField = value;
		}
	}

	public List<Vector2> SkillSubtypeList
	{
		get
		{
			return _003CSkillSubtypeList_003Ek__BackingField;
		}
		private set
		{
			_003CSkillSubtypeList_003Ek__BackingField = value;
		}
	}

	public void SetZombieMode()
	{
	}

	public ResourceID Get1PResourceId(int index)
	{
		return default(ResourceID);
	}

	public ResourceID Get3PTeamResourceId(int index)
	{
		return default(ResourceID);
	}

	public ResourceID Get3PResourceId(int index)
	{
		return default(ResourceID);
	}

	public override void PostDeserializeData()
	{
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public void ProcessSkillSubType(string SkillSubtype)
	{
	}

	public string GetLevelUpDesc()
	{
		return null;
	}

	public string GetSpSkillDesc()
	{
		return null;
	}

	private static string BuildTempLevelStr(string u1, string u2)
	{
		return null;
	}

	private string BuildNewColorStr(float u1)
	{
		return null;
	}

	public string GetSkillDesc()
	{
		return null;
	}

	public bool LevelMax()
	{
		return false;
	}

	public ResourceID GetSkillResourceID(int resIndex, BHGGAEEHJCO localPlayerID, BHGGAEEHJCO skillCasterID, ResourceID defaultResID)
	{
		return default(ResourceID);
	}

	public bool GetTagNameAndBgColorByIndex(uint tagIndex, out string tagName, out Color? color)
	{
		tagName = null;
		color = null;
		return false;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	private string _003CPostDeserializeData_003Eb__39_0(string str)
	{
		return null;
	}

	private string _003CParseData_003Eb__40_0(string str)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
