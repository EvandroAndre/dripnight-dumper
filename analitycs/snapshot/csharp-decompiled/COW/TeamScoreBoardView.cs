using GCommon;
using UnityEngine;

namespace COW;

public class TeamScoreBoardView : UIBaseView
{
	public Transform LeftRoot;

	public UILabel LeftTeamScore;

	public UISprite LeftScoreBackIcon;

	public GameObject LeftTeamDefaultIconOB;

	public UISprite LeftTeamDefaultIcon;

	public UISprite LeftTeamIcon;

	public UISprite LeftTeamClanBadge;

	public UILabel LeftTeamName;

	public UISprite LeftCustomIcon;

	public GameObject LeftTeammateInfoTitle;

	public UIHudTeamBattleScoreTitle TeamScoreTitleLeft;

	public UILabel LeftTitleInfo1Txt;

	public UILabel LeftTitleInfo2Txt;

	public UILabel LeftTitleInfo3Txt;

	public UIScrollView LeftTeamInfoScrollView;

	public UIGrid LeftTeammateGrid;

	public UIWidget LeftTeammateGridWgt;

	public GameObject LeftDragScroll;

	public GameObject LeftDownArrow;

	public Transform RightRoot;

	public UILabel RightTeamScore;

	public UISprite RightScoreBackIcon;

	public GameObject RightTeamDefaultIconOB;

	public UISprite RightTeamDefaultIcon;

	public UISprite RightTeamIcon;

	public UISprite RightTeamClanBadge;

	public UILabel RightTeamName;

	public UISprite RightCustomIcon;

	public GameObject RightTeammateInfoTitle;

	public UIHudTeamBattleScoreTitle TeamScoreTitleRight;

	public UILabel RightTitleInfo1Txt;

	public UILabel RightTitleInfo2Txt;

	public UILabel RightTitleInfo3Txt;

	public UIScrollView RightTeamInfoScrollView;

	public UIGrid RightTeammateGrid;

	public UIWidget RightTeammateGridWgt;

	public GameObject RightDragScroll;

	public GameObject RighttDownArrow;

	public UIButton BackMask;

	public UIButton ReportBtn;

	public UIButton BtnSwitchSkill;

	public GameObject GoSwitchSkillTipSkill;

	public GameObject GoSwitchSkillTipKDA;

	public UIButton RegionRankListBtn;

	public UIColor SpriteBtnSwitchSkill;

	public UISprite LeftTeamCSIcon;

	public UIEventListener LeftTeamRankBtn;

	public UISprite RightTeamCSIcon;

	public UIEventListener RightTeamRankBtn;

	public Transform LeftTeamIconNewStyle;

	public Transform RightTeamIconNewStyle;

	public UISprite RightTeamRankIcon;

	public UISprite LeftTeamRankIcon;

	public GameObject PresetSprite;

	public GameObject PresetSprite2;

	public GameObject AddFriendSprite;

	public GameObject ReportSprite;

	public UIButton AddFriendBtn;

	public GameObject LeftClanIconInfo;

	public UISprite LeftClanIconFrame;

	public UISprite LeftClanIcon;

	public GameObject RightClanIconInfo;

	public UISprite RightClanFrame;

	public UISprite RightClanIcon;

	public UINetworkTextureExt RightClanCDNIcon;

	public UINetworkTextureExt LeftClanCDNIcon;

	public GameObject CSPeakLeftTeamNameCon;

	public UILabel CSPeakLeftTeamName;

	public UILabel CSPeakLeftPoints;

	public GameObject CSPeakRightTeamNameCon;

	public UILabel CSPeakRightTeamName;

	public UILabel CSPeakRightPoints;

	public UISprite LeftTeamInfoBG;

	public UISprite LeftTeamLine01;

	public UISprite LeftTeamLine02;

	public UISprite RightTeamInfoBG;

	public UISprite RightTeamLine01;

	public UISprite RightTeamLine02;

	public UISprite CSPeakLeftIcon;

	public UISprite CSPeakRightIcon;

	public GameObject TabMenu;

	public UIToggleButton TabKDA;

	public UIToggleButton TabSkil;

	public UIToggleButton TabAbiltiy;

	public GameObject AbiltyIntro;

	public UISprite AbiltyIntroBg;

	public UISprite AbiltyIntroBgSkin;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
