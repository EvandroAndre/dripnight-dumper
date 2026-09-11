using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIVirtualBrandShowCaseController : UIPreviewNavigationController, IEasyList, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public uint setId;

		internal bool _003CShowItemSelected_003Eb__0(uint value)
		{
			return false;
		}
	}

	private sealed class _003CPlayEntranceAnim_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIVirtualBrandShowCaseController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayEntranceAnim_003Ed__67(int _003C_003E1__state)
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

	private sealed class _003CPlaySetItemAnim_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIVirtualBrandShowCaseController _003C_003E4__this;

		public bool play;

		private WaitForSeconds _003CwaitTime_003E5__2;

		private UIEasyListItemController[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlaySetItemAnim_003Ed__66(int _003C_003E1__state)
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

	private UIVirtualBrandShowCaseView m_View;

	private UIModelVirtualBrand m_ModelVirtualBrand;

	private UIModelInventory m_ModelInventory;

	private UIVirtualBrandShowCaseObtainSetController m_ObtainSetCtrl;

	private uint m_CurSetId;

	private uint m_CurBrandId;

	private uint m_LastBrandId;

	private const string LOCAL_SAVE_OWNED_SET_KEY = "VirtualBrandOwnedSet";

	private const string LOCAL_SAVE_CAN_SKIP_ANIM = "VirtualBrandShowCaseCanSkipAnim";

	private const string OWN_KEY = "T_36_DY_VB_OWNED";

	private const string TAKEN_DOWN_KEY = "T_36_DY_VB_TAKENDOWN";

	private const string WARM_UP_TIPS_KEY = "T_37_DY_COMINGSOON";

	private const string COLLECTION_VALUE_TIPS_KEY = "T_36_DY_VB_ REGULATION";

	private bool m_IsPlayEntranceEffect;

	private bool m_WaitForInfo;

	private bool m_GetItemChannelHttpReady;

	private const float ENTRANCE_EFFECT_TIME = 3.5f;

	private const float SET_ITEM_ANIM_TIME = 0.1f;

	private GameObject m_EntranceEffect;

	private Coroutine m_EntranceAnimCor;

	private Coroutine m_SetItemAnimCor;

	private GameObject m_frontEffectGo;

	private BrandShowCaseTabType m_CurSelectedTab;

	private List<UIVirtualBrandShowCaseTabBtnController> m_TabControllers;

	private UIVirtualBrandSwitchController m_SwitchCtrl;

	private UIVirtualBrandCollectionValueBtnController m_ValueBtn;

	private bool m_IsBrandChanged;

	private bool m_NeedAnim;

	private bool m_HasSetNaviBar;

	private uint m_GuideDelayCallTid;

	public const string VIRTUAL_BRAND_PREVIEW_GUIDE = "VIRTUAL_BRAND_PREVIEW_GUIDE_{0}";

	private readonly Queue<UICommonGuideData> m_GuideDataQueue;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	private void SetCurBrand(uint brandID)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public uint GetCurSetId()
	{
		return 0u;
	}

	private void OnAbReady()
	{
	}

	private void ShowCurrentBrand()
	{
	}

	private void ShowFrontEffect(ResourceID resID, Vector3 offset, Vector3 scale)
	{
	}

	private void SetNaviBar()
	{
	}

	public void SetViewData()
	{
	}

	private void ClearUI()
	{
	}

	private void ShowItems()
	{
	}

	private void ShowObtainNewSet()
	{
	}

	private void ShowTabAndItem()
	{
	}

	private void OnClickTab(BrandShowCaseTabType tab)
	{
	}

	private void RefreshTabView()
	{
	}

	private void RequestChannelinfo(uint brandId)
	{
	}

	private void SetCollectionValueView()
	{
	}

	private void SetBrandSwitch()
	{
	}

	protected override bool NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}

	public override bool IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void OnBtnStoryClick()
	{
	}

	private void OnBtnSkipClick()
	{
	}

	private void OnBtnObtainClick()
	{
	}

	private void OnBtnBackClick()
	{
	}

	private void OnBrandSwitchClick(uint targetBrand)
	{
	}

	private void ShowPreviewUI(bool isShow)
	{
	}

	private void ShowItemSelected(uint setId, bool isSelected)
	{
	}

	private void OnSetItemSelected(object[] data)
	{
	}

	private IEnumerator PlaySetItemAnim(bool play)
	{
		return null;
	}

	private IEnumerator PlayEntranceAnim()
	{
		return null;
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

	private void OnConfirmWndClose()
	{
	}

	private void BackToBrandLogos()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private bool _003COnClickTab_003Eb__50_0(UIVirtualBrandShowCaseTabBtnController x)
	{
		return false;
	}

	private bool _003CRefreshTabView_003Eb__51_0(uint value)
	{
		return false;
	}

	private bool _003COnBtnBackClick_003Eb__61_0(uint value)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
