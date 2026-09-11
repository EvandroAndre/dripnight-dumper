using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDSingleFightLeaderBoardBaseController<T> : UIBaseController where T : UIHUDSingleFightLeaderBoardItemBaseController
{
	protected UIHudSingleFightLeaderBoardView m_View;

	protected List<int> m_InfoTypeList;

	protected Dictionary<BHGGAEEHJCO, T> m_ItemCtrlDic;

	protected Dictionary<ulong, T> m_RemovedPlayerItemCtrlDic;

	protected T m_LocalPlayerItemCtrl;

	protected T m_LocalPlayerItemCtrlInGrid;

	protected List<LeaderBoardSortingData> m_SortingDatas;

	private bool m_ReportOn;

	private List<Transform> cachedTransforms;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public T CreateItem(Transform parent)
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	public virtual void RegisterUIEvent()
	{
	}

	public virtual void UnRegisterUIEvent()
	{
	}

	protected virtual void SetInfoTypeList()
	{
	}

	public virtual void SetInfoTitlesByInfoType()
	{
	}

	protected virtual void SetSortingTypes()
	{
	}

	public virtual void Sort()
	{
	}

	private int ItemCompareWithPlayerID(Transform item2, Transform item1)
	{
		return 0;
	}

	private int ItemCompare(Transform item2, Transform item1)
	{
		return 0;
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	protected virtual bool IsPlayerExist(BHGGAEEHJCO playerID)
	{
		return false;
	}

	public virtual void OnAddPlayer(GEvent param)
	{
	}

	protected virtual void OnPlayerAdded(T itemCtrl)
	{
	}

	public void RemoveItemInLeftPlayerDict(ulong userID)
	{
	}

	public void OnPlayerQuit(BHGGAEEHJCO pId)
	{
	}

	protected virtual void OnCommonPlayerStatsChanged(object[] param)
	{
	}

	protected void SetSortingData(EMatchResultPlayerInfoType type, ELeaderBoardSortingOrder order)
	{
	}

	protected void SetInfoTitle(UILabel infoTxt, int index)
	{
	}

	protected virtual void SetRank()
	{
	}

	public virtual void RefreshGrid()
	{
	}

	private void ClosePage()
	{
	}

	private void OnReportBtnClick()
	{
	}

	private void OnRegionRankListClick()
	{
	}

	private void Update()
	{
	}

	protected void CheckLocalPlayerItem()
	{
	}

	protected void RefreshItemDataByPlayerID(BHGGAEEHJCO playerId)
	{
	}
}
