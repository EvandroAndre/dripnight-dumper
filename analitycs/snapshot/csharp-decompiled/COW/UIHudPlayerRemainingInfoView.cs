using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPlayerRemainingInfoView : UIBaseView
{
	public UIWidget WidgetTutorial;

	public GameObject Remaining;

	public UILabel RemainLabel;

	public UILabel RemainingCountText;

	public GameObject Kill;

	public UILabel KillCountText;

	public GameObject Enemy;

	public UILabel RemainingEnemyCountText;

	public GameObject KDA;

	public UILabel KdaCountText;

	public GameObject OnlyAlive;

	public UILabel AliveLabel;

	public UILabel AliveCount;

	public GameObject OnlyKill;

	public UILabel killCount;

	public GameObject Property;

	public UILabel PropertyCount;

	public UISprite PropertyIcon;

	public GameObject Score;

	public UILabel ScoreText;

	public UILabel ScoreNum;

	public Transform RemainInfo1;

	public Transform RemainInfo2;

	public Transform RemainInfo3;

	public Transform RemainInfo4;

	public GameObject bg;

	public UISprite ScoreIcon;

	public Transform TrainingBtn;

	public GameObject NoRatingRemaining;

	public GameObject HasRatingRemaining;

	public UILabel RemainCountWithRating;

	public GameObject HasRatingKill;

	public GameObject NoRatingKill;

	public UILabel KillCountWithRating;

	public UISprite GoldBg;

	public UISprite SilveryBg;

	public UISprite GreyBg;

	public UILabel RatingNum;

	public UISprite SilveryIcon;

	public UISprite GreyIcon;

	public UISprite GoldIcon;

	public GameObject LevelImpoveVFX_Silvery;

	public GameObject LevelImpoveVFX_Gold;

	public GameObject SocreImpoveVFX;

	public UILabel ImpoveSocreNum;

	public GameObject Rating;

	public UILabel ImpoveGoldNum;

	public UILabel ImpoveSilveryNum;

	public UISprite NoRatingKillIcon;

	public UISprite HasRatingKillIcon;

	public UISprite OnlyKillSprite;

	public UISprite Enemyicon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
