using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIWorkshopLeaderboardItemController : UIEasyListItemController
{
	private UIWorkshopLeaderboardItemView m_View;

	private UIModelUGCDatabase m_ModelDatabase;

	private UIBaseProfileInfoController m_PlayerProfileInfoUI;

	private BaseProfileInfo m_ProfileInfo;

	private WidgetAutoScrollLabel[] m_ColumnLabels;

	private List<UIModelUGCDatabase.LeaderboardShowHeader> m_Headers;

	private Func<int, WorkshopDataStorageContent> m_GetAssociationContentFunc;

	private Func<int, DataStoragePlatformInfo> m_GetPlatformProfileFunc;

	private EventLogger.EventTypeUGCViewMapLeaderboard m_ViewLeaderboardLog;

	private ulong m_AccountID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetCommonData(List<UIModelUGCDatabase.LeaderboardShowHeader> headers, Func<int, WorkshopDataStorageContent> getAssociationContentFunc, Func<int, DataStoragePlatformInfo> getPlatformProfileFunc, EventLogger.EventTypeUGCViewMapLeaderboard viewLeaderboardLog)
	{
	}

	private void ShowUI(WorkshopLeaderboardContent leaderboardContent, WorkshopDataStorageContent dataStorageContent, DataStoragePlatformInfo platformInfo)
	{
	}

	private void ShowPlatformInfo(DataStoragePlatformInfo info)
	{
	}

	private void OnProfileClick()
	{
	}

	private void SetRank(uint rank)
	{
	}

	private void ShowColumnLabel(int index, string value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
