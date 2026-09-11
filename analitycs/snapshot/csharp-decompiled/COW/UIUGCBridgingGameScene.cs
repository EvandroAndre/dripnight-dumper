using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using COW.Gameplay.UGC;
using UnityEngine;
using message;

namespace COW;

internal class UIUGCBridgingGameScene
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UGCHud3DContainerDepth> _003C_003E9__113_0;

		internal int _003CSortHud3DContainer_003Eb__113_0(UGCHud3DContainerDepth a, UGCHud3DContainerDepth b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass111_0
	{
		public UGCHud3DContainerDepth container;

		internal bool _003CAddHud3DContainer_003Eb__0(UGCHud3DContainerDepth e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public string entityID;

		internal bool _003CRemoveHud3DContainer_003Eb__0(UGCHud3DContainerDepth e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass117_0
	{
		public string childID;

		internal bool _003CRemoveCachedChildrenWidgetID_003Eb__0(string e)
		{
			return false;
		}
	}

	private Dictionary<string, IUIHUDBaseController> m_InternalHudControllers;

	private Dictionary<string, UIHUDUGC_CustomHudController> m_CustomHudControllers;

	private Dictionary<string, IUIHUDBaseController> m_HudWidgetControllers;

	private UGC_CommonHudSwitchController m_CommonHudSwitchController;

	private Dictionary<uint, string> m_SpecialInternalHudConfigs;

	private List<UGCHud3DContainerDepth> m_Hud3DContainer;

	private Dictionary<string, List<string>> m_CachedChildrenWidgetID;

	private UIHUDUGC_IconFlyController m_UIHUDUGC_IconFlyController;

	private UGCBindEffectManager m_BindEffectManager;

	private UGCGraphicsManager m_GraphicsManager;

	private Light m_DLight;

	private UIInGameScene m_Owner;

	private UGCPersonaModule llmModule;

	private UGCPersonaModule LLMModule => null;

	public Transform UiHudPanelStatic => null;

	public Transform UiHudPanelDynamic => null;

	public UIUGCBridgingGameScene(UIInGameScene scene)
	{
	}

	public void Init()
	{
	}

	public void UnInit()
	{
	}

	public void OnGameVoiceHudCreated()
	{
	}

	private void OnAddCountdownHud(string entityID)
	{
	}

	private void OnAddOpeningBannerHud(string entityID)
	{
	}

	private void OnAddTwoTeamRoundStartBannerHud(string entityID)
	{
	}

	private void OnAddNormalRoundStartBannerHud(string entityID)
	{
	}

	private void OnAddTeamRoundScoreBannerHud(string entityID)
	{
	}

	private void OnAddCheckPointMgrHud(string entityID)
	{
	}

	private void OnAddRoundResultShowTimeHud(string entityID)
	{
	}

	private void OnAddRoundNumHud(string entityID)
	{
	}

	private void OnAddPhaseCountDownHud(string entityID)
	{
	}

	private void OnAddMatchInfoSubTitleHud(string entityID)
	{
	}

	private void OnAddTwoTeamMatchInfoHud(string entityID)
	{
	}

	private void OnAddTeamMatchInfoHud(string entityID)
	{
	}

	private void OnAddTwoTeamFactionHud(string entityID)
	{
	}

	private void OnAddTwoTeamRoundScoreBannerHud(string entityID)
	{
	}

	private void OnAddResultBannerHud(string entityID)
	{
	}

	private void OnAddTwoTeamLeaderboardHud(string entityID)
	{
	}

	private void OnAddMoreTeamLeaderboardHud(string entityID)
	{
	}

	private void OnAddTwoTeamLeaderboardHudV2(string entityID)
	{
	}

	private void OnAddMoreTeamLeaderboardHudV2(string entityID)
	{
	}

	private void OnAddTwoTeamMatchInfoSimpleNewHud(string entityID)
	{
	}

	private void OnAddLeaderboardButtonHud(string entityID)
	{
	}

	private void OnAddCustomHud(string entityID)
	{
	}

	private void OnAddCustomHudWidget(MHJLOKOOGNB entityType, string entityID)
	{
	}

	private void OnAddHudEmptyWidget(string entityID)
	{
	}

	private void OnAddHudImageWidget(string entityID)
	{
	}

	private void OnAddHudLabelWidget(string entityID)
	{
	}

	private void OnAddHudButtonWidget(string entityID)
	{
	}

	private void OnAddHudInputWidget(string entityID)
	{
	}

	private void OnAddHudEmptyPanel(string entityID)
	{
	}

	private void OnAddHudScrollView(string entityID)
	{
	}

	private void OnAddHudGrid(string entityID)
	{
	}

	private void OnAddHudLayout(string entityID)
	{
	}

	private void OnAddHud3DContainer(string entityID)
	{
	}

	private void OnAddHudTexture(string entityID)
	{
	}

	private void OnAddHudProfileInfo(string entityID)
	{
	}

	private void OnAddHudToggle(string entityID)
	{
	}

	private void OnAddHudTouchPad(string entityID)
	{
	}

	private void OnAddHudJoystick(string entityID)
	{
	}

	private void OnAddHudSocialButtonWidget(string entityID)
	{
	}

	private void OnAddFactionInfoHud(string entityID)
	{
	}

	private void OnAddIconNotificationHud(string entityID)
	{
	}

	private void OnAddTwoTeamMatchInfoSimpleHud(string entityID)
	{
	}

	private void OnAddCountdownReminderHud(string entityID)
	{
	}

	private void OnAddTweenTipsHud(string entityID)
	{
	}

	private void OnAddRoundTransitionHud(string entityID)
	{
	}

	private void OnAddSingleLeaderboardHud(string entityID)
	{
	}

	private void OnAddZombieLevelHud(string entityID)
	{
	}

	private void OnAddAddScoreVFXHud(string entityID)
	{
	}

	private void OnAddZombieVFXHud(string entityID)
	{
	}

	private void OnAddTimeTweenTipsHud(string entityID)
	{
	}

	private void OnAddUGCPlayerHeadHud(string entityID)
	{
	}

	private void OnAddUGCAniTriggerHud(string entityID)
	{
	}

	private void OnAddUGCShopHud(string entityID)
	{
	}

	private void OnAddActionHud(string entityID)
	{
	}

	private void OnAddWalletHud(string entityID)
	{
	}

	private void OnAddChooseCardHud(string entityID)
	{
	}

	private void OnAddIdentityNotifyHud(string entityID)
	{
	}

	private void OnAddTitleBannerHud(string entityID)
	{
	}

	private void OnAddFiveSecondCountDownHud(string entityID)
	{
	}

	private void OnAddCommonHudSwitchHud(string entityId)
	{
	}

	private void OnAddSkillButtonHud(string entityId)
	{
	}

	private void OnAddProgressbarHud(string entityId)
	{
	}

	private void OnAddHPbarHud(string entityId)
	{
	}

	private void OnAddHeartbeatEffectHud(string entityId)
	{
	}

	private void OnAddTextTipsHud(string entityId)
	{
	}

	private void OnAddTwoTeamResultHud(string entityId)
	{
	}

	private void OnAddMultiTeamResultHud(string entityId)
	{
	}

	private void OnAddCameraRayCastHud(string entityId)
	{
	}

	private void OnAddProgressCircleHud(string entityId)
	{
	}

	private void OnAddScoreBarHud(string entityID)
	{
	}

	private void OnAddSprayResultHud(string entityID)
	{
	}

	private void OnAddHintButtonHud(string entityID)
	{
	}

	private void OnAddTipHud(string entityID)
	{
	}

	private void OnAddProgressSkillButtonHud(string entityID)
	{
	}

	private void OnAddCSRoundInfoHud(string entityID)
	{
	}

	private void OnAddCSRoundResultHud(string entityID)
	{
	}

	private void OnAddDirectionRulerHud(string entityID)
	{
	}

	private void OnRemoveInternalHud(string entityID)
	{
	}

	private void OnRemoveCustomHud(string entityID)
	{
	}

	private void OnRemoveCustomHudWidget(string entityID)
	{
	}

	private void OnAddChatChannel(string entityID)
	{
	}

	private void OnAddCommonHudSwitchController(string entityID)
	{
	}

	private void SpeakerBtnHUDCommonHudSwitch(UGC_CommonHudSwitchController.ESwitchValue switchValue)
	{
	}

	private void MicroPhoneBtnHUDCommonHudSwitch(UGC_CommonHudSwitchController.ESwitchValue switchValue)
	{
	}

	private void OnRemoveCommonHudSwitchController(string entityID)
	{
	}

	private void OnAddLLMChatHud(string entityID)
	{
	}

	private void OnAddMidGameExitConfig(string entityID)
	{
	}

	public UIHUDUGC_IconFlyController GetIconFlyController()
	{
		return null;
	}

	public void AddHud3DContainer(UGCHud3DContainerDepth container)
	{
	}

	public void RemoveHud3DContainer(string entityID)
	{
	}

	public void SortHud3DContainer()
	{
	}

	public void AddCachedChildrenWidgetID(string parentID, string childID)
	{
	}

	public void GetCachedChildrenWidgetID(string parentID, out List<string> childrenID)
	{
		childrenID = null;
	}

	public void RemoveCachedParentWidgetID(string parentID)
	{
	}

	public void RemoveCachedChildrenWidgetID(string parentID, string childID)
	{
	}

	public string GetHudConfig(MHJLOKOOGNB type)
	{
		return null;
	}

	public IUIHUDBaseController FindInternalHudByType(Type type)
	{
		return null;
	}

	public IUIHUDBaseController FindWidgetByID(string widgetID)
	{
		return null;
	}

	public UIHUDUGC_CustomHudController GetCustomHud(string entityId)
	{
		return null;
	}

	public UGCCommonHudData GetCommonHudData(int target)
	{
		return null;
	}

	public void ClearAllCustomHud()
	{
	}

	public void SetAllCustomHudVisibility(bool isVisible)
	{
	}
}
