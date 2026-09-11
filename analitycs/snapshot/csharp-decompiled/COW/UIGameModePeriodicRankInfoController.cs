using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIGameModePeriodicRankInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public UIGameModePeriodicRankInfoController _003C_003E4__this;

		public List<ResourceID> listNeedDownloadMapRes;

		internal void _003CRefreshDownloadState_003Eb__0()
		{
		}
	}

	private UIGameModePeriodicRankInfoView m_View;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelPeriodicLadderMatch m_ModelPeriodicLadderMatch;

	private List<GameObject> m_StarList;

	private List<GameObject> m_BlackStarList;

	private MapModeData m_SelectedMapModeData;

	private UINewDownloadInfoController m_DownloadCtrl;

	private bool m_IsDuoVersionNodeActive;

	private static Vector3 HOTFIXDOWNLOADBTN8POS;

	private static Vector3 DOWNLOADICONPOS;

	private static Vector3 DOWNLOADTXTPOS;

	private UICountDownController m_BanMatchCDCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void SetViewData(List<MapModeData> data)
	{
	}

	private void OnBanMatchBtnClick()
	{
	}

	private void RefreshBanMatchView()
	{
	}

	private void OnMapSelectConfirm(object[] data)
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

	private void RefreshRankIconAndStars(ResourceID id, int star)
	{
	}

	private void RefreshLockState()
	{
	}

	private void RefreshDownloadState()
	{
	}

	private void OnMapChangeButtonClicked()
	{
	}

	private void OnClickBtnModelPick()
	{
	}

	private void OnClickBtnRankIcon()
	{
	}

	private List<ResourceID> GetNeedDownloadMapResList()
	{
		return null;
	}

	private bool NeedNoticeDuoVersion()
	{
		return false;
	}

	private void RefreshNoticeDuoVersion(object[] data)
	{
	}

	private bool ClickDuringDuoVersion()
	{
		return false;
	}

	private void _003CRefreshBanMatchView_003Eb__18_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
