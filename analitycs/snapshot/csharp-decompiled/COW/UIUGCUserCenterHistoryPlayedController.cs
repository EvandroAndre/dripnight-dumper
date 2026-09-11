using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIUGCUserCenterHistoryPlayedController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopLatestInfo> _003C_003E9__7_0;

		internal int _003CRefreshData_003Eb__7_0(WorkshopLatestInfo a, WorkshopLatestInfo b)
		{
			return 0;
		}
	}

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIUGCUserCenterHistoryPlayedView m_View;

	private List<WorkshopLatestInfo> m_WorkshopLatestInfoList;

	private List<UIUGCUnifiedMapSlot1Controller> m_CachedHistoryItemList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnEmptyLableBtnClick()
	{
	}

	private void RefreshData()
	{
	}

	private void RefreshUIGrid()
	{
	}

	private void SetMapSlotEventLog()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
