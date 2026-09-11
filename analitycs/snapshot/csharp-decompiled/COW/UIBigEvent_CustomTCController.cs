using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIBigEvent_CustomTCController : UINavigationController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	private UIBigEvent_CustomTCView m_View;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIModelBigEvent_CustomTC m_UIModelCustomTC;

	private List<UIBaseController> m_LeftBtnControllers;

	private UIBigEvent_CustomTC_MainController m_CustomTCMainController;

	private UIBigEvent_CustomTC_MissionBtnItemController m_CustomTCMissionBtnController;

	private UIBigEvent_CustomTC_TutorialBtnItemController m_TutorialBtnCtrl;

	private UICommonGuideController m_GuideController;

	private bool m_NeedGuide;

	private const string TC_VIEW_IN_ANIM = "UIFX_Jumpsuit23B_TCContent_01";

	private UIBigEvent_CustomTC_TokenItemController m_DrawTokenCtrl;

	private int audio_track;

	private bool m_hasInitTemplateUI;

	private bool m_hasLodaingPanelClose;

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

	protected override void OnUIDestory()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void InitCoutomTCInfo()
	{
	}

	protected void OnFirstComeinAnimationClose(object[] data)
	{
	}

	protected void OnOpenAnimationClose(object[] data)
	{
	}

	private void ShowOpenPopWnd()
	{
	}

	private void PlayAnimationIn()
	{
	}

	private void PlayAnimationFirstIn()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnRuleBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void InitEffect()
	{
	}

	private void InitTokenOwnedShowState()
	{
	}

	private void InitCloseBtnShowState()
	{
	}

	private void InitLeftTopTitleCDNAndOpenTime()
	{
	}

	private void RefreshGridLeftBtns()
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	private void StartGuide()
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

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
