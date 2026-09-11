using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDressUpMainWindowController : UIPreviewNavigationController, IUIModelDataChangeObserver, IEasyList, INewVaultMultiSelectComponent
{
	public enum EquipState
	{
		Common,
		Disable,
		AlreadyEquip,
		CommonWithMultiSelect
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__30_0;

		public static Converter<uint, int> _003C_003E9__31_0;

		public static Action _003C_003E9__62_0;

		internal void _003COvrideNavgateCloseFunc_003Eb__30_0()
		{
		}

		internal int _003CInitUIData_003Eb__31_0(uint n)
		{
			return 0;
		}

		internal void _003CTryShowTutorial_003Eb__62_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public Action callback;

		public UIDressUpMainWindowController _003C_003E4__this;

		internal void _003CManualGotoOtherFunc_003Eb__0()
		{
		}

		internal void _003CManualGotoOtherFunc_003Eb__1()
		{
		}
	}

	private sealed class _003CMovePanelShowColor_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDressUpMainWindowController _003C_003E4__this;

		public int posY;

		private int _003CminDelta_003E5__2;

		private int _003CmoveSpeed_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMovePanelShowColor_003Ed__37(int _003C_003E1__state)
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

	private UIDressUpMainWindowView m_View;

	private UIModelDressUp m_model;

	private UIModelTailor m_ModelTailor;

	private UIModelAvatar m_ModelAvatar;

	private UIModelNewVault m_modelNewVault;

	private UIModelInventory m_modelInventory;

	private UIModelRandomCollection m_modelRandomCollection;

	private EquipState m_state;

	private bool m_IsOpenMultiSelect;

	private const string WEBVIEWTUTORIALKEY = "WebViewTutorialKeyDressUp";

	private uint m_DelayCallShow;

	private uint m_DelayCallAvatarShow;

	private bool m_IsHideBackpack;

	private Dictionary<int, List<int>> m_dicSortItems;

	private UIDressUpVaultSecondTabController m_TabCtrl;

	private FrontEndPreviewComponent_Dressup m_FrontEndPreviewComponent_Dressup;

	private List<int> m_showlist;

	private UIModelNewVault.eSecondTab m_CurrentTab;

	private bool m_ForceRefreshTab;

	private List<UIDressUpSlotItemController> m_DressUpSlotItemListCtrl;

	private List<UIDressUpExchangeItemController> m_DressUpExchangeItemListCtrl;

	private bool m_firsttime;

	private bool m_IsColorPanelShow;

	private Coroutine m_CoroutineMovePanelShowColor;

	private UIColorPaletteController m_TailorColorPalette;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	public void ManualGotoOtherFunc(Action callback)
	{
	}

	public void OvrideNavgateCloseFunc()
	{
	}

	private void InitUIData()
	{
	}

	private void OnCloseTips(UIModelNewVault.eSecondTab obj)
	{
	}

	private void OnIfSeriesItemChosen(object[] data)
	{
	}

	private void OnBtnColorPanelClick()
	{
	}

	private void ScrollColorPanel(bool show)
	{
	}

	private void SetPanelColorShow(int posY)
	{
	}

	private IEnumerator MovePanelShowColor(int posY)
	{
		return null;
	}

	private void RefreshColorPanel(uint legendId)
	{
	}

	public void ForceRefreshTab()
	{
	}

	private void OnSeriesItemChangeIndex(object[] data)
	{
	}

	private void OnClickFirstTab(int index)
	{
	}

	private void OnClickItemData(int id)
	{
	}

	private void OnlyRefreshFirstTab()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	public void RefreshLeftUI()
	{
	}

	public void RefreshRightUI(bool forceRefreshSlot = false)
	{
	}

	private void RefreshExchangeUIList(bool forceRefresh = false)
	{
	}

	private void RefreshSlotUIList(bool forceRefresh = false)
	{
	}

	private void RefreshItemById(object[] data)
	{
	}

	private List<uint> TempEquipCacheItemid(uint id)
	{
		return null;
	}

	private void RefreshCollection(uint id)
	{
	}

	private void OnRefreshCollection(object[] data)
	{
	}

	private void OnRefreshRightUI(object[] data)
	{
	}

	private void RefreshEquipAvatar(object[] data)
	{
	}

	private void RefreshDressupAvatar(object[] data)
	{
	}

	private void OnRefreshHair(object[] data)
	{
	}

	public void ReFreshAvatar(uint tempItemID = 0u, uint overridebackpackid = 0u)
	{
	}

	private void OnEquipClick()
	{
	}

	private void OnSaveClick()
	{
	}

	public void RefreshEquipState()
	{
	}

	public void RefreshSaveState()
	{
	}

	private void TryShowTutorial()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void OnRefreshAllDressUp(object[] data)
	{
	}

	private void ForceRefreshSlotAfterGetEvoPass()
	{
	}

	private void OnRefreshBackPack(object[] data)
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void OnPreviewDownloadFinished(object[] data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	public bool IsMultiSelectOpen()
	{
		return false;
	}

	public void RefreshMultiSelectLabel()
	{
	}

	private void RefreshMultiSelectIsOpen()
	{
	}

	private void _003COvrideNavgateCloseFunc_003Eb__30_1()
	{
	}

	private void _003CRefreshColorPanel_003Eb__38_0()
	{
	}

	private void _003COnNavigationShowed_003Eb__63_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public FrontEndPreviewComponent _003C_003EiFixBaseProxy_GetFrontEndPreviewComponent()
	{
		return null;
	}
}
