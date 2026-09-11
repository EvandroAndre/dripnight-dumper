using GCommon;
using UnityEngine;

namespace COW;

public class UIQRCodeShareWindowView : UIBaseView
{
	public GameObject NormalContainer;

	public GameObject ClanContainer;

	public Transform NormalQRCodeTransform;

	public GameObject TeamContainer;

	public GameObject ProfileContainer;

	public GameObject RoomContainer;

	public UILabel TeamCodeLabel;

	public UILabel NameLabel;

	public UILabel UIDLabel;

	public UILabel RoomCodeLabel;

	public Transform ClanQRCodeTransform;

	public UISprite ClanIconLeftFrame;

	public UISprite ClanIconRightFrame;

	public UINetworkTexture ClanIconCDN;

	public UISprite ClanIcon;

	public UILabel ClanLevelLabel;

	public UITable ClanNameContainerTable;

	public UILabel LabelClanName;

	public UILabel ClanIDLabel;

	public UILabel RegionLabel;

	public UILabel ClanInviteLabel;

	public Transform ClanInviteTransform;

	public GameObject IconCelebrity;

	public UISprite WeatherSprite;

	public UILabel GameMode;

	public UILabel GroupMode;

	public UILabel MapName;

	public UISprite Map;

	public Transform CommunityContainer;

	public UILabel RoomName;

	public Transform RoomQRCodeTransform;

	public UIButton QRSCanBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
