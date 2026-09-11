using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaController : UIPreviewNavigationController, IUIModelDataChangeObserver
{
	private class CouponInsufficientPopUpInfo
	{
		public uint ChestID;

		public UIModelGacha.GachaDrawType DrawType;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<CSSharedItemData, uint> _003C_003E9__78_0;

		internal uint _003CShowGachaCouponInsufficientPopUp_003Eb__78_0(CSSharedItemData coupon)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass85_0
	{
		public UIGachaController _003C_003E4__this;

		public bool needShowAnim;

		internal void _003CRefreshGachaScene_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass94_0
	{
		public uint tokenItemID;

		internal void _003CRefreshLimitPoolGotoToken_003Eb__0()
		{
		}
	}

	private const string SHOW_ANIM_KEY = "ShowAnim_Gacha_";

	private const int MAXTABNUMINGRID = 6;

	private const int MAXCOUPONCOUNT = 3;

	private UIGachaView m_View;

	private UIModelGacha m_ModelGacha;

	private UIModelIchis m_ModelIchis;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIModelInventory m_ModelInventory;

	private uint m_LimitPoolGotoTokenChestID;

	private int m_SelectedTabIdx;

	private int m_LastSelectedTabIdx;

	private uint m_SelectedChestID;

	private bool m_NeedShowFilteredGachaTips;

	private List<UIGachaTabItemController> m_TabCtrlList;

	private UIGachaNormalContent m_NormalContentCtrl;

	private UIGachaTurntableContent m_TurntabelContentCtrl;

	private UIGachaLimitContent m_LimitContentCtrl;

	private UIGachaTokenContent m_TokenContentCtrl;

	private UIGachaLimitChestContentController m_limitChestContentCtrl;

	private UIGachaUnlimitedChestContentController m_UnlimitedChestContentCtrl;

	private UIGachaIIVTWContentController m_IIVTWContentCtrl;

	private UIGachalegendaryNewContentController m_LegendaryContentCtrl;

	private UIGachaELS_TT53ContentController m_ELSContentCtrl;

	private UIGachaDoubleWheelContentController m_DoubleWheelContentCtrl;

	private UISH_GachaContentController m_SH_GachaContentCtrl;

	private UINinth_GachaContentController m_NinthGachaContentCtrl;

	private UIRM26_TW_GachaContentController m_RM26TWGachaContentCtrl;

	private UIGachaIchisChestContentController m_IchisContentCtrl;

	private UIGachaIchis55ChestContentController m_Ichis55ContentCtrl;

	private UIGachaContentBase m_CurContent;

	private ILuckySpinContent m_LuckySpinContent;

	public UIGachaPreviewManager GachaPreviewManager;

	private float m_CGPlayTime;

	private bool m_IsActive;

	private float m_EnterTime;

	private bool m_LoggedWaitNetTime;

	private uint m_GoPosGachaRewradItemId;

	private bool m_ForbidEsc;

	private FrontendPreviewType m_FrontendPreviewType;

	private Vector3 m_OriginalMaskLabelPos;

	private bool m_IsShowAnimHideByPreviewPop;

	private CouponInsufficientPopUpInfo m_LastCouponInsufficientInfo;

	public static List<Type> InterestedModel;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void Update()
	{
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

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	public bool IsBlockAchievementTips()
	{
		return false;
	}

	public void ChangeForbidEscState(bool isForbid)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public void RecoverNavigationView()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override bool NeedWaitDataReady()
	{
		return false;
	}

	protected override bool NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}

	protected override void OnTempHidePreview()
	{
	}

	protected override void OnRecoverPreview()
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	protected override bool RecoverPreviewNeedSkipAnim()
	{
		return false;
	}

	protected override bool RecoverPreviewNeedSkipKillNotify()
	{
		return false;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void SelectChooseTab()
	{
	}

	private void OnAnimPlayBtnClick(object[] param)
	{
	}

	private void OnCDNChangeBtnClick(object[] param)
	{
	}

	private void OnTitleBtnClick()
	{
	}

	private void OnInterfaceMackClick()
	{
	}

	private void OnInterfaceContentMaskClick()
	{
	}

	private int GetDefTabIdx()
	{
		return 0;
	}

	private int ChestID2TabIdx(int chestID)
	{
		return 0;
	}

	private uint TabIdx2ChestID(int tabIdx)
	{
		return 0u;
	}

	private bool RefreshSelectedTabAfterGachaTabsFilter()
	{
		return false;
	}

	public bool OnTakeScreenshotInSystem()
	{
		return false;
	}

	public void OnGachaTabClick(int tabIndex, bool forceRefresh = false)
	{
	}

	public void OnGachaCouponInsufficientBuyClick(uint chestID, UIModelGacha.GachaDrawType drawType)
	{
	}

	private void ShowGachaCouponInsufficientPopUp(uint chestID, UIModelGacha.GachaDrawType drawType)
	{
	}

	private void RefreshTabBtnState(bool forceRefresh = false)
	{
	}

	private void LogLobbyPerformanceWaitNetTime()
	{
	}

	public void RefreshLuckySpinTab(bool needCenter)
	{
	}

	public void ShowLuckySpinTabVFX()
	{
	}

	public void OnlyResetPreviewItemPanelSize()
	{
	}

	private void NavigationToGachaReward(bool isInterrupted)
	{
	}

	public void RefreshGachaScene()
	{
	}

	private bool CheckNeedPlayAnimation()
	{
		return false;
	}

	private void RefreshUIScene()
	{
	}

	private void RefreshGachaTabsView(object[] param)
	{
	}

	private void RefreshGachaBG()
	{
	}

	private void RefreshAnimPlayBtnView()
	{
	}

	private void RefreshShowChangePlayBtnView()
	{
	}

	private void RefreshPropsViewNew()
	{
	}

	private bool GetValidLimitPoolTokenUseChannel(uint tokenItemID)
	{
		return false;
	}

	private void RefreshLimitPoolGotoToken(uint chestID, uint tokenItemID)
	{
	}

	private void CloseLimitPoolGotoToken()
	{
	}

	private void OnLimitPoolExchangeClick()
	{
	}

	private void RefreshContentView()
	{
	}

	public void RefreshGameViewSetting()
	{
	}

	public void RefreshShowAvatar()
	{
	}

	public override void Hide()
	{
	}

	public override void Show()
	{
	}

	private void HideViewOnPlayAnimtion(object[] param)
	{
	}

	private void ShowViewOnOverAnimtion(object[] param)
	{
	}

	public uint GetCurGachaId()
	{
		return 0u;
	}

	private UIGachaContentBase GetGachaContent(ELottery.Type type, uint gachaID)
	{
		return null;
	}

	public bool NeedUpdateTokenByBackPack()
	{
		return false;
	}

	private void CheckGachaOpen()
	{
	}

	private void InitGachaTab()
	{
	}

	private void OnOpenRewardPanel()
	{
	}

	private void OnCloseRewardPanel(object[] data)
	{
	}

	private bool ShowLuckySpinPhase1()
	{
		return false;
	}

	private bool ShowLuckySpinPhase2()
	{
		return false;
	}

	private void OnGachaAnimSkip(object[] data)
	{
	}

	public void PlayShowAnim(bool isShow)
	{
	}

	public void SetInterfaceMaskEnable(object[] param)
	{
	}

	public void SetContentMaskEnable(bool v)
	{
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	private void OnRewardPoolOpen()
	{
	}

	private void OnRewardPoolClose(object[] data)
	{
	}

	private void ShowChangeSceneMask()
	{
	}

	private void CloseRewardPool()
	{
	}

	private void OnRewardPoolItemSelected(object[] data)
	{
	}

	private void OnAnimOver(object[] data)
	{
	}

	private void OnAvatarClear(object[] data)
	{
	}

	private bool CurrentAnimationIsFullScreen()
	{
		return false;
	}

	private void CheckForPlayGachaAnimation()
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	private void OnExchangeExtraReward(object[] data)
	{
	}

	private void OnTokenTowerPrivilegeSelect(object[] data)
	{
	}

	private void OnBooyahPassPreviewShow(object[] data)
	{
	}

	public override List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
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

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedWaitDataReady()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnTempHidePreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRecoverPreview()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecoverPreviewNeedSkipAnim()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_RecoverPreviewNeedSkipKillNotify()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	public FrontEndPreviewComponent _003C_003EiFixBaseProxy_GetFrontEndPreviewComponent()
	{
		return null;
	}
}
