using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPeakWeekLeaderboardController : UINavigationController, IUIModelDataChangeObserver
{
	private sealed class _003CTryShowPreviewAvatar_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPeakWeekLeaderboardController _003C_003E4__this;

		private List<ulong> _003CneedRequestAccountIds_003E5__2;

		private int _003Ci_003E5__3;

		private ulong _003CaccountID_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTryShowPreviewAvatar_003Ed__20(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIPeakWeekLeaderboardView m_View;

	private GameObject m_GlaiveObj;

	private UIMaleAvatar m_FirstRankAvatar;

	private UIMaleAvatar m_SecondRankAvatar;

	private UIMaleAvatar m_ThirdRankAvatar;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private string m_CheckTimeStr;

	private Coroutine m_CoTryShowPreviewAvatar;

	private UIPeakWeekLeaderboardItemController[] m_LeaderboardItemList;

	private GameObject m_GoMixCamera;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void RefreshTitle()
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshTime()
	{
	}

	private void ShowCongratulationWnd()
	{
	}

	private void RefreshLeaderboardBox()
	{
	}

	private void RefreshLeaderboardItem(int index, LeaderBoardInfo info)
	{
	}

	private IEnumerator TryShowPreviewAvatar()
	{
		return null;
	}

	private void ShowLoading(int rank, bool show)
	{
	}

	private bool ShowAvatar(int rank, ulong accountID)
	{
		return false;
	}

	private void InitKingsglaive()
	{
	}

	private void SetPreviewAvatarVisible(int rank, bool visible)
	{
	}

	private void InitCamera()
	{
	}

	private void SetCameraFovAccordingToResolution(Camera camera)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnGoToLeaderboardBtnClick()
	{
	}

	private void onTipsBtnClick()
	{
	}

	private void OnSeasonFinalSettlementBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CRefreshTime_003Eb__16_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
