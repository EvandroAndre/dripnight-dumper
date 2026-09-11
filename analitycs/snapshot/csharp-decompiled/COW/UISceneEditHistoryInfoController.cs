using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UISceneEditHistoryInfoController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopLatestInfo> _003C_003E9__17_0;

		public static Comparison<WorkshopHistoryInfo> _003C_003E9__17_1;

		internal int _003COnDataChanged_003Eb__17_0(WorkshopLatestInfo a, WorkshopLatestInfo b)
		{
			return 0;
		}

		internal int _003COnDataChanged_003Eb__17_1(WorkshopHistoryInfo a, WorkshopHistoryInfo b)
		{
			return 0;
		}
	}

	private UISceneEditHistoryInfoView m_View;

	private UIModelSceneEdit m_Model;

	private bool m_HasLatestPlayerdRequested;

	private List<WorkshopLatestInfo> m_WorkshopLatestInfoList;

	private bool m_HasHistoryPlayerdRequested;

	private List<WorkshopHistoryInfo> m_WorkshopHistoryInfoList;

	private int m_CurSelectBtn;

	private List<UISceneEditTemplateMapItemController> m_CachedHistoryItemList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public int GetCurSelectBtn()
	{
		return 0;
	}

	protected override void OnUIInit()
	{
	}

	private void OnLatestPlayedBtnClick()
	{
	}

	private void OnHistoryPlayedBtnClick()
	{
	}

	private void OnEmptyButtonClick()
	{
	}

	private void RefreshLatestInfo()
	{
	}

	private void RefreshHistoryInfo()
	{
	}

	private void LogUGCNavigate(SceneEditSlotInfo slotInfo)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
