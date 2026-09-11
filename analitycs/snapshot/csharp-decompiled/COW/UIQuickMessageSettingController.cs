using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIQuickMessageSettingController : UINavigationController, IUIModelDataChangeObserver
{
	public class QuickMessageItem2List : IEasyList
	{
		private UIQuickMessageSettingController m_Owner;

		public QuickMessageItem2List(UIQuickMessageSettingController owner)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}
	}

	public class QuickMessageTabItem : IEasyList
	{
		private UIQuickMessageSettingController m_Owner;

		private EQuickChatMainTab m_MainTab;

		public QuickMessageTabItem(UIQuickMessageSettingController owner, EQuickChatMainTab mainTab)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass180_0
	{
		public uint groupId;

		internal bool _003CScrollToCustomizationItemByMsgId_003Eb__0(uint g)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass184_0
	{
		public UIScrollView scrollView;

		internal void _003CScrollTo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass185_0
	{
		public IngameQuickChatItemData customizationData;

		public IngameQuickChatData basicData;

		internal bool _003COnItemClickOrDragRefreshTabView_003Eb__0(uint g)
		{
			return false;
		}

		internal bool _003COnItemClickOrDragRefreshTabView_003Eb__1(uint g)
		{
			return false;
		}
	}

	private sealed class _003CAutoScrollCo_003Ed__156 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIQuickMessageSettingController _003C_003E4__this;

		public int value;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoScrollCo_003Ed__156(int _003C_003E1__state)
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

	private sealed class _003CFirstCreateUI_003Ed__190 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIQuickMessageSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CFirstCreateUI_003Ed__190(int _003C_003E1__state)
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

	private UIQuickMessageSettingView _003Cm_View_003Ek__BackingField;

	private UIModelQuickMessage m_QuickMsgModel;

	private List<uint> m_IdListCache;

	private Action m_PlayVoiceEndDelegate;

	private List<CSVBaseData> m_MsgPanelDatas;

	private List<UIQuickMessageItem3Controller> m_Item3Ctrls;

	private GameObject m_MiddleArrowVfx;

	private readonly uint m_DefaultMsgId;

	private UINewDownloadInfoController m_DownloadCtrl;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private EQuickChatCategory m_CurCategory;

	private EQuickChatMainTab m_CurMainTab;

	private uint m_CustomizationMsgId;

	private bool m_ForceRefreshCustomization;

	private bool m_ForceRefreshBasic;

	private bool m_CurIsListPanel;

	private bool m_FirstInit;

	private Vector2 m_MsgSplitlineSize;

	private Vector2 m_MsgItemSize;

	private List<uint> m_CustomizationGroupIds;

	private List<uint> m_BasicGroupIds;

	private HashSet<uint> m_NeedSetRedTipsItemSet;

	private uint _003CCurSelectBasicGroupId_003Ek__BackingField;

	private uint _003CCurSelectCustomizationGroupId_003Ek__BackingField;

	private bool _003CIsStartPlayVoice_003Ek__BackingField;

	private uint? _003CCurPlayingMsgId_003Ek__BackingField;

	private bool _003CCurPlayingIsFromLeft_003Ek__BackingField;

	private int m_CurPlayingTicked;

	private uint m_CurPlayingVoiceDelayCall;

	public HashSet<uint> EquippedIds;

	private bool _003CIsChangeMsgPanelInThisFrame_003Ek__BackingField;

	private UIModelQuickMessage.ChangeMsgOp? _003CChangeMsgOp_003Ek__BackingField;

	private bool _003CIsDraging_003Ek__BackingField;

	private uint? _003CDragMsgId_003Ek__BackingField;

	private uint? _003CDragMsgItemType_003Ek__BackingField;

	private int? _003CDragStartIdx_003Ek__BackingField;

	private int? _003CDragOverIdx_003Ek__BackingField;

	private int? _003CPreDragOverIdxInList_003Ek__BackingField;

	private int? _003CDragOverIdxInList_003Ek__BackingField;

	public const int InValidContainerIdx = -1;

	public const int ListTopContainerIdx = -2;

	public const int ListBottomContainerIdx = -3;

	private const float DragScrollDelta = 20f;

	public bool IsInClicking;

	private uint? _003CClickStartMsgId_003Ek__BackingField;

	private uint? _003CClickEndMsgId_003Ek__BackingField;

	private uint? _003CClickStartMsgItemType_003Ek__BackingField;

	private int? ClickStartMsgIdx;

	public string NaviFrom;

	private Action m_AfterClose;

	private Coroutine m_AutoScrollCo;

	private bool m_IsInGuiding;

	private UICommonGuideController m_GuideCtrl;

	private UITutorialIndicatorHandController m_Guide1Anim;

	public UIQuickMessageSettingView m_View
	{
		get
		{
			return _003Cm_View_003Ek__BackingField;
		}
		private set
		{
			_003Cm_View_003Ek__BackingField = value;
		}
	}

	private static string OpenFromSetting => null;

	private static string OpenFromLoadout => null;

	private static string AlreadyShowResDownloadPop => null;

	private static string QuickMessageGuide => null;

	public uint CurSelectBasicGroupId
	{
		get
		{
			return _003CCurSelectBasicGroupId_003Ek__BackingField;
		}
		private set
		{
			_003CCurSelectBasicGroupId_003Ek__BackingField = value;
		}
	}

	public uint CurSelectCustomizationGroupId
	{
		get
		{
			return _003CCurSelectCustomizationGroupId_003Ek__BackingField;
		}
		private set
		{
			_003CCurSelectCustomizationGroupId_003Ek__BackingField = value;
		}
	}

	public bool IsStartPlayVoice
	{
		get
		{
			return _003CIsStartPlayVoice_003Ek__BackingField;
		}
		private set
		{
			_003CIsStartPlayVoice_003Ek__BackingField = value;
		}
	}

	public uint? CurPlayingMsgId
	{
		get
		{
			return _003CCurPlayingMsgId_003Ek__BackingField;
		}
		private set
		{
			_003CCurPlayingMsgId_003Ek__BackingField = value;
		}
	}

	public bool CurPlayingIsFromLeft
	{
		get
		{
			return _003CCurPlayingIsFromLeft_003Ek__BackingField;
		}
		private set
		{
			_003CCurPlayingIsFromLeft_003Ek__BackingField = value;
		}
	}

	public bool IsChangeMsgPanelInThisFrame
	{
		get
		{
			return _003CIsChangeMsgPanelInThisFrame_003Ek__BackingField;
		}
		private set
		{
			_003CIsChangeMsgPanelInThisFrame_003Ek__BackingField = value;
		}
	}

	public UIModelQuickMessage.ChangeMsgOp? ChangeMsgOp
	{
		get
		{
			return _003CChangeMsgOp_003Ek__BackingField;
		}
		private set
		{
			_003CChangeMsgOp_003Ek__BackingField = value;
		}
	}

	public bool IsDraging
	{
		get
		{
			return _003CIsDraging_003Ek__BackingField;
		}
		private set
		{
			_003CIsDraging_003Ek__BackingField = value;
		}
	}

	public uint? DragMsgId
	{
		get
		{
			return _003CDragMsgId_003Ek__BackingField;
		}
		private set
		{
			_003CDragMsgId_003Ek__BackingField = value;
		}
	}

	public uint? DragMsgItemType
	{
		get
		{
			return _003CDragMsgItemType_003Ek__BackingField;
		}
		private set
		{
			_003CDragMsgItemType_003Ek__BackingField = value;
		}
	}

	public int? DragStartIdx
	{
		get
		{
			return _003CDragStartIdx_003Ek__BackingField;
		}
		private set
		{
			_003CDragStartIdx_003Ek__BackingField = value;
		}
	}

	public int? DragOverIdx
	{
		get
		{
			return _003CDragOverIdx_003Ek__BackingField;
		}
		private set
		{
			_003CDragOverIdx_003Ek__BackingField = value;
		}
	}

	public int? PreDragOverIdxInList
	{
		get
		{
			return _003CPreDragOverIdxInList_003Ek__BackingField;
		}
		private set
		{
			_003CPreDragOverIdxInList_003Ek__BackingField = value;
		}
	}

	public int? DragOverIdxInList
	{
		get
		{
			return _003CDragOverIdxInList_003Ek__BackingField;
		}
		private set
		{
			_003CDragOverIdxInList_003Ek__BackingField = value;
		}
	}

	public uint? ClickStartMsgId
	{
		get
		{
			return _003CClickStartMsgId_003Ek__BackingField;
		}
		private set
		{
			_003CClickStartMsgId_003Ek__BackingField = value;
		}
	}

	public uint? ClickEndMsgId
	{
		get
		{
			return _003CClickEndMsgId_003Ek__BackingField;
		}
		private set
		{
			_003CClickEndMsgId_003Ek__BackingField = value;
		}
	}

	public uint? ClickStartMsgItemType
	{
		get
		{
			return _003CClickStartMsgItemType_003Ek__BackingField;
		}
		private set
		{
			_003CClickStartMsgItemType_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void InitMsgTemplate()
	{
	}

	private void InitQuickMessageItem3Ctrl()
	{
	}

	private void InitAnchor()
	{
	}

	public static bool CheckNeedSave(Action afterClose)
	{
		return false;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void OnNavigationShowedNext()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	private void PopConfirmSaveWnd()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnCategoryChange(EQuickChatCategory category)
	{
	}

	private void OnMainTabChange(EQuickChatMainTab mainTab)
	{
	}

	private void OnMsgPanelChange()
	{
	}

	private void OnVocalChange()
	{
	}

	private void OnSaveBtnClick()
	{
	}

	private void SecondConfirmSave(bool save)
	{
	}

	private void SetDataHasChange(bool hasChange)
	{
	}

	private bool GetDataHasChange()
	{
		return false;
	}

	private void ShowVocalIcon(bool forceSample = false)
	{
	}

	private void ShowVocalTips()
	{
	}

	private void ShowMsgList()
	{
	}

	private void ShowMsgPanel(bool refreshEasyList = false)
	{
	}

	public void OnItemClick(uint msgId, uint itemType, int? msgIdx)
	{
	}

	private void OnItemClickStart(uint msgId, uint itemType, int? msgIdx)
	{
	}

	private void OnItemClickEnd(uint? msgId = null, uint? itemType = null, int? msgIdx = null, bool refreshUI = false)
	{
	}

	private bool PlayVoice(uint msgId, bool isFromLeft)
	{
		return false;
	}

	private void PlayVoiceEnd()
	{
	}

	public void OnMsgDragStart(uint msgId, uint msgFromWhere)
	{
	}

	public void OnMsgDragHover(int containerIdx)
	{
	}

	private void TryVibrate(int lastContainerIdx)
	{
	}

	public void OnMsgDragMove(Vector3 pos)
	{
	}

	public void OnMsgDragRelease()
	{
	}

	private void ShowDragItem(bool isValid)
	{
	}

	private void HideDragItem()
	{
	}

	private void TryStartAutoScroll(int containerIdx)
	{
	}

	private IEnumerator AutoScrollCo(int value)
	{
		return null;
	}

	private void ListMsgHover(int containerIdx)
	{
	}

	private void ShowMiddleArrowVfxByMsgType(uint msgItemType)
	{
	}

	private void HideMiddleArrowVfx()
	{
	}

	public static void InitRedTips()
	{
	}

	public static void RemoveLoadoutRedTips()
	{
	}

	public static void RemoveSettingRedTips()
	{
	}

	private void TryShowGuide1()
	{
	}

	private void TryCloseGuide1()
	{
	}

	private void TryShowGuide2()
	{
	}

	private void SetGuideFLagFalse()
	{
	}

	private void TryShowDownloadPopWnd()
	{
	}

	private void DownloadSecondConfirmWnd()
	{
	}

	private void RefreshDownloadStatus()
	{
	}

	private List<ResourceID> GetNeedDownloadRes()
	{
		return null;
	}

	private void DownloadRes()
	{
	}

	private void RefreshBasicMsgUI()
	{
	}

	private string GetBasicMsgTabName(uint tab)
	{
		return null;
	}

	public void ScrollToBasicItemByGroupId(uint groupId)
	{
	}

	private void RefreshMsgBasicTabEasyListView(int index)
	{
	}

	private void RefreshMsgCustomizationUI()
	{
	}

	private void ScrollToCustomizationItemByMsgId()
	{
	}

	public void ScrollToCustomizationItemByGroupId(uint groupId)
	{
	}

	private void RefreshMsgCustomizationTabEasyListView(int index)
	{
	}

	private int SortIngameQuickChatItemData(IngameQuickChatItemData a, IngameQuickChatItemData b)
	{
		return 0;
	}

	private void ScrollTo(Vector3 pos, UIScrollView scrollView)
	{
	}

	private void OnItemClickOrDragRefreshTabView(uint msgId, uint itemType)
	{
	}

	private void OnItemClickOrDragSetRedTips(uint msgId, uint itemType)
	{
	}

	public void AddNeedSetRedTipsItem(uint msgId)
	{
	}

	private void RemoveNeedSetRedTipsItem(uint msgId)
	{
	}

	private void SetNeedSetRedTipsItems()
	{
	}

	private IEnumerator FirstCreateUI()
	{
		return null;
	}

	private void ForceRefrshMsgForExpireItemWhenSave()
	{
	}

	private void _003COnUIInit_003Eb__114_0()
	{
	}

	private void _003COnUIInit_003Eb__114_1()
	{
	}

	private void _003COnUIInit_003Eb__114_2()
	{
	}

	private void _003COnUIInit_003Eb__114_3()
	{
	}

	private void _003COnUIInit_003Eb__114_4()
	{
	}

	private void _003COnUIInit_003Eb__114_5()
	{
	}

	private void _003COnUIInit_003Eb__114_6()
	{
	}

	private bool _003COnUIInit_003Eb__114_7()
	{
		return false;
	}

	private UITable2.IUITable2Item _003CInitMsgTemplate_003Eb__116_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitMsgTemplate_003Eb__116_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitMsgTemplate_003Eb__116_2()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitMsgTemplate_003Eb__116_3()
	{
		return null;
	}

	private void _003CPopConfirmSaveWnd_003Eb__127_0()
	{
	}

	private void _003CPopConfirmSaveWnd_003Eb__127_1()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}
}
