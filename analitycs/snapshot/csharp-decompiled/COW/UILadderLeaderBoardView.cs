using GCommon;
using UnityEngine;

namespace COW;

public class UILadderLeaderBoardView : UIBaseView
{
	public Transform LeftContainer;

	public UIEasyList EasyListWeapon;

	public GameObject ListTitleBar;

	public GameObject SelfInfo;

	public UISprite SelfBG;

	public Transform SelfLBContainer;

	public UILabel SelfInfoTips;

	public UIButton SeasonTipsBtn;

	public UISprite SeasonIcon;

	public UILabel SeasonLabel;

	public UISprite UnOpen;

	public UIButton CSSeasonTipsBtn;

	public UISprite CSSeasonIcon;

	public UILabel CSSeasonLabel;

	public UISprite CSUnOpen;

	public Transform Filter1;

	public Transform Filter2;

	public GameObject LowestValueTipsData;

	public UILabel LadderTitle;

	public GameObject WeaponPowerTitle;

	public UIButton LocateIcon;

	public GameObject PopMenu;

	public UILabel NoDataTipsLabel;

	public UIButton LocationIconCenter;

	public GameObject NOSetLocationTipsData;

	public GameObject RankTitleCon;

	public GameObject WPTitleCon;

	public GameObject LeaderBoardCon;

	public GameObject PerioDicSeasonTipsBtn;

	public UISprite PerioDicSeasonIcon;

	public UILabel PerioDicSeasonLabel;

	public UISprite PerioDicUnOpen;

	public UIToggleButtonGroup RegionToggleGroup;

	public UIGrid RegionToggleGrid;

	public UIToggleButton Country;

	public UIToggleButton Province;

	public UIToggleButton City;

	public UIEasyList EasyListCSBR;

	public UILabel CountrySelectLabel;

	public UILabel CountryUnSelectLabel;

	public UILabel ProvinceSelectLabel;

	public UILabel ProvinceUnselectLabel;

	public UILabel CitySelectLabel;

	public UILabel CityUnselectLabel;

	public UIToggleButton FriendToggleButton;

	public UIToggleButton RegionToggleButton;

	public GameObject FriendGlobleToggle;

	public GameObject Main;

	public UIToggleButton LocationToggleButton;

	public UIScrollView ContentScrollView2;

	public UIScrollView ContentScrollView1;

	public UIButton ScrollButton;

	public GameObject ScrollTopIcon;

	public GameObject ScrollDownIcon;

	public GameObject EndTimeCon;

	public UISprite CountrySelectToggleIcon;

	public UISprite CountryUnSelectToggleIcon;

	public UISprite ProvinceSelectToggleIcon;

	public UISprite ProvinceUnSelectToggleIcon;

	public UISprite CitySelectToggleIcon;

	public UISprite CityUnSelectToggleIcon;

	public UISprite NoDataRankLadderIcon;

	public GameObject RankTitlePos;

	public GameObject RankTitleName;

	public UICountDownLabel CountDownEndTime;

	public Transform TimeBgTransform;

	public UISprite RankToggleBg;

	public UISprite RankToggleBgLine;

	public UIGrid AreaToggleGrid;

	public GameObject CsPeakSeasonTip;

	public UILabel GoToPeakLabel;

	public UILabel CSPeakSeasonLabel;

	public GameObject CsPeakSeasonUnopenLabel;

	public UIButton GoToPeakBtn;

	public BoxCollider GoToPeakBox;

	public UIButton CsPeakSeasonTipBtn;

	public GameObject CityStar;

	public GameObject ProvinceStar;

	public GameObject CountryStar;

	public GameObject UnSelectCityStar;

	public GameObject UnSelectProvinceStar;

	public GameObject UnSelectCountryStar;

	public UILabel NoDataNeedScore;

	public UISprite NoDataLadderScoreIcon;

	public GameObject NoDataShowScore;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
