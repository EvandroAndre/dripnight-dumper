using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIShoppingMallController : UICGPlayableNavigationController, IUIModelDataChangeObserver
{
	public enum ShoppingMallItemTemplateType
	{
		ShoppingMallItemMax = 1,
		ShoppingMallItemNormal,
		ShoppingMallItemMin
	}

	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public UIShoppingMallController _003C_003E4__this;

		public List<ResourceID> resList;

		internal void _003CRefreshAnimPlayBtnView_003Eb__0()
		{
		}
	}

	private UIShoppingMallView m_View;

	private UIModelShoppingMall m_ModelShoppingMall;

	private ShoppingMallScreenDesc m_ShoppingMallMainPageItem;

	private UINewDownloadInfoController m_AnimDownloadCtrl;

	private int m_LastIndex;

	private ResourceID m_AnimRes;

	private bool m_CGReady;

	private bool m_HasShow;

	private uint m_DelayCall;

	private bool m_PlayCGToVoidPreview;

	private bool m_NeedResetTimer;

	private bool m_IsLowestQuality;

	private bool m_HadPlayCG;

	public const string SHOW_ANIM_KEY = "ShowAnim_ShoppingMall_";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override uint GetUINavigationPageType()
	{
		return 0u;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void RefreshShoppingMallItem()
	{
	}

	private void RefreshMainPageView()
	{
	}

	protected override bool DelayPreview()
	{
		return false;
	}

	private void InitIsLowestQuality()
	{
	}

	private void HideAllItem()
	{
	}

	private void ShowAvatarPerview(uint ItemId)
	{
	}

	private void ShowChannelIcon(uint ChannelType)
	{
	}

	private void ShowTag(uint TagType, uint Discount)
	{
	}

	private void TagClear()
	{
	}

	private void ShowRareIcon(uint id, bool isShow)
	{
	}

	private void AutoScrollViewToDown()
	{
	}

	private void OnScrollViewDragStarted()
	{
	}

	private void OnRightClickBtnClick()
	{
	}

	private void OnChannelBtnClick()
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void InitShoppingMallItemTemplate()
	{
	}

	private UIShoppingMallItemMaxController OpenShoppingMallItemMax()
	{
		return null;
	}

	private UIShoppingMallItemNormalController OpenShoppingMallItemNormal()
	{
		return null;
	}

	private UIShoppingMallItemMinController OpenShoppingMallItemMin()
	{
		return null;
	}

	private void RefreshPlayCG()
	{
	}

	private void CGPlayAndHideUI()
	{
	}

	private void SetUIState(bool state)
	{
	}

	private void SetTopBarState(bool state)
	{
	}

	private void HidePreview()
	{
	}

	private void OnInterfaceMaskClick()
	{
	}

	private void CGFinishAndShowUI()
	{
	}

	private void OnAnimOver(object[] data)
	{
	}

	private void RefreshAnimPlayBtnView()
	{
	}

	private void OnAnimPlayBtnClick()
	{
	}

	private UITable2.IUITable2Item _003CInitShoppingMallItemTemplate_003Eb__39_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitShoppingMallItemTemplate_003Eb__39_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitShoppingMallItemTemplate_003Eb__39_2()
	{
		return null;
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

	public bool _003C_003EiFixBaseProxy_DelayPreview()
	{
		return false;
	}
}
