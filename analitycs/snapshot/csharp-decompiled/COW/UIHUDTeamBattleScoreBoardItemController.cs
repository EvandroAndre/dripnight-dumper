using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDTeamBattleScoreBoardItemController : UIBaseController
{
	public class SkillBaseComp : IComparer<CEKLEBBHLIG>
	{
		public int Compare(CEKLEBBHLIG x, CEKLEBBHLIG y)
		{
			return 0;
		}

		private int GetScore(CEKLEBBHLIG skill)
		{
			return 0;
		}

		private uint GetID(CEKLEBBHLIG skill)
		{
			return 0u;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CEKLEBBHLIG, bool> _003C_003E9__69_0;

		internal bool _003CSetSkillData_003Eb__69_0(CEKLEBBHLIG skill)
		{
			return false;
		}
	}

	protected TeamScoreBoardItemView m_View;

	protected Player m_Player;

	protected List<HBLKLJHFJDK> m_ActiveSkills;

	protected AvatarSkillData m_SamoActiveSkillData;

	protected List<AvatarSkillData> m_SamoSkillList;

	private List<UILabel> m_InfoLabelList;

	private bool hasReported;

	private bool hasAddedFriend;

	private bool m_IsSelf;

	private ScoreBoardData m_DataShowing;

	private GameObject m_AceVFX;

	private uint m_AsyncLoadAceVFXTicket;

	private uint m_AceVFXContinueDelayCallID;

	private List<Transform> m_SlotRoots;

	private List<UIHUDTeamBattleScoreBoardSkillController> m_SkillCtrls;

	private List<UIHUDTeamBattleScoreBoardSkillController> m_KDAPanelSkillCtrls;

	private List<UIHUDTeamBattleScoreBoardAbilityController> m_AbilityCtrls;

	private List<GameObject> m_AbilityConnectLines;

	private bool m_IsCSAbilityPointEventRegistered;

	private bool m_LastEnableCSAbilityPoint;

	private uint m_LastCSShopSkinType;

	private UIHUDCSScoreBoardBuildIconController m_ExtraScoreBoardBuildIconCtrl;

	private UIHUDCSScoreBoardBuildIconController m_KDAPanelExtraScoreBoardBuildIconCtrl;

	private PetSkillLevelData m_PetSkillLevelData;

	private MutableString m_TextBuilder0;

	private MutableString m_TextBuilder1;

	private MutableString m_TextBuilder2;

	private UIWidget.Pivot m_HeadIconPivot;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	private string m_AbilityLineFinishSpriteDefault;

	private List<int> m_InfoTypeList;

	protected List<int> InfoTypeList => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private static bool IsAdditionalSlotNeeded()
	{
		return false;
	}

	private void InitBattleLevelAdditionalSlot(Player player)
	{
	}

	public void UpdateBattleLevelAdditionalSlot()
	{
	}

	public void UpdateBattleLevelAdditionalSlotOnSFRoleplay(uint playerID)
	{
	}

	private void PrepareAbilityPanelSlots(uint maxLevel)
	{
	}

	private void RefreshAbilityConnectLinesState()
	{
	}

	private uint GetCurChoosedLevelForPlayer(Player player)
	{
		return 0u;
	}

	private void DestroyAbilityConnectLines()
	{
	}

	private void CloseAbilityChildControllers()
	{
	}

	private void PrepareSkillPanelSlots()
	{
	}

	private void PrepareKDAPanelSlots()
	{
	}

	protected override void OnUIInit()
	{
	}

	private void RecordDefaultSkinInfo()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void CacheCSAbilityPointMatchSettingState()
	{
	}

	private bool UpdateCSAbilityPointMatchSettingCache(out bool enableChanged, out bool skinTypeChanged)
	{
		enableChanged = default(bool);
		skinTypeChanged = default(bool);
		return false;
	}

	private void TryRegisterCSAbilityPointEvents()
	{
	}

	private void OnGetOverrideMatchSetting()
	{
	}

	private void SetSkin(bool resetToDefault = false)
	{
	}

	private void RefreshAbilityPanelSkin()
	{
	}

	private void PlayerSkillChanged(object[] data)
	{
	}

	private void PlayerPetSkillChanged(object[] data)
	{
	}

	private void OnBindActiveSkillCard(GEvent evt)
	{
	}

	private void OnReportCheatSent(object[] param)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private bool ShouldShowInteractButtons()
	{
		return false;
	}

	private void HideInteractButtonsIfNeeded()
	{
	}

	public void ShowReportButton(bool show)
	{
	}

	public void ShowAddFriendButton(bool show)
	{
	}

	public void SwitchDataShowing(ScoreBoardData dataShowing)
	{
	}

	public void InitData(List<int> list, Player player, bool isLocalSelf)
	{
	}

	public int GetPlayerTeamIndex()
	{
		return 0;
	}

	protected virtual void OnInitData(Player player)
	{
	}

	protected void SetSkillData(Player player)
	{
	}

	protected void SetAbilityData(Player player)
	{
	}

	private void RefreshLoadOutIcon(Player player)
	{
	}

	protected void UpdatePlayerActiveSkillData(Player player)
	{
	}

	public void ShowSelf(bool isShow)
	{
	}

	public void RefreshData(Player player)
	{
	}

	public void UpdatePlayerAceVFX(object[] data)
	{
	}

	private void HideAceVFX()
	{
	}

	private void CancelDelayCallVFX()
	{
	}

	private void OnVFXLoaded(uint ticket, bool succeeded, UnityEngine.Object obj)
	{
	}

	private void ResetObjectTransform(GameObject obj)
	{
	}

	public void RefreshData(int index, string msg)
	{
	}

	public void SetInfoTypeList(List<int> list)
	{
	}

	public void SetIsSelf(bool isSelf)
	{
	}

	private void SetDeadBG(bool isDead)
	{
	}

	private void InitInfoTxtByType()
	{
	}

	public virtual void UpdatePlayerData(Player player)
	{
	}

	protected virtual void RefreshPrivilegeIcon(Player player)
	{
	}

	private void UpdateTeamIndex(Player player)
	{
	}

	private void UpdateInfoData(UILabel infoTxt, Player player, int index, MutableString m_TextBuilder)
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

	protected virtual void OnFootballScoreChange(int goal)
	{
	}

	protected virtual void OnFootballAssistChange(int assist)
	{
	}

	private void OnPlayerAliveStateChanged(uint data)
	{
	}

	protected void OnClickReportBtn()
	{
	}

	protected void OnClickAddFriendBtn()
	{
	}

	private void OnPlatformHeadpicGetted()
	{
	}

	private void OnInitCSAbilityPointInfo()
	{
	}

	private void OnAllPlayersAbilityPointChoiceUpdated(object[] data)
	{
	}

	private void OnPlayerLoadoutChanged(object[] data)
	{
	}

	private void UpdatePetSkill(Player player)
	{
	}

	private void OnPetSkillBtnPress(GameObject go)
	{
	}

	private void OnIngameAddFriendConfirmed(ulong accountId)
	{
	}

	private void OnInfinteEffectShowStateChange(uint changePlayerID)
	{
	}

	public ulong GetPlayerAccountId()
	{
		return 0uL;
	}

	public int GetCSPeakPoints()
	{
		return 0;
	}

	public void SetPresetPickHideView()
	{
	}

	private void OnPetSkillPresetPickHideBtnClick()
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
