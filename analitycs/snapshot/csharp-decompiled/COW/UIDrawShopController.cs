using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIDrawShopController : UIPreviewNavigationController, IUIModelDataChangeObserver
{
	private sealed class _003CDelayScrollToSelectedTab_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDrawShopController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayScrollToSelectedTab_003Ed__39(int _003C_003E1__state)
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

	private sealed class _003CPlayTabInAnimationDelayed_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDrawShopController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayTabInAnimationDelayed_003Ed__59(int _003C_003E1__state)
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

	private const int MAX_TAB_NUM_IN_GRID = 6;

	private UIDrawShopView m_View;

	private UIModelDrawShop m_ModelDrawShop;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIModelInventory m_ModelInventory;

	private UIModelPrime m_ModelPrime;

	private UIModelBooyahPass m_ModelBooyahPass;

	private int m_SelectedTabIdx;

	private int m_LastSelectedTabIdx;

	private List<UIDrawShopTabItemController> m_TabCtrlList;

	private uint m_CurrentChestId;

	private UIDrawShopContentBaseController m_CurContent;

	private Dictionary<UIModelDrawShop.EDrawShopCachedContentType, UIDrawShopContentBaseController> m_ContentCache;

	private UIDrawShopPreviewManager m_PreviewManager;

	private bool m_IsPlayingAnimation;

	private float m_AnimPlayTime;

	private bool m_HasPlayedTabInAnim;

	private bool m_ForbidEsc;

	private int m_NavigationTargetDrawShopId;

	private uint m_NavigationTargetItemId;

	private bool m_IsAchorManuallyUpdated;

	public static List<Type> InterestedModel;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static void BeforeInit()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void Update()
	{
	}

	private void InitModels()
	{
	}

	private void RegisterEvents()
	{
	}

	private void InitPreviewManager()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void RefreshAllUI()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	private void ParseNavigationParams(UINavigationData navigationData)
	{
	}

	private void InitTabs()
	{
	}

	public void OnTabClick(int tabIndex, bool forceRefresh = false)
	{
	}

	private void RefreshTabState()
	{
	}

	private void ScrollTabToSelected()
	{
	}

	private IEnumerator DelayScrollToSelectedTab()
	{
		return null;
	}

	public void RefreshAllTabs()
	{
	}

	public void RebuildTabsKeepSelection()
	{
	}

	private int GetDefaultTabIndex()
	{
		return 0;
	}

	private int ConvertIdToTabIndex(int id)
	{
		return 0;
	}

	private uint ConvertTabIndexToId(int tabIndex)
	{
		return 0u;
	}

	public void SetSelectedTab(int tabIndex)
	{
	}

	public uint GetCurrentChestId()
	{
		return 0u;
	}

	private void RefreshCurrentScene()
	{
	}

	private UIDrawShopContentBaseController GetOrCreateContentByChestId(uint chestId)
	{
		return null;
	}

	private UIDrawShopContentBaseController CreateContentByShopType(UIModelDrawShop.EDrawShopType shopType, uint chestId)
	{
		return null;
	}

	private UIModelDrawShop.EDrawShopCachedContentType GetCachedContentType(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
		return UIModelDrawShop.EDrawShopCachedContentType.None;
	}

	private UIModelDrawShop.EDrawShopCachedContentType GetCachedTokenWheelContentType(uint chestId)
	{
		return UIModelDrawShop.EDrawShopCachedContentType.None;
	}

	private UIDrawShopContentBaseController CreateTokenWheelContent(uint chestId)
	{
		return null;
	}

	private bool HasWheelCustomType(uint chestId)
	{
		return false;
	}

	private void CloseCurrentContent()
	{
	}

	private void ClearContentCache()
	{
	}

	public void RefreshBackground(string bgUrl = "", string bgVFX = "")
	{
	}

	private void RefreshTopbar(uint id)
	{
	}

	private void PlayTabInAnimation()
	{
	}

	private IEnumerator PlayTabInAnimationDelayed()
	{
		return null;
	}

	public void SetAnimationState(bool isPlaying)
	{
	}

	private void OnDrawAnimStart()
	{
	}

	private void OnDrawAnimEnd()
	{
	}

	private void OnDrawAnimSkip()
	{
	}

	public void SetSkipMaskVisible(bool drawAnimMask, bool fullScreenAnimMask)
	{
	}

	private void OnInterfaceMaskClick()
	{
	}

	private void OnInterfaceContentMaskClick()
	{
	}

	public void OnAnimationComplete()
	{
	}

	private bool CurrentAnimationIsFullScreen()
	{
		return false;
	}

	private bool CheckNeedPlayAnimation()
	{
		return false;
	}

	private void CheckForPlayAnimation(bool needShowAnim)
	{
	}

	private void HideViewOnPlayAnimation()
	{
	}

	private void ShowViewOnOverAnimation()
	{
	}

	private void OnFullScreenAnimShowContent(object[] param)
	{
	}

	private void RefreshAnimPlayBtnView()
	{
	}

	private void OnAnimPlayBtnClick(object[] param)
	{
	}

	public void RefreshPreviewScene(bool needSkipAnimation = false)
	{
	}

	public void ShowPreviewItem(uint itemId, bool skipAnim = false)
	{
	}

	public void ShowPreviewItem(BaseItemInfo itemInfo, bool skipAnim = false, bool needSkipKillNotify = false)
	{
	}

	public void SetPreviewSceneBorder(UIWidget widget)
	{
	}

	public void PlayPreviewAnimation()
	{
	}

	public bool HasPreviewAnimation()
	{
		return false;
	}

	public bool IsPlayingFullScreenAnim()
	{
		return false;
	}

	public void SetCurrentSceneShowType(UIDrawShopSceneShowType showType)
	{
	}

	public UIDrawShopSceneShowType GetCurrentSceneShowType()
	{
		return UIDrawShopSceneShowType.Normal;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetCurrentId()
	{
		return 0u;
	}

	public bool IsPlayingAnimation()
	{
		return false;
	}

	public UIDrawShopPreviewManager GetPreviewManager()
	{
		return null;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	public UIWidget GetPreviewBorder()
	{
		return null;
	}

	public UIWidget GetLimitedPreviewBorder()
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

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private uint TabIdx2ChestID(int tabIdx)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public FrontEndPreviewComponent _003C_003EiFixBaseProxy_GetFrontEndPreviewComponent()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
