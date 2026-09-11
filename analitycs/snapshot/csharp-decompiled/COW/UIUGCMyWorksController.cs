using System;
using System.Collections;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIUGCMyWorksController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass105_0
	{
		public UGCSimpleDownloadTask resDownloadTask;

		public UIUGCMyWorksController _003C_003E4__this;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass105_1
	{
		public List<ResourceID> remainIds;

		public UIUGCMyWorksController _003C_003E4__this;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public UIUGCMyWorksController _003C_003E4__this;

		public UIUGCDeleteFileSelectController ctrl;

		public Action _003C_003E9__1;

		internal void _003COnBtnDelClick_003Eb__0(bool b)
		{
		}

		internal void _003COnBtnDelClick_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public UIUGCMyWorksController _003C_003E4__this;

		public UIModelSceneEdit.EWorkshopDelType type;

		public Action callback;

		internal void _003CRequestDelPop_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass73_0
	{
		public string shareKey;

		internal void _003CShowFreeRoomCardShareGuide_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public string modifyCoverKey;

		internal void _003CShowModifyCoverGuide_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass97_0
	{
		public int slotId;

		internal bool _003CReSelectItemBySlotId_003Eb__0(SceneEditSlotInfo info)
		{
			return false;
		}
	}

	private sealed class _003CCheckLastCDNDownloadFailed_003Ed__100 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCMyWorksController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCheckLastCDNDownloadFailed_003Ed__100(int _003C_003E1__state)
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

	private sealed class _003CCheckLastEditedSlotId_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCMyWorksController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCheckLastEditedSlotId_003Ed__101(int _003C_003E1__state)
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

	private sealed class _003COnUploadFinished_003Ed__99 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCMyWorksController _003C_003E4__this;

		public uint slotId;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnUploadFinished_003Ed__99(int _003C_003E1__state)
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

	private sealed class _003CReSelectItemByIndex_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCMyWorksController _003C_003E4__this;

		public int index;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CReSelectItemByIndex_003Ed__98(int _003C_003E1__state)
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

	private UIUGCMyWorksView m_View;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelOptionalDownload m_ModelDownload;

	private SceneEditSlotInfo m_CurSlotInfo;

	private EWorkshop.SlotType m_CurSlotType;

	private UIClickMask m_ClickMask;

	private Color m_LockColor;

	private bool m_IsNameSwitchOpen;

	private bool m_IsDescSwitchOpen;

	private bool m_ClassicSlotInited;

	private bool m_IsFE;

	private bool m_ShowUpdateLog;

	private string m_DefaultSignature;

	private UINewDownloadInfoController m_OptionalMapResDownloader;

	private UIWorkshopTipBubbleController m_ShareGuideCtrl;

	private bool m_NeedCheckAutoDownload;

	private Dictionary<string, UGCResourceForGameData.PackageOrABFileInfo> m_ResourceBytesFileInfos;

	private List<UGCResInfo> m_ResInfos;

	private bool m_IsRequestingResourceBytes;

	private Color m_ShareToggleOffBgColor;

	private Color m_ShareToggleOnBgColor;

	private bool m_NeedNaviToCreateMap;

	private int m_NaviModeID;

	private int m_NaviMapID;

	private int m_NaviTemplateMap;

	private UINavigationUtil.UINavigationFrom m_NaviFrom;

	private string m_NaviFromInfo;

	private int m_ExpireSlotDays;

	private List<UIWorkshopTagsItemController> m_TagsItemControllers;

	private const float OverflowTagWidth = 40f;

	public SceneEditSlotInfo CurSlotInfo => null;

	private bool CodePanelEnable => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void ShowUpdateLog()
	{
	}

	private void OnShowGuide()
	{
	}

	private void OnGetFocus()
	{
	}

	private void OnLostFocus()
	{
	}

	private void OnBtnCreateRoomClick()
	{
	}

	private void OnBtnPublishClick()
	{
	}

	private void OnBtnEditClick()
	{
	}

	private void OnAuthorTagUpdate(object[] data)
	{
	}

	private void OnConfirmUserAgreement(object[] data)
	{
	}

	private void OnBtnNewClick()
	{
	}

	private bool VerifySlotInfo()
	{
		return false;
	}

	private void OnBtnChangeSlotNameClick()
	{
	}

	private void OnBtnShareClick()
	{
	}

	private void OnBtnMoreClick()
	{
	}

	private void OnBtnCopyClick()
	{
	}

	private void OnBtnSaveAsClick()
	{
	}

	private void OnBtnDetailClick()
	{
	}

	private void OnBtnUnPublishClick()
	{
	}

	private void OnBtnDelClick()
	{
	}

	private void OnBtnChecklistClick()
	{
	}

	private void OnBtnChecklistTipsClick()
	{
	}

	private void OnBtnMapPriviewToggleClick()
	{
	}

	private void OnBtnMapPriviewTipClick()
	{
	}

	private void OnPreviewStateUpdate(object[] data)
	{
	}

	private void RefreshPreviewState()
	{
	}

	private void OnBtnAllowDisclosure()
	{
	}

	private void OnBtnAllowDisclosureTips()
	{
	}

	private void OnBtnAllowRecreation()
	{
	}

	private void OnBtnAllowRecreationTips()
	{
	}

	private void OnCraftLandBtnClick()
	{
	}

	private void OnBtnUpdateLogClick()
	{
	}

	private void OnTipsBtnClick()
	{
	}

	private void OnBtnModifyCover()
	{
	}

	private void RequestDelPop(UIModelSceneEdit.EWorkshopDelType type, Action callback = null)
	{
	}

	private bool CheckOptionalDownload(bool enterCraftland = false)
	{
		return false;
	}

	private void OnSlotTypeSelected(object obj)
	{
	}

	private void OnRefresh(object[] data)
	{
	}

	private void OnSlotItemSelected(object[] data)
	{
	}

	private void ShowFreeRoomCardShareGuide()
	{
	}

	private void ShowModifyCoverGuide()
	{
	}

	private void RefreshSlotInfo()
	{
	}

	private void OnClickReviewLinkHandler(string linkTxt)
	{
	}

	private void RefreshBottomBtns()
	{
	}

	private void RefreshAuthorTag()
	{
	}

	private void RefreshIntroRedPoint()
	{
	}

	private void RefreshNameRedPoint()
	{
	}

	private void RefreshCoverRedPoint()
	{
	}

	private void RefreshGenreRedPoint()
	{
	}

	private void RefreshGenreID()
	{
	}

	private void RefreshTagTable()
	{
	}

	private void RefreshTagsRedPoint()
	{
	}

	private void RefreshBtnPublish()
	{
	}

	private void RefreshBtnChecklist()
	{
	}

	private void RefreshChecklistState()
	{
	}

	private void RefreshCraftlandLink()
	{
	}

	private void RefreshTopBtns()
	{
	}

	private void RefreshShareGuide(bool show)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void HideClassicSlot()
	{
	}

	private void ReSelectItemBySlotId(int slotId)
	{
	}

	private IEnumerator ReSelectItemByIndex(int index)
	{
		return null;
	}

	private IEnumerator OnUploadFinished(uint slotId)
	{
		return null;
	}

	private IEnumerator CheckLastCDNDownloadFailed()
	{
		return null;
	}

	private IEnumerator CheckLastEditedSlotId()
	{
		return null;
	}

	private void OnDownloadFinished(uint slotId)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public bool RefreshOptionalMapResDownloader(bool showDownloadPop = false)
	{
		return false;
	}

	private void OnUGCResDownloaderClick(List<ResourceID> resList)
	{
	}

	private void OnUGCResDownloaderTaskClick(UGCSimpleDownloadTask resDownloadTask, bool autoDownload = false)
	{
	}

	public void SetNavigationParams(int mode, int map, int template, UINavigationUtil.UINavigationFrom from, string fromInfo)
	{
	}

	private void NavigationToCreateMap()
	{
	}

	private void GotoCreatorCenter()
	{
	}

	private void GotoDataBoard()
	{
	}

	private void GotoDataBase()
	{
	}

	private void GotoCreatorCenterByTabName(string tabName, int subType)
	{
	}

	public void GotoEditName()
	{
	}

	public void GotoEditDescription()
	{
	}

	public void GotoEditCover()
	{
	}

	public void GotoEditMap()
	{
	}

	public void GotoTestMap()
	{
	}

	public void GotoGenreWnd()
	{
	}

	public void GotoTagWnd()
	{
	}

	private int ObtainExpirationDateOfExpiringSlot()
	{
		return 0;
	}

	private void OnPublishStateTipClick()
	{
	}

	private void OnGenreBtnClick()
	{
	}

	private void OnGenreTipsClick()
	{
	}

	private void OnTagBtnClick()
	{
	}

	private void OnTagTipsClick()
	{
	}

	private bool BeforeBtnClickCheck()
	{
		return false;
	}

	private void RefreshTopRightBtns()
	{
	}

	private void _003COnUIInit_003Eb__33_0(object[] data)
	{
	}

	private void _003COnUIInit_003Eb__33_1()
	{
	}

	private void _003COnBtnCreateRoomClick_003Eb__39_0(bool succeed)
	{
	}

	private void _003COnBtnEditClick_003Eb__41_0(bool b)
	{
	}

	private void _003COnBtnEditClick_003Eb__41_1()
	{
	}

	private void _003COnBtnChangeSlotNameClick_003Eb__46_0()
	{
	}

	private void _003COnBtnMoreClick_003Eb__48_0()
	{
	}

	private void _003COnBtnDetailClick_003Eb__51_0(bool succeed)
	{
	}

	private void _003COnBtnUnPublishClick_003Eb__52_0()
	{
	}

	private void _003COnBtnModifyCover_003Eb__67_0()
	{
	}

	private void _003CRefreshShareGuide_003Eb__93_0()
	{
	}

	private void _003COnGenreBtnClick_003Eb__123_0(WorkshopGenreID data)
	{
	}

	private void _003COnTagBtnClick_003Eb__125_0(List<uint> data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
