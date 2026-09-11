using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UINB1RESYS_LobbyWarmUpController : UIBigEventWarmUpBaseController
{
	public const int CDNTypeWarmupBg = 60001;

	public const int CDNTypeWarmupTitle = 60002;

	public const int CDNTypeCloseButton = 60003;

	public const int CDNTypeOldRewardSelectedBg = 60004;

	public const int CDNTypeOldRewardUnselectedBg = 60005;

	public const int CDNTypeNewRewardSelected = 60006;

	public const int CDNTypeNewRewardUnselected = 60007;

	public const int CDNTypeTitlePreview = 60008;

	public const int CDNTypeSelectGiftBtn = 60009;

	public const int CDNTypeGrandPrizeText = 60010;

	public const int CDNTypeSelectTitle = 60011;

	public const int CDNTypeSelectActivityDescBg = 60012;

	public const int CDNTypeSelectPreviewIcon = 60013;

	public const int CDNTypeSelectOwnedBg = 60014;

	public const int CDNTypeSelectOldPriceMask = 60015;

	public const int CDNTypeSelectNewPriceMask = 60016;

	public const int CDNTypeSelectOldRewardFg = 60017;

	public const int CDNTypeSelectConfirmBtnBg = 60018;

	private const string ChangeAnimLower2TopEvt = "NB1RE_Warmup_Lower2Top";

	private const string ChangeAnimUpper2BottomEvt = "NB1RE_Warmup_Upper2Bottom";

	private const string SelectAnimInName = "UIFX_UINB1RESYS_LobbyWarmUp_SelectAnimIn";

	private const string SelectAnimSpecialName = "UIFX_UINB1RESYS_LobbyWarmUp_Select_Special";

	private const string LogEventName = "NB1RESYS";

	private const string LogWarmUpBundleEntrance = "WarmUpSelectEntrance";

	private const string LogWarmUpBundleSelect = "WarmUpSelect";

	private const string LogOwnJiraiya = "OwnJiraiya";

	private const string LogNotOwnJiraiya = "NotOwnJiraiya";

	private const string LogOldRewardBundle = "Jiraiya";

	private const string LogNewRewardBundle = "Hinata";

	private const float ChangeAnimInterval = 1.5f;

	private const float ChangeAnimStartDelay = 1.5f;

	private UINB1RESYS_LobbyWarmUpView m_View;

	private UIModelNB1RESYS m_ModelNB1RESYS;

	private BaseItemInfo m_OldBundleItem;

	private BaseItemInfo m_NewBundleItem;

	private BaseItemInfo m_TitlePreviewItem;

	private bool m_OldBundleOwned;

	private uint m_OriginalPrice;

	private uint m_CurrentPrice;

	private ENB1RESysBundleChoice m_SelectedBundle;

	private ENB1RESysBundleChoice m_SelectingBundle;

	private string m_Lower2TopAnimName;

	private string m_Upper2BottomAnimName;

	private uint m_AnimDelayCall;

	private uint m_SelectGlowDelayCall;

	private bool m_IsAnimRunning;

	private bool m_NextChangeAnimIsLower2Top;

	private int m_GiftTopDepth;

	private int m_GiftBottomDepth;

	private const int GiftFgDepthOffset = 1;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	protected override string GetTitleCDNUrl()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnCloseClick()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	private void LoadSavedSelection()
	{
	}

	private void SaveSelection()
	{
	}

	private void ResetSelectingBundle()
	{
	}

	private bool HasConfirmedSelection()
	{
		return false;
	}

	private ENB1RESysBundleChoice GetConfirmedBundleChoice(ENB1RESysBundleChoice choice)
	{
		return ENB1RESysBundleChoice.None;
	}

	private bool IsOldBundleSelected()
	{
		return false;
	}

	private bool IsNewBundleSelected()
	{
		return false;
	}

	private bool IsOldBundleSelecting()
	{
		return false;
	}

	private bool IsNewBundleSelecting()
	{
		return false;
	}

	private void LoadCdn(UINetworkTexture texture, int cdnType)
	{
	}

	private void StopDownloadTextures()
	{
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnNB1ReSysWarmUpInfoCallback()
	{
	}

	protected override void OnBigEventWarmupSettingCallback(List<BigEventShowAwardDesc> list)
	{
	}

	private void InitUI()
	{
	}

	private void LoadCdn()
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshMainAnimStateIfVisible()
	{
	}

	private void LoadMainCdn()
	{
	}

	private void RefreshMainUI()
	{
	}

	private void RefreshMainGiftSlot(UINetworkTexture bgTexture, UINetworkTexture oldRewardFgTexture, ENB1RESysBundleChoice bundle, bool selected)
	{
	}

	private int GetMainGiftCdnType(ENB1RESysBundleChoice bundle, bool selected)
	{
		return 0;
	}

	private void RefreshMainAnim()
	{
	}

	private void LoadSelectCdn()
	{
	}

	private void ShowMainPage()
	{
	}

	private void ShowMainPageWithConfirmAnim()
	{
	}

	private void ShowSelectPage()
	{
	}

	private void PlaySelectInAnim()
	{
	}

	private void OnSelectInAnimFinish()
	{
	}

	private void SetSelectGlowFxActive(bool active)
	{
	}

	private bool IsLeftGlowSelected()
	{
		return false;
	}

	private bool IsRightGlowSelected()
	{
		return false;
	}

	private void RefreshSelectGlowLoop()
	{
	}

	private void PlaySelectGlowOnce(ENB1RESysBundleChoice clickedChoice)
	{
	}

	private void ReplayGlowOnce(GameObject fx, bool active)
	{
	}

	private void CancelSelectGlowDelayCall()
	{
	}

	private void HideSelectPage()
	{
	}

	private void SelectBundle(ENB1RESysBundleChoice choice)
	{
	}

	private void ConfirmSelectBundle()
	{
	}

	private void LogBundleEntranceClick()
	{
	}

	private void LogBundleSelect()
	{
	}

	private void RefreshSelectUI()
	{
	}

	private bool HasPriceData()
	{
		return false;
	}

	private string GetDiscountTag(uint originalPrice, uint currentPrice)
	{
		return null;
	}

	private void InitChangeAnim()
	{
	}

	private void ResetChangeAnimToStart()
	{
	}

	private void ResetChangeAnimToStart(string animName)
	{
	}

	private void SampleAnimAtStart(string animName)
	{
	}

	private void CacheGiftDepths()
	{
	}

	private string GetChangeAnimName(int index)
	{
		return null;
	}

	private bool CanPlayAnim()
	{
		return false;
	}

	private AnimationState PlayAnim(string animName)
	{
		return null;
	}

	private void StopAnimLoop()
	{
	}

	private void CancelAnimDelayCall()
	{
	}

	private void StartIdleChangeAnimLoop()
	{
	}

	private void ScheduleNextChangeAnim(float delay)
	{
	}

	private void PlayNextChangeAnim()
	{
	}

	private void PlayConfirmChangeAnimOnce()
	{
	}

	private void OnConfirmChangeAnimFinish()
	{
	}

	private void ResetConfirmedMainState()
	{
	}

	private void OnAnimEvtOccur(object[] data)
	{
	}

	private void SetLowerGiftOnTop()
	{
	}

	private void SetUpperGiftOnTop()
	{
	}

	private void SetMainGiftSlotDepth(UINetworkTexture bgTexture, UINetworkTexture oldRewardFgTexture, int bgDepth)
	{
	}

	private void OnClickOpenSelect()
	{
	}

	private void OnClickCloseSelect()
	{
	}

	private void OnClickOldBundle()
	{
	}

	private void OnClickNewBundle()
	{
	}

	private void OnClickConfirmSelect()
	{
	}

	private void OnClickOldBundlePreview()
	{
	}

	private void OnClickNewBundlePreview()
	{
	}

	private void OnClickTitlePreview()
	{
	}

	private void OpenItemPreview(BaseItemInfo itemInfo)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseClick()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}
}
