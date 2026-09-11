using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDTeamBattleScoreBoardController<T> : UIBaseController where T : UIHUDTeamBattleScoreBoardItemController
{
	protected TeamScoreBoardView m_View;

	private List<int> m_InfoTypeList;

	protected Dictionary<BHGGAEEHJCO, T> m_ItemCtrlDic;

	protected List<T> m_LeftItemList;

	protected List<T> m_RightItemList;

	protected int m_LocalPlayerTeamId;

	private bool m_EnableReport;

	private bool m_EnableAddFriend;

	protected bool m_EnableSwitchSkill;

	protected ScoreBoardData m_DataShowing;

	protected bool m_CSTeamIconNewStyle;

	protected bool m_CSTeamIconOldStyle;

	private string m_AbiltyIntroBgSpriteDefault;

	private string m_AbiltyIntroBgSkinSpriteDefault;

	private bool m_LastEnableCSAbilityPoint;

	private uint m_LastCSShopSkinType;

	private ulong m_StartShowTime;

	private UIDetailTipsInGameController m_DetailTips;

	protected List<int> InfoTypeList => null;

	protected Dictionary<BHGGAEEHJCO, T> ItemCtrlList => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected virtual void SetInfoType()
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

	private void RefreshCSAbilityPointSwitchState()
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

	private void SetSkin(bool resetToDefault = false)
	{
	}

	private void HideClanInfo()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	protected virtual ResourceID GetTitileResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnDestroy()
	{
	}

	public override void Show()
	{
	}

	public virtual void RegisterUIEvent()
	{
	}

	public virtual void UnRegisterUIEvent()
	{
	}

	private void OnGetOverrideMatchSetting()
	{
	}

	private void ClosePage()
	{
	}

	private void OnClickReportBtn()
	{
	}

	private void OnClickAddFriendBtn()
	{
	}

	private void OnRegionRankListBtnClick()
	{
	}

	private void OnClickBtnSwitchSkill()
	{
	}

	private void SwitchToDataShowing(ScoreBoardData target)
	{
	}

	private void OnKDAMenuSelected()
	{
	}

	private void OnSkillMenuSelected()
	{
	}

	private void OnAbiltiyMenuSelected()
	{
	}

	private void UpdateInteractBtnSprite()
	{
	}

	public virtual T InitOneItem(Transform parent)
	{
		return null;
	}

	private ItemType CreateItem<ItemType>(Transform parent) where ItemType : UIHUDTeamBattleScoreBoardItemController
	{
		return null;
	}

	public virtual void OnAddPlayer(GEvent param)
	{
	}

	private void UpdateAddFriendBtn()
	{
	}

	private void OnReplaceSamoInfo(object[] param)
	{
	}

	protected virtual bool IsTeamOnLeft(BHGGAEEHJCO pId)
	{
		return false;
	}

	public void OnPlayerQuit(object[] param)
	{
	}

	public virtual void RefreshGrid()
	{
	}

	protected int SortPlayerDataByTeamIndex(Transform tr1, Transform tr2)
	{
		return 0;
	}

	protected virtual int SortPlayerData(Transform tr1, Transform tr2)
	{
		return 0;
	}

	public void UpdateLeftScore(int leftScore)
	{
	}

	public void UpdateRightScore(int rightScore)
	{
	}

	public void UpdateLeftCustomIcon(ResourceID spriteName, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	public void UpdateRightCustomIcon(ResourceID spriteName, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	public virtual void UpdateAllTitle()
	{
	}

	public virtual void RefreshUISkinChange()
	{
	}

	public virtual void UpdateLeftTitle()
	{
	}

	public virtual void UpdateRightTitle()
	{
	}

	protected void UpdateInfoTitle(UILabel infoTxt, int index)
	{
	}

	public void UpdateTeamInfo(Player player, bool isUpdateLeft)
	{
	}

	private void OnFactionIDChanged(object[] data)
	{
	}

	protected virtual void OnKillCountChanged(object[] param)
	{
	}

	protected virtual void OnDeadCountChanged(object[] param)
	{
	}

	protected void OnAssistCountChanged(object[] param)
	{
	}

	protected virtual void OnTotalDamageChanged(object[] param)
	{
	}

	protected void RefreshItemDataByPlayerID(BHGGAEEHJCO playerId)
	{
	}

	protected void RefreshItemData(BHGGAEEHJCO playerId, int index, string msg)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnBattleLevelPlayerLevelChanged(uint playerID)
	{
	}

	private void OnSFRoleplayRefreshIcon(uint playerID)
	{
	}

	private void OnShowDetailTips(GEvent data)
	{
	}

	private void HideDetailTips()
	{
	}

	private void OnIngameAddFriendConfirmed(ulong accountId)
	{
	}
}
