using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2TopButtonController : UIBaseController, IUIModelDataChangeObserver, ITipsDelegate
{
	private UILobbyV2TopButtonView m_View;

	private UIModelGroup m_ModelGroup;

	private UIModelUser m_ModelUser;

	private UIModelInventory m_ModelInventory;

	private UIModelLobbyPing m_ModelLobbyPing;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIModelSetting m_ModelSetting;

	private UIModelOTP m_ModelOTP;

	private UIModelLogin m_ModelLogin;

	private UIModelAntiAddiction m_ModelAntiAddiction;

	private UICommonGuideController m_CommonGuideCtrl;

	private UILobbyV2IPMusicController m_IPMusicCtrl;

	private UIFFLogoController m_UIFFLogoCtrl;

	private const string LOBBY_CLAN_KEY = "LOBBY_CLAN_KEY_{0}";

	private bool m_HasShowLoginExceptionRemind;

	private Dictionary<uint, bool> m_CollaborateActivityIdSet;

	private bool m_FinishCheckCollaborateActivity;

	private Vector3 batteryLevelScale;

	private const float BATTERY_EMPTY_DISPLAY_SCALE = 0.1f;

	private const float BATTERY_LEVEL_THRESHOLD_LOW_MEDIUM = 0.2f;

	private const float BATTERY_LEVEL_THRESHOLD_MEDIUM_HIGH = 0.5f;

	private readonly Color BATTERY_LEVEL_COLOR_LOW;

	private readonly Color BATTERY_LEVEL_COLOR_MEDIUM;

	private readonly Color BATTERY_LEVEL_COLOR_HIGH;

	private readonly Color BATTERY_LEVEL_COLOR_CHARGING;

	private UITipsNormalController m_MailTipsCtrl;

	private UITipsNormalController m_FriendTipsCtrl;

	private UITipsNormalController m_ClanTipsCtrl;

	private UITipsNormalController m_SettingTipsCtrl;

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

	public override void Show()
	{
	}

	private void OnClanBtnClick()
	{
	}

	private void OnFriendBtnClick()
	{
	}

	private void OnMailBtnClick()
	{
	}

	private void OnSettingBtnClick()
	{
	}

	private bool isShowSettingEntranceRedTip()
	{
		return false;
	}

	private bool IsShowAntiAddictionBRAgeVerifyTips()
	{
		return false;
	}

	private void ShowAgeLogo()
	{
	}

	private void RefreshIPMusicBtnState(object[] param)
	{
	}

	private void InitBatteryView()
	{
	}

	private void RefreshClanView()
	{
	}

	private void RefreshLobbyLogo()
	{
	}

	public void RefreshGameVoiceBtnView()
	{
	}

	public void UpdateBattery(object[] parameters)
	{
	}

	private void UpdateNormalBattery(object[] parameters)
	{
	}

	private void UpdatePingBattery(object[] parameters)
	{
	}

	private void RefreshPing()
	{
	}

	private void CheckCollobrateActivity()
	{
	}

	public void RefreshClanIcon()
	{
	}

	private void TryInitTips()
	{
	}

	private void RefreshTips()
	{
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	private void UpdateMailTips()
	{
	}

	private void UpdateLobbyMailBtnTips(object[] data)
	{
	}

	private void UpdateSettingBtnTips()
	{
	}

	private void OnShowLobbyV2ClanGuide(object[] data)
	{
	}

	private void CheckAndShowLobbyRightTips()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
