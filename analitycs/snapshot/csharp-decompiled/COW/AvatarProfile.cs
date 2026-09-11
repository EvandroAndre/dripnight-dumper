using System;
using System.Collections.Generic;

namespace COW;

public class AvatarProfile : IComparable<AvatarProfile>
{
	public const int MAXSKILLCOUNT = 4;

	public uint AvatarID;

	public int SortID;

	public bool IsSelected;

	public bool hasOwnAvatar;

	public bool hasOwnAvatarItem;

	public AvatarSkill CurSkill;

	private int unLockedSkillCount;

	public bool IsAwakenSelect;

	public uint ExpireTime;

	public bool IsMarkedAvatar;

	private List<AvatarProfileDataOverrided> m_AvatarConfigDataList;

	public readonly Dictionary<int, uint> EquippedSkills;

	private readonly Dictionary<int, bool> m_EquippedSkillIsShared;

	private List<AvatarSuit> m_SuitList;

	public uint CurDebrisCount => 0u;

	public bool HasOwnPermanentAvatar => false;

	public int UnLockedSkillCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public CSSharedAvatarData BasicInfo => null;

	public AvatarProfileDataOverrided CurProfileData => null;

	public AvatarProfileDataOverrided NextProfileData => null;

	public List<AvatarProfileDataOverrided> AvatarConfigDataList => null;

	public List<AvatarSuit> SuitList => null;

	public uint GetSkillBySlot(int slotID)
	{
		return 0u;
	}

	public uint GetOriAvatarSkillId()
	{
		return 0u;
	}

	public AvatarSkillData GetOriAvatarSkillData()
	{
		return null;
	}

	public bool SlotSkillIsShared(int slotId)
	{
		return false;
	}

	public void SetSkillBySlot(int slotID, uint skillID, bool isSharedSkill)
	{
	}

	public void ClearEquippedSkills()
	{
	}

	public void UpdateSuitOwnStatus(uint suitID, bool hasOwnComplete)
	{
	}

	public int CompareTo(AvatarProfile other)
	{
		return 0;
	}
}
