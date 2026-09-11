using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBigEvent_GlobalProgressController : UINavigationController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	private enum ShareStatus
	{
		Sharing = 1,
		Submit = 2,
		Receive = 4
	}

	private UIBigEvent_GlobalProgressView m_View;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIModelBigEvent_GlobalProgress m_UIModelBigEvent_GlobalProgress;

	private List<UIBigEvent_GlobalProgress_BtnItemController> m_LeftBtnControllers;

	private List<UIBigEvent_GlobalProgress_BarItemController> m_BarRewardItemControllers;

	private UIStandardAdsController m_AdsCtrl;

	private UIBigEvent_GlobalProgress_TokenItemController m_TokenCtrl;

	private const int AdsDotWidth = 33;

	private const int AdsDotHeight = 5;

	private const int AdsGridCellWidth = 38;

	private const int m_AdsContentColliderWidth = 580;

	private const int m_AdsContentColliderHeight = 420;

	private const int m_ContentWidth = 580;

	private const int m_ContentHeight = 420;

	private const int AdsTextureWidth = 580;

	private const int AdsTextureHeight = 420;

	private bool m_HasInitTemplateUI;

	private UIMechadrakeB_FirstInAnimController m_FirstAnimController;

	private uint m_FirstInAnimDelayCall;

	private uint m_PlayEnterAnimDelayCall;

	private uint m_EntryAnimDelayCall;

	private ResourceID m_GPMainBgVFXResID;

	private GameObject m_GPMainBgVFXGO;

	private ResourceID m_GPTextureTitleVFXResID;

	private GameObject m_GPTextureTitleVFXGO;

	private uint m_GPTextureTitleDelayCallID;

	private ResourceID m_GPProgressBGVFXResID;

	private GameObject m_GPProgressBGVFXGO;

	private ResourceID m_GPExchangeStoreVFXResID;

	private GameObject m_GPExchangeStoreVFXGO;

	private ResourceID m_GPProgressBarVFXResID;

	private GameObject m_GPProgressBarVFXGO;

	private UIModelBigEvent_GlobalProgress.EntranceSpineGo m_EntranceSpineGo;

	private uint m_ShareStatus;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	private EBigEventTemplateType _003CTemplateType_003Ek__BackingField;

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

	public EBigEventTemplateType TemplateType
	{
		get
		{
			return _003CTemplateType_003Ek__BackingField;
		}
		set
		{
			_003CTemplateType_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected void OnLoadingMaskWndCloseCallback(object[] data)
	{
	}

	private bool IsNeedPlayFirstInAnim()
	{
		return false;
	}

	private void TryPlayFirstInAnim()
	{
	}

	private void PlayEnterAnim()
	{
	}

	private void TweenOutMainView()
	{
	}

	private void CreateSpine()
	{
	}

	public void PlaySpineAnimation()
	{
	}

	private bool LoadGPMainBGVFX()
	{
		return false;
	}

	private bool LoadGPTextureTitleVFX()
	{
		return false;
	}

	private bool LoadGPProgressBGVFX()
	{
		return false;
	}

	private bool LoadGPExchangeStoreVFX()
	{
		return false;
	}

	private bool LoadGPProgressBarVFX()
	{
		return false;
	}

	private void ExecuteGotoNavigation()
	{
	}

	private void ShowPeakDayPopWnd()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void ClearAnimDelayKey()
	{
	}

	public override void OnShare(bool success, int platform)
	{
	}

	public override void OnCopyShareLink(bool success)
	{
	}

	public override void OnSaveSharePhoto(bool success)
	{
	}

	private void SubmitShareActivity()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshRedDots()
	{
	}

	protected virtual void RefreshMissionRedPoint()
	{
	}

	private void RefreshExchangeStoreRedPoint()
	{
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

	private void RefreshTokenView()
	{
	}

	private void OnClickBtnRule()
	{
	}

	private void OnClickBtnClose()
	{
	}

	private void OnFirstInAnimationStoped(object[] data)
	{
	}

	private void OnClickStandardAds(object[] data)
	{
	}

	private void RefreshShareRed()
	{
	}

	private void OnClickBtnShare()
	{
	}

	private void DoShare(ClientActivityDesc clientActivityDesc)
	{
	}

	private void OnShareClose()
	{
	}

	private void OnClickBtnMission()
	{
	}

	private void OnClickBtnExchange()
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

	private void _003CTryPlayFirstInAnim_003Eb__37_0()
	{
	}

	private void _003COnTemplateUIInit_003Eb__92_0()
	{
	}

	private void _003COnTemplateUIInit_003Eb__92_1()
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

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShare(bool P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCopyShareLink(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSaveSharePhoto(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
