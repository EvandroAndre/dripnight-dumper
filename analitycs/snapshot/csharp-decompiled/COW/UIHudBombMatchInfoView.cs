using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBombMatchInfoView : UIBaseView
{
	public UISprite leftBG;

	public UISprite rightBG;

	public Transform myTeam;

	public UIGrid MyteamGrid;

	public Transform oppoTeam;

	public UIGrid OppoTeamGrid;

	public Animator SwitchAnimator;

	public UILabel myWinNum;

	public UISprite myFaction;

	public UISprite FixedMyFaction;

	public UILabel curRound;

	public UISprite oppoFaction;

	public UILabel oppoWinNum;

	public UISprite FixedOppoFaction;

	public ParticleSystem VFX_attack;

	public ParticleSystem VFX_defense;

	public UIButton BtnLeaderboard;

	public UIWidget WidgetBtnLeaderboard;

	public UILabel countTime;

	public UISprite IconBomb;

	public UISprite IconNormal;

	public GameObject VFXFlashing1;

	public GameObject VFXFlashing2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
