using GCommon;
using UnityEngine;

namespace COW;

public class UILeaderBoardNewView : UIBaseView
{
	public UIButton Profile;

	public UIButton Share;

	public Transform LeftContainer;

	public UIScrollView ContentScrollView;

	public UIPanel ScrollViewPanel;

	public UIEasyList ContentList;

	public GameObject ListTitlePersonKills;

	public GameObject ListTitlePersonWins;

	public GameObject ListTitleGuildHonor;

	public GameObject ListTitleGuildRegionHonor;

	public GameObject ListTitlePersonBadges;

	public UISprite BG;

	public GameObject SelfInfo;

	public UISprite SelfBG;

	public Transform SelfLBContainer;

	public UILabel SelfInfoTips;

	public UIButton Share2;

	public UIWidget Share2Widget;

	public UIButton SeasonTipsBtn;

	public UISprite SeasonIcon;

	public UILabel SeasonLabel;

	public UISprite UnOpen;

	public UIButton CSSeasonTipsBtn;

	public UISprite CSSeasonIcon;

	public UILabel CSSeasonLabel;

	public UISprite CSUnOpen;

	public UILabel GuildWeekTime;

	public UIWidget ItemLeft;

	public UIWidget ItemRight1;

	public UIWidget ItemRight2;

	public GameObject Loading;

	public UIWidget PreviewBorder;

	public UILabel TipsNoData;

	public UILabel BpTitle;

	public UIButton AwardBtn;

	public GameObject ListTitlePVETime;

	public GameObject ListTitlePVEDamage;

	public UIGrid ToggleBtnGrid;

	public UIToggleButtonGroup ToggleBtnGroup;

	public UIToggleButton FriendToggleButton;

	public UIToggleButton RegionToggleButton;

	public UIToggleButton GlobleToggleButton;

	public GameObject ListTitlePersonKD;

	public GameObject ListTitlePVEInfiniteData;

	public GameObject ListTitleGuildActivityRank;

	public UILabel GuildActivityRankRefreshTime;

	public UIButton LocalizationBtn;

	public Transform ClanBriefBoxTran;

	public GameObject ListTitleGuildWarIndividual;

	public GameObject ListTitleGuildWarGuild;

	public UIButton SlefQuickJoinBtn;

	public UIToggleButton CountryToggleButton;

	public UIToggleButton ProvinceToggleButton;

	public UIToggleButton CityToggleButton;

	public UILabel CountrySelectedLabel;

	public UILabel CountryUnselectedLabel;

	public UILabel ProvinceSelectedLabel;

	public UILabel ProvinceUnselectedLabel;

	public UILabel CitySelectedLabel;

	public UILabel CityUnselectedLabel;

	public UITable FilterTable;

	public Transform GuildWarClanInfoTrans;

	public GameObject Rank;

	public UIButton GuildWar_GuildTips;

	public UIButton GuildWar_IndividualTips;

	public GameObject ListTitleGuildActivityRankGlobal;

	public UILabel GuildHonorLabel;

	public GameObject ToggleBG;

	public GameObject ListTitleBar;

	public UISprite LocaWhiteIcon;

	public UISprite LocaBlackIcon;

	public UILabel WarTitle;

	public GameObject ListTitlePVETotalScore;

	public GameObject ListTitlePVEHighestScore;

	public GameObject Leaderboard;

	public Transform LadderLeaderBoard;

	public Transform Line;

	public GameObject LaunchTagNode;

	public GameObject HCScore;

	public GameObject HCWorth;

	public GameObject HCProfit;

	public UIButton HCSeasonTipsBtn;

	public UILabel HCSeasonLabel;

	public GameObject HCUnOpen;

	public GameObject PrimePoint;

	public GameObject PrimeEmpty;

	public UINetworkTexture PrimeBGCDN;

	public UIColor SelfBGPrime;

	public UILabel PrimeScoreLabel;

	public UILabel RegionUnselectedLabel;

	public UILabel RegionSelectedLabel;

	public UIButton ScrollToSelfBtn;

	public UILabel WishItemLabel;

	public UILabel TrendLabel;

	public GameObject WishListContent;

	public UIWidget ItemRight3;

	public UIToggleButton WishListToggleButton;

	public UILabel GotoBtnLabel;

	public UIButton WishListGotoBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
