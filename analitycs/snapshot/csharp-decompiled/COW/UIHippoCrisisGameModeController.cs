using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisGameModeController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public UIHippoCrisisGameModeController _003C_003E4__this;

		public uint reDefID;

		internal void _003CRefreshDownloadState_003Eb__0()
		{
		}
	}

	private UIHippoCrisisGameModeView m_View;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private UIModelHippoCrisisLadderMatch m_ModelHippoCrisisLadderMatch;

	private MapModeData m_SelectedMapModeData;

	private UINewDownloadInfoController m_DownloadCtrl;

	private UIHippoCrisisRankIconController m_RankCtrl;

	private bool m_IsDuoVersionNodeActive;

	private static Vector3 HOTFIXDOWNLOADBTN8POS;

	private static Vector3 DOWNLOADICONPOS;

	private static Vector3 DOWNLOADTXTPOS;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnClickBtnModelPick()
	{
	}

	private void OnClickBtnRankIcon()
	{
	}

	private void OnClickRuleBtn()
	{
	}

	public void SetViewData(List<MapModeData> data)
	{
	}

	public void StartGuide(int fixDepth)
	{
	}

	private void RefreshSelectedMap(MapModeData data)
	{
	}

	private void RefreshSeasonInfo()
	{
	}

	private void RefreshRankInfo()
	{
	}

	private bool ClickDuringDuoVersion()
	{
		return false;
	}

	private bool NeedNoticeDuoVersion()
	{
		return false;
	}

	private void RefreshNoticeDuoVersion(object[] data)
	{
	}

	private void RefreshLockState()
	{
	}

	private void RefreshDownloadState()
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
