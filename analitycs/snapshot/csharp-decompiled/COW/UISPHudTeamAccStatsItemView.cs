using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudTeamAccStatsItemView : UIBaseView
{
	public GameObject DeadBg;

	public UIWidget TeamIconGo;

	public UIEffectSprite TeamIcon;

	public UISprite TeamFakeIcon;

	public ParticleSystem Particle;

	public GameObject GameObjectDownGo;

	public TweenAlpha TweenAlphaDownGo;

	public UILabel DownLbl;

	public GameObject GameObjectUpGo;

	public TweenAlpha TweenAlphaUpGo;

	public UILabel UpLbl;

	public UILabel Name;

	public UISprite ActiveP1;

	public UISprite ActiveP2;

	public UISprite ActiveP3;

	public UISprite ActiveP4;

	public UISprite DeadP1;

	public UISprite DeadP2;

	public UISprite DeadP3;

	public UISprite DeadP4;

	public UILabel RankLbl;

	public UILabel Score;

	public UILabel KillCnt;

	public GameObject Poison;

	public GameObject KillOfKing;

	public GameObject TeamAce;

	public UISprite ActiveP5;

	public UISprite ActiveP6;

	public UISprite DeadP5;

	public UISprite DeadP6;

	public GameObject CountryIconGo;

	public UIEffectSprite CountryIcon;

	public UITexture TeamIconBG;

	public GameObject FocusTeam;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
