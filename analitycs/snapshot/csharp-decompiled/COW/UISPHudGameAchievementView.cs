using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudGameAchievementView : UIBaseView
{
	public UIWidget UISPHudGameAchievement;

	public Animator AnimContainer;

	public UISprite TeamSplashNEW;

	public UISprite TeamSplashSHUT;

	public UISprite FirstBloodSplash;

	public UISprite TeamSplashAce;

	public UISprite DoubleKillSplash;

	public UISprite TripleKillSplash;

	public UISprite QuadraKillSplash;

	public UISprite KillingSpreeSplash;

	public GameObject SingleHeadPic;

	public UISprite CenterIcon;

	public GameObject VersusHeadPic;

	public UISprite LeftIcon;

	public UISprite RightIcon;

	public UILabel Name;

	public GameObject FakeFirstBloodBgContainer;

	public UITexture TeamFirstBloodTextureBG;

	public GameObject fistblood;

	public UITexture FirstBloodIconTexture;

	public GameObject FakeShutDownBgContainer;

	public UITexture BgShutDownTexture;

	public GameObject ShutDown;

	public UITexture ShutDownTexture;

	public Transform ComplexContainer;

	public GameObject NewFirstBloodSplash;

	public GameObject NewTeamSplashShut;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
