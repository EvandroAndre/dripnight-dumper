using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UISeasonReplayController : UINavigationController, IUIModelDataChangeObserver, ICombineShare, IShare
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__57_0;

		internal void _003COnShareBtnClick_003Eb__57_0()
		{
		}
	}

	private sealed class _003CGCommon_002DICombineShare_002DPrepareControllerBeforeScreenshot_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISeasonReplayController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CGCommon_002DICombineShare_002DPrepareControllerBeforeScreenshot_003Ed__68(int _003C_003E1__state)
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

	private sealed class _003CShowCloseBtn_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISeasonReplayController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowCloseBtn_003Ed__32(int _003C_003E1__state)
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

	private bool m_SeasonReplayDataAlready;

	private bool m_AlreadyClickFirstPage;

	private bool m_HasRefreshUIView;

	private List<IUISeasonReplayItem> m_ItemControllerList;

	private int m_CurSelectIndex;

	private int m_PreSelectIndex;

	private bool m_IsFinishedSeasonReplay;

	private bool m_SeasonReplayV2;

	public bool IsInOutAnimPlaying;

	private UISeasonReplayView m_View;

	private UIModelSeasonReplay m_ModelSeasonReplay;

	private UIModelActivity m_ModelActivity;

	private UIModelProfile m_ModelProfile;

	private bool m_IsBR;

	private bool m_KellyOut;

	private const float CannotClickAlpha = 0.4f;

	private uint m_Ticket_SEASONREPLAYCLOUD_UIFX;

	private uint m_Ticket_SEASONREPLAYCLOUDONCE_UIFX;

	private string m_PageTitle;

	public string StartSeasonBtnLabelTxt;

	private readonly string[] CloseLogName;

	private GameObject[] SelectedTabObj;

	private Dictionary<int, Type> m_IndexToTypeDic;

	private UISeasonReplayUtil m_UISeasonReplayUtil;

	private Vector3 HidePos;

	private Vector3 FirstPagePos;

	private List<Vector3> ItemTmpPosList;

	private List<IUISeasonReplayItem> m_validItemControllerList;

	private bool m_HasShownFirstPage;

	private uint m_DelayCallId;

	private uint m_DelayCallSpineId;

	private List<IUISeasonReplayItem> ValidItemControllerList => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private IEnumerator ShowCloseBtn()
	{
		return null;
	}

	private void OnAsyncLoadResFinished(uint ticket, bool success, UnityEngine.Object obj)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnAnimOutFinish(object[] data)
	{
	}

	private void ShowCurrentChildCtrl()
	{
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	private void OnOverviewBtnClicked()
	{
	}

	private void OnDestinyWeaponBtnClicked()
	{
	}

	private void OnSocialBtnlBtnClicked()
	{
	}

	public void OnBattleStylelBtnClicked()
	{
	}

	private void OnNextBtnClicked()
	{
	}

	private void OnFirstPageCloseBtnClicked()
	{
	}

	private void OnFirstPageBtnClicked()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void RefreshUIView()
	{
	}

	private void ShowFirstPage()
	{
	}

	private void OnSelectClick(int idx)
	{
	}

	private void RefreshSwitchView()
	{
	}

	private void RefreshTabSelectState()
	{
	}

	public void OnShareBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void OnStartSeasonBtnClicked()
	{
	}

	private void DownloadForReplaySocial()
	{
	}

	private void RequestAvatarProfileForSocialReplay()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public CombineScreenshotData OnBeforeCombineScreenshot(int index)
	{
		return default(CombineScreenshotData);
	}

	public void OnAfterCombineScreenshot(int index)
	{
	}

	IEnumerator ICombineShare.PrepareControllerBeforeScreenshot()
	{
		return null;
	}

	private void AfterCombineShareFinish()
	{
	}

	private void AfterFirstPageScreenShot()
	{
	}

	private CombineScreenshotData BeforeFirstPageScreenShot()
	{
		return default(CombineScreenshotData);
	}

	private void _003COnFirstPageBtnClicked_003Eb__50_0()
	{
	}

	private void _003CShowFirstPage_003Eb__53_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
