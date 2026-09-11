using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGraphicSettingController : UISettingContentBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static OnToggleGroupValueChange _003C_003E9__18_0;

		public static Func<bool> _003C_003E9__22_2;

		public static OnToggleGroupValueChange _003C_003E9__37_0;

		public static Func<bool> _003C_003E9__48_0;

		internal void _003CInitCollectionSetting_003Eb__18_0(int selectContent)
		{
		}

		internal bool _003COnFrameRateChosen_003Eb__22_2()
		{
			return false;
		}

		internal void _003CInitLobbyGyroCamSetting_003Eb__37_0(int selectContent)
		{
		}

		internal bool _003CShowQualityChangeConfirmMessage_003Eb__48_0()
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public EInGameFilterSetting filter;

		public UIGraphicSettingController _003C_003E4__this;

		internal void _003CFilterBtnClick_003Eb__0()
		{
		}

		internal void _003CFilterBtnClick_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public int selectContent;

		public UIGraphicSettingController _003C_003E4__this;

		internal void _003COnFrameRateChosen_003Eb__0()
		{
		}

		internal void _003COnFrameRateChosen_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public UIGraphicSettingController _003C_003E4__this;

		public MNMBLBKENMK selectQuality;

		internal void _003CShowQualityChangeConfirmMessage_003Eb__1()
		{
		}

		internal void _003CShowQualityChangeConfirmMessage_003Eb__2()
		{
		}
	}

	private sealed class _003CRefreshScroll_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGraphicSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshScroll_003Ed__11(int _003C_003E1__state)
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

	private UIGraphicSettingView m_View;

	private GraphicSettingInfo m_SettingInfo;

	private const string TXT_NOTCH_TIP = "TXT_NOTCH_TIP";

	private const string TXT_QUALITY_HIGH_PERFORMANCE_TIP = "T_40_XH_CHANGE_HIGHPER";

	private const string TXT_SOCIAL_LOBBY_QUALITY_NEXT_MATCH_TIP = "T_54_WYH_NINTH_CHANGEGHPER_TIP";

	private const float FPS_SETTING_LENGTH = 134f;

	private Coroutine m_ScrollArrowCoro;

	private UICommonSettingItemController m_HDAnimationSetting;

	private UICommonSettingItemController m_HDLobbySetting;

	private UICommonSettingItemController m_HDLobbySelfDisplaySetting;

	private UICommonSettingItemController m_HDLobbyCaptainDisplaySetting;

	private UICommonSettingItemController m_HDEffectSetting;

	private UICommonSettingItemController m_HDTextureSetting;

	private MNMBLBKENMK m_InitialQuality;

	private bool canSetExtraQuality;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitSettingInfo()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIInit()
	{
	}

	private IEnumerator RefreshScroll()
	{
		return null;
	}

	private void RefreshScrollArrow()
	{
	}

	private void ResetScrollViewWidth()
	{
	}

	private void InitMiniMap()
	{
	}

	private void OnMinimapModeChange()
	{
	}

	private void InitInGameFilterSetting()
	{
	}

	private void FilterBtnClick(EInGameFilterSetting filter)
	{
	}

	private void InitCollectionSetting()
	{
	}

	private void InitShadowSetting()
	{
	}

	private void InitHightFPSSetting()
	{
	}

	public override void RefreshContent(object[] param)
	{
	}

	private void OnFrameRateChosen(int selectContent)
	{
	}

	private void InitSmoothHighFrame()
	{
	}

	private void OnSmoothHighFrameChosen(int selectContent)
	{
	}

	private void RefreshSmoothHighFrameShow()
	{
	}

	private void ShowSmoothHighFrameDesc()
	{
	}

	private void InitEnemyFootStepHintSetting()
	{
	}

	private void InitEnergySavingSetting()
	{
	}

	private void InitHDSetting()
	{
	}

	private void CloseHDSetting()
	{
	}

	private void InitLobbyGyroCamSetting()
	{
	}

	private void InitBtnClickDelegete()
	{
	}

	private void InitResolutionSetting()
	{
	}

	private void InitQualitySetting(bool firstOpen = false)
	{
	}

	private void SetQuality(MNMBLBKENMK q)
	{
	}

	public void ShowRecommendQuality(bool showByAutoTask = false)
	{
	}

	private void SetPopupMessage(MNMBLBKENMK selectQuality)
	{
	}

	private bool NeedShowHighPerformanceTip(MNMBLBKENMK preQuality, MNMBLBKENMK selectQuality)
	{
		return false;
	}

	private bool NeedShowSocialLobbyNextMatchTip(MNMBLBKENMK preQuality, MNMBLBKENMK selectQuality)
	{
		return false;
	}

	private string GetQualityChangePopupMessage(bool showHighPerformanceTip, bool showSocialLobbyNextMatchTip)
	{
		return null;
	}

	private void ShowQualityChangeConfirmMessage(string text, MNMBLBKENMK selectQuality, bool needConfirmDelay, bool useSuggestionTitle)
	{
	}

	private bool IsEnhanceQuality(MNMBLBKENMK pre, MNMBLBKENMK now)
	{
		return false;
	}

	private int EQualityConvertToInt(MNMBLBKENMK quality)
	{
		return 0;
	}

	private void OnQualityChange()
	{
	}

	private void ShowQualityDesc()
	{
	}

	private void AfterToggleSelected()
	{
	}

	private void DisableToggle(GameObject g, bool enable)
	{
	}

	private void PlayResolutionTween()
	{
	}

	private void PlayShadowTween()
	{
	}

	private void PlayEnergySavingTween()
	{
	}

	private void PlayInGameFilterTween()
	{
	}

	private void PlayCollectionEffectTween()
	{
	}

	private CommonSettingItemDataToggleBtns CreateHDAnimationData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateCanShowLobbyData()
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateHDEffectData()
	{
		return null;
	}

	private void OnHDEffectTipClick()
	{
	}

	private void OnSetLobbyShow(bool flag, int lobbyType)
	{
	}

	private void OnShowStandLobbyClicked()
	{
	}

	private void OnHideLobbyClicked()
	{
	}

	private int GetCanShowLobbyBtn()
	{
		return 0;
	}

	private CommonSettingItemDataToggleBtns CreateHDLobbySelfDisplaySettingData()
	{
		return null;
	}

	private int GetHDLobbySelfDisplaySelectBtn()
	{
		return 0;
	}

	private void OnShowHDLobbySelfDisplayClicked()
	{
	}

	private void OnHideHDLobbySelfDisplayClicked()
	{
	}

	private CommonSettingItemDataToggleBtns CreateHDLobbyCaptainDisplaySettingData()
	{
		return null;
	}

	private int GetHDLobbyCaptainDisplaySelectBtn()
	{
		return 0;
	}

	private void OnShowHDLobbyCaptainDisplayClicked()
	{
	}

	private void OnHideHDLobbyCaptainDisplayClicked()
	{
	}

	private int GetHDAnimationSelectBtn()
	{
		return 0;
	}

	private void OnCloseHDAnimation()
	{
	}

	private void OnOpenHDAnimation()
	{
	}

	private void OnOpenHDWeaponEffect()
	{
	}

	private void OnCloseHDWeaponEffect()
	{
	}

	private int GetWeaponEffectSelectBtn()
	{
		return 0;
	}

	private CommonSettingItemDataToggleBtns CreateHDTextureData()
	{
		return null;
	}

	private void OnOpenHDTexture()
	{
	}

	private void OnCloseHDTexture()
	{
	}

	private int GetHDTextureSelectBtn()
	{
		return 0;
	}

	private void _003CInitInGameFilterSetting_003Eb__16_0()
	{
	}

	private void _003CInitInGameFilterSetting_003Eb__16_1()
	{
	}

	private void _003CInitInGameFilterSetting_003Eb__16_2()
	{
	}

	private void _003CInitInGameFilterSetting_003Eb__16_3()
	{
	}

	private void _003CInitShadowSetting_003Eb__19_0(int selectContent)
	{
	}

	private void _003CInitHightFPSSetting_003Eb__20_0()
	{
	}

	private void _003CInitHightFPSSetting_003Eb__20_1()
	{
	}

	private void _003CInitEnergySavingSetting_003Eb__28_0()
	{
	}

	private void _003CInitEnergySavingSetting_003Eb__28_1(int selectContent)
	{
	}

	public void _003C_003EiFixBaseProxy_InitSettingInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}
}
