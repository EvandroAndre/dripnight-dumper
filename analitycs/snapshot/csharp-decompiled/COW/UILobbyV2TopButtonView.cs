using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2TopButtonView : UIBaseView
{
	public GameObject Lobby;

	public UIGrid ButtonGrid;

	public UIButton FriendBtn;

	public UIButton MailBtn;

	public UIButton SettingBtn;

	public UISprite MicBan;

	public UISprite BatteryLevelSprite;

	public UISprite BatteryChargingSprite;

	public UIButton ClanBtn;

	public GameObject Age18Logo;

	public Transform IPMusicContainer;

	public UITable LeftContainer;

	public Transform FriendTips;

	public Transform MailTips;

	public Transform ClanTips;

	public UIWidget ClanGuideWidget;

	public GameObject PingBattery;

	public GameObject Battery;

	public UISprite PingBatteryLevel;

	public UISprite PingBatteryChargingSprite;

	public GameObject HighPing;

	public GameObject LowPing;

	public GameObject Age18LogoFFIPlaceHolder;

	public GameObject IPMusicContainerFFIPlaceHolder;

	public GameObject MiddlePing;

	public UISprite ClanNormalIcon;

	public UISprite ClanWarIcon;

	public Transform SettingTips;

	public Transform LoginRemindPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
