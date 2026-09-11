using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHUDBrTeamScoreBoardItemController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CEKLEBBHLIG, bool> _003C_003E9__65_0;

		internal bool _003CUpdatePlayerActiveSkillData_003Eb__65_0(CEKLEBBHLIG skill)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public uint id;

		internal bool _003CSetLoadout_003Eb__0(Item x)
		{
			return false;
		}
	}

	protected BrTeamScoreBoardItemView m_View;

	protected Player m_Player;

	protected ulong m_AccountID;

	protected string m_Nickname;

	protected BHGGAEEHJCO m_PlayerID;

	private List<int> m_InfoTypeList;

	private bool m_IsSelf;

	public int TeamIndexNum;

	private GKNHKOFFCPG m_PlayerModule;

	private List<UILabel> m_InfoLabelList;

	protected HBLKLJHFJDK m_ActiveSkill;

	protected List<CEKLEBBHLIG> m_SkillList;

	private PetSkillLevelData m_PetSkillLevelData;

	private List<UIEventListener> m_SkillBtnList;

	private List<UISprite> m_SkillSpriteList;

	private string ExtraSkillDesc;

	public const int MAX_SKILL_NUM = 4;

	private string FilledArmorIcon;

	private string FilledArmorIconBG;

	private string FilledArmorIconExplode;

	private string FilledArmorIconExplodeBG;

	private string FilledHeadIcon;

	private string FilledHeadIconBG;

	private string FilledHeadIconProtect;

	private string FilledHeadIconProtectBG;

	private int m_CurHelmetLevel;

	private int m_CurVestLevel;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	private UIModelMatch m_ModelMatch;

	protected List<int> InfoTypeList => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected void Update()
	{
	}

	public virtual void UpdatePlayerData(Player player)
	{
	}

	private void UpdateTeamIndex(Player player)
	{
	}

	public void SetScoreBoardPage(bool isSkillPage = true)
	{
	}

	public void SetInteractionBtn(bool isAddFriend = true)
	{
	}

	public void SetIsSelf(bool isSelf)
	{
	}

	protected virtual void SetDeadBG(bool isDead)
	{
	}

	public void RefreshData(Player player)
	{
	}

	public void RefreshRatingViewEx()
	{
	}

	private void RefreshRatingView(Player player)
	{
	}

	private float GetRating(Player player)
	{
		return 0f;
	}

	public void RefreshData(Player player, int intoType)
	{
	}

	private void UpdateInfoData(UILabel infoTxt, Player player, int index)
	{
	}

	public int GetWeaponLevel(uint weaponId)
	{
		return 0;
	}

	private void SetLevelEffect(FDAEPHMIEPC weapon, UISprite effect)
	{
	}

	public void RefreshSlotData(Player player, HDAEFOANBGJ slot)
	{
	}

	public void RefreshSlotData(Player player, DEAPPAAFOJK slot)
	{
	}

	private void SetRankInfo(int rankLevel, int peakRankPos, int rankPoint)
	{
	}

	protected void OnInitData(Player player)
	{
	}

	public void ShowSelf(bool isShow)
	{
	}

	protected void UpdateActiveSkillIcon()
	{
	}

	private void SetSkillData()
	{
	}

	private void RefreshReportStatus(object[] param)
	{
	}

	private void OnReportBtnClick()
	{
	}

	private void OnAddFriendBtnClick()
	{
	}

	public void RefreshAddFriend()
	{
	}

	public ulong GetPlayerAccountId()
	{
		return 0uL;
	}

	public void InitData(List<int> list, Player player, bool isLocalSelf)
	{
	}

	public void SetInfoTypeList(List<int> list)
	{
	}

	private void UpdatePlayerActiveSkillData(Player player)
	{
	}

	private void UpdatePetSkill(Player player)
	{
	}

	private void UpdatePlayerExtraSkillData(Player player)
	{
	}

	private bool SetLoadout(uint id)
	{
		return false;
	}

	private void SetEmptyState()
	{
	}

	private void OnPlayerLevelChange(uint playerID)
	{
	}

	private void OnSkillBtnPress(GameObject go)
	{
	}

	private void OnPetSkillBtnPress(GameObject go)
	{
	}

	private void OnExtraSkillBtnPress(GameObject go)
	{
	}

	protected virtual void OnKillChange(int kill)
	{
	}

	protected virtual void OnDeadChange(int dead)
	{
	}

	protected virtual void OnDamageChange(uint damage)
	{
	}

	private void OnPlayerAliveStateChanged(uint pid)
	{
	}

	private void OnMaxDurabilityChanged(uint playerID)
	{
	}

	private void OnUpdateSkillIcon(object[] param)
	{
	}

	private void OnPlatformHeadpicGetted()
	{
	}

	private void OnIngameAddFriendConfirmed(ulong accountId)
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	private void OnPlayerPetSkillChanged(object[] data)
	{
	}

	private void OnPlayerSkillChanged(object[] data)
	{
	}

	private void OnPlayerLoadoutChanged(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
