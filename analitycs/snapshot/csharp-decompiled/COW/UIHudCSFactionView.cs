using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSFactionView : UIBaseView
{
	public UILabel taskDesc;

	public UILabel myTeamName;

	public UILabel myTeamDesc;

	public UISprite myTeamIcon;

	public UILabel oppoTeamName;

	public UILabel oppoTeamDesc;

	public UISprite oppoTeamIcon;

	public GameObject Icon_B;

	public GameObject Icon_O;

	public UISprite Icon_attack;

	public UISprite Icon_def;

	public GameObject blackBg;

	public UISprite taskIcon;

	public GameObject taskDescbg;

	public Animator UIHudCSFaction;

	public UILabel ClanRankLabel;

	public GameObject ClanRankInfo;

	public GameObject MyTeamClanIconInfo;

	public UISprite MyTeamIconFrame;

	public UISprite MyTeamClanIcon;

	public UILabel ClanWarPonitLabel;

	public GameObject ClanWarPointContainer;

	public UISprite OpTeamClanIcon;

	public UISprite OpTeamClanIconFrame;

	public GameObject OpTeamClanIconInfo;

	public GameObject OTClanWarPointContainer;

	public UILabel OTClanWarPonitLabel;

	public GameObject OTClanRankInfo;

	public UILabel OTClanRankLabel;

	public UINetworkTextureExt OpTeamCDNIcon;

	public UINetworkTextureExt MyTeamCDNIcon;

	public UILabel MyTeamCSPeakAVGPoints;

	public GameObject MyTeamCSPeakCon;

	public GameObject OpTeamCSPeakCon;

	public UILabel OpTeamCSPeakAVGPoints;

	public GameObject VSIcon;

	public GameObject CSPeakTitle1;

	public GameObject CSPeakTitle2;

	public UISprite MyTeamBG;

	public UISprite MyTeamLine01;

	public UISprite MyTeamLine02;

	public UISprite OppoTeamBG;

	public UISprite OppoTeamLine01;

	public UISprite OppoTeamLine02;

	public UITexture MyTeamVFXTexture;

	public UITexture OppoTeamVFXTexture;

	public UISprite OpTeamCSPeakIcon;

	public UISprite MyTeamCSPeakIcon;

	public UISprite myDefaultTeamIcon;

	public UISprite oppoDefaultTeamIcon;

	public UISprite FFWS_myTeamFlag;

	public UISprite FFWS_oppoTeamFlag;

	public GameObject SurpriseShopContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
