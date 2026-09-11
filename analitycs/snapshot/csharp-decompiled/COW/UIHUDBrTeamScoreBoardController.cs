using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDBrTeamScoreBoardController<T> : UIBaseController where T : UIHUDBrTeamScoreBoardItemController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Transform> _003C_003E9__19_0;

		internal int _003CRefreshGrid_003Eb__19_0(Transform item1, Transform item2)
		{
			return 0;
		}
	}

	protected BrTeamScoreBoardView m_View;

	protected Dictionary<BHGGAEEHJCO, T> m_ItemCtrlDic;

	protected List<T> m_ItemList;

	protected int m_LocalPlayerTeamId;

	private List<int> m_InfoTypeList;

	private bool m_IsSkillPage;

	private bool m_IsAddFriendBtn;

	private ulong m_StartShowTime;

	private UIDetailTipsInGameController m_DetailTips;

	protected List<int> InfoTypeList => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ReInitData()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public virtual void RegisterUIEvent()
	{
	}

	public virtual void UpdateAllTitle()
	{
	}

	private void SetScoreBoardPage(bool isSkillPage = true)
	{
	}

	private void CheckAndSetInteractionBtn()
	{
	}

	private void SetInteractionBtn(bool isAddFriend = true)
	{
	}

	public virtual void RefreshGrid()
	{
	}

	protected virtual bool IsSelfTeam(BHGGAEEHJCO pId)
	{
		return false;
	}

	public virtual T InitOneItem(Transform parent)
	{
		return null;
	}

	private ItemType CreateItem<ItemType>(Transform parent) where ItemType : UIHUDBrTeamScoreBoardItemController
	{
		return null;
	}

	protected virtual void SetInfoType()
	{
	}

	protected void RefreshItemDataByPlayerID(BHGGAEEHJCO playerId, int intoType)
	{
	}

	protected void RefreshItemSlotDataByPlayerID(BHGGAEEHJCO playerId, DEAPPAAFOJK slot)
	{
	}

	protected void RefreshItemSlotDataByPlayerID(BHGGAEEHJCO playerId, HDAEFOANBGJ slot)
	{
	}

	protected void InitData()
	{
	}

	private void ClosePage()
	{
	}

	private void OnClickSkillPage()
	{
	}

	private void OnClickWeaponPage()
	{
	}

	private void OnClickReportBtnPage()
	{
	}

	private void OnClickAddFriendBtnPage()
	{
	}

	private void OnPlayerBeHit(object[] param)
	{
	}

	public virtual void OnAddPlayer(GEvent param)
	{
	}

	protected virtual void OnKillCountChanged(object[] param)
	{
	}

	protected virtual void OnPVEKillCountChanged(object[] param)
	{
	}

	protected virtual void OnSelfReviveCountChanged(object[] param)
	{
	}

	protected void OnAssistCountChanged(object[] param)
	{
	}

	protected virtual void OnTotalDamageChanged(object[] param)
	{
	}

	protected virtual void OnInventoryEquipmentStateChanged(uint param0, uint param1)
	{
	}

	protected virtual void OnInventoryItemChanged(object[] param)
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
