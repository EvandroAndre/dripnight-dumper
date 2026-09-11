using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIUGCBigEvent_GlobalProgressController : UINavigationController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	private UIUGCBigEvent_GlobalProgressView m_View;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIUGCModelBigEvent_GlobalProgress m_UIModelBigEvent_GlobalProgress;

	private List<UIUGCBigEvent_GlobalProgress_BtnItemController> m_LeftBtnControllers;

	private List<UIUGCBigEvent_GlobalProgress_BarItemController> m_BarRewardItemControllers;

	private UIStandardAdsController m_AdsCtrl;

	private UIUGCBigEvent_GlobalProgress_TokenItemController m_TokenCtrl;

	private const int AdsDotWidth = 33;

	private const int AdsDotHeight = 5;

	private const int AdsGridCellWidth = 38;

	private const int AdsTextureWidth = 540;

	private const int AdsTextureHeight = 272;

	private bool m_HasInitTemplateUI;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshView()
	{
	}

	private void RefreshProgressBar()
	{
	}

	private void RefreshGridLeftBtns()
	{
	}

	private void RefreshAdPanel()
	{
	}

	private void RefreshTokenView()
	{
	}

	private void OnClickBtnRule()
	{
	}

	private void OnClickBtnClose()
	{
	}

	private void OnClickStandardAds(object[] data)
	{
	}

	private void OnClickBtnShare()
	{
	}

	private void SetShareBgView(bool show)
	{
	}

	private void OnGotoNavigation(uint entranceType)
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	private void RefreshUGCStyle()
	{
	}

	private void _003COnTemplateUIInit_003Eb__37_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
