using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudSceneEditItemGenController : UIBaseController
{
	private enum EState
	{
		WaitForSearch,
		SearchingFirstTime,
		SearchingSwitchPages,
		SearchFailed,
		Result
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public UIHudSceneEditItemGenTagController controller;

		public UIHudSceneEditItemGenController _003C_003E4__this;

		internal void _003CRefreshSearchGuess_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass45_0
	{
		public UIHudSceneEditItemGenTagController controller;

		public UIHudSceneEditItemGenController _003C_003E4__this;

		internal void _003CRefreshSearchHistory_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public int completed;

		public int total;

		public Action onAllComplete;

		public UIHudSceneEditItemGenController _003C_003E4__this;

		public Action checkAllDone;

		public Action _003C_003E9__2;

		internal void _003CRequestDownloadResource_003Eb__0()
		{
		}

		internal void _003CRequestDownloadResource_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_1
	{
		public UGCResourceShopMetaData metaData;

		public _003C_003Ec__DisplayClass47_0 CS_0024_003C_003E8__locals1;

		internal void _003CRequestDownloadResource_003Eb__1()
		{
		}
	}

	private UIHudSceneEditItemGenView m_View;

	private HNDHJGJILHC m_Game;

	private SceneEditResourceShopManager m_Manager;

	private UIModelSceneEdit m_ModelSceneEdit;

	private EState m_State;

	private string m_SearchContent;

	private const int InputLimit = 30;

	private const int GuessLimit = 6;

	private const int GuessLimitAtHistory = 2;

	private const int TotalRequestSize = 30;

	private const int PageSize = 6;

	private const string OnSearchResultEmptyKey = "T_50_SD_ITEMCREATE_ERROR_NIL";

	private const string OnSearchResultWebErrorKey = "T_50_SD_ITEMCREATE_ERROR_NETWORK";

	private string m_SearchFailureKey;

	private int m_CurrentPage;

	private int m_SelectedIndex;

	private List<ulong> m_ResultResourceIDList;

	private Dictionary<ulong, KCJDEKIJAKH> m_TemplateDataDictionary;

	private List<UIHudSceneEditItemGenTagController> m_SearchGuessItemControllers;

	private List<UIHudSceneEditItemGenTagController> m_SearchHistoryItemControllers;

	private List<UIHudSceneEditItemGenResultController> m_SearchResultItemControllers;

	private SceneEditAgent m_Agent;

	private int TotalPage => 0;

	public SceneEditAgent Agent => null;

	protected override void OnUIInit()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void OnSearchHelpBtnClicked()
	{
	}

	private void OnResHelpBtnClicked()
	{
	}

	private void OnSearchBtnClicked()
	{
	}

	private void OnRefreshBtnClicked()
	{
	}

	private void OnDelBtnClicked()
	{
	}

	private void OnSearchInputChanged()
	{
	}

	private void OnBackBtnClicked()
	{
	}

	private void OnCloseBtnClicked()
	{
	}

	private void OnPreviousBtnClicked()
	{
	}

	private void OnNextBtnClicked()
	{
	}

	private void OnClickToHide(List<GameObject> hits)
	{
	}

	private void SetViewState(EState state)
	{
	}

	private void RefreshSearchGuess()
	{
	}

	private void RefreshSearchHistory()
	{
	}

	private void RefreshFailedReasonLabel()
	{
	}

	private void RequestDownloadResource(Action onAllComplete = null)
	{
	}

	private void RefreshSearchResult(int selectedIndex = -1)
	{
	}

	private void RefreshSearchResultUI(List<ulong> currentPageResultResourceIdList)
	{
	}

	private void OnCancelPutDownObj(object[] data)
	{
	}

	private void RefreshPageLabel()
	{
	}

	private void RefreshPreviousBtn()
	{
	}

	private void RefreshNextBtn()
	{
	}

	private void ResetToFirstPage()
	{
	}

	private void RefreshCountLabel()
	{
	}

	private void RefreshSearchBtn()
	{
	}

	private void RefreshDragPrompt()
	{
	}

	private void OnPageDataRequested(object[] data)
	{
	}

	private void OnPageRequestSuccess()
	{
	}

	private void OnPageRequestFail(string failureKey)
	{
	}

	private void ShowTutorial()
	{
	}

	private void ShowTutorialDragOut()
	{
	}

	private void ShowTutorialDragObj()
	{
	}

	private void OnTutorialAutoStop(uint guideType)
	{
	}

	private List<ulong> GetSearch3DResourceIDByPage(List<ulong> searchList, int page, int size)
	{
		return null;
	}

	private void OnAddTemplate(object[] data)
	{
	}

	private void OnOtherPanelShow(object[] data)
	{
	}

	private void OnOtherPanelShow()
	{
	}

	private void _003COnPreviousBtnClicked_003Eb__40_0()
	{
	}

	private void _003COnNextBtnClicked_003Eb__41_0()
	{
	}

	private void _003COnPageRequestSuccess_003Eb__59_0()
	{
	}

	private void _003CShowTutorialDragObj_003Eb__63_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
