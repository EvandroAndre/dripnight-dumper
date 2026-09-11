using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSMatchInfoView : UIBaseView
{
	public Transform myTeam;

	public UIGrid MyteamGrid;

	public Transform oppoTeam;

	public UIGrid OppoTeamGrid;

	public UILabel myWinNum;

	public UILabel remainTime;

	public UILabel oppoWinNum;

	public UILabel curRound;

	public UIButton BtnLeaderboard;

	public UIWidget WidgetBtnLeaderboard;

	public UIWidget WidgetTutorial;

	public UISprite leftBG;

	public UISprite rightBG;

	public UIWidget NewTutorialWidget_HelloCS;

	public UIWidget NewTutorialWidget_AllScore;

	public UIWidget NewTutorialWidget_FriendScore;

	public UIWidget NewTutorialWidget_GameBall;

	public UIWidget NewTutorialWidget_EnemyScore;

	public GameObject techRoot;

	public UIGrid myTeamTech;

	public Transform myTeamTechTrans;

	public UIGrid oppoTeamTech;

	public Transform oppoTeamTechTran;

	public UISprite RandomAreaEvent_BgRight;

	public UISprite RandomAreaEvent_BgLeft;

	public UISprite RandomAreaEvent_MidInfoBg;

	public UISprite TechAirdropBgLeft;

	public UISprite TechAirdropBgRight;

	public GameObject Glow_Right;

	public ParticleSystem GlowRightParticle;

	public GameObject Glow_Left;

	public ParticleSystem GlowLeftParticle;

	public UISprite MyTeamWinNumBg;

	public UISprite OppoWinNumBg;

	public GameObject FFWS2025BRFlag;

	public UISprite FFWS_myTeamFlag;

	public UISprite FFWS_oppoTeamFlag;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
