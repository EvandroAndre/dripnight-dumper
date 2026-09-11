using GCommon;
using UnityEngine;

namespace COW;

public class UIHudRoundTransitionView : UIBaseView
{
	public Animator Animator;

	public GameObject roundResultDetailsContainer;

	public Animation NewRoundAnimator;

	public UILabel coins;

	public UILabel coinValue;

	public UILabel roundInfo;

	public UISprite WinSpr;

	public UISprite LoseSpr;

	public UIGrid bonusGrid;

	public GameObject bonusItem;

	public GameObject mvpPlayer;

	public UILabel MVPPlayerName;

	public GameObject VS;

	public GameObject nextRoundContainer;

	public UILabel matchpoint;

	public Transform roundNum_noMatchPointTrans;

	public UILabel roundNum;

	public Transform gamezoneName_noMatchPointTrans;

	public UILabel gamezoneName;

	public Transform roundNum_matchPointTrans;

	public Transform gamezoneName_matchPointTrans;

	public UISprite myTeamIcon;

	public UILabel myTeamName;

	public GameObject myScores;

	public UILabel myScoreCurrent;

	public UILabel myScorePrevious;

	public TweenAlpha myTweenAlpha;

	public TweenPosition myTweenPos;

	public GameObject myVFX;

	public UILabel oppoTeamName;

	public UISprite oppoTeamIcon;

	public GameObject oppScores;

	public UILabel oppoScoreCurrent;

	public UILabel oppoScorePrevious;

	public TweenAlpha oppoTweenAlpha;

	public TweenPosition oppoTweenPos;

	public GameObject oppoVFX;

	public UILabel LastRoundHint;

	public Transform randomAreaEventBg;

	public UILabel randomAreaEventGamezoneName;

	public UIGridAnimPopAsideHelper AnimQueue;

	public GameObject GroupMedals;

	public GameObject FeedbackRoot;

	public UILabel winLabel;

	public TweenAlpha WinLabelTween;

	public GameObject Victory_Old;

	public GameObject Victory_New;

	public GameObject Defeate_New;

	public GameObject Roundbg7;

	public GameObject BOOYAH_BG_Middle;

	public VFXCreateHelper UIFX;

	public UISprite Right;

	public UISprite Left;

	public UILabel gamezoneName_SAP;

	public GameObject winInfo;

	public UIWidget WinWidget;

	public AnimatedAlpha WinAlpha;

	public GameObject loseInfo;

	public UIWidget LoseWidget;

	public AnimatedAlpha loseAlpha;

	public UILabel subWinLabel;

	public TweenAlpha subWinLabelTween;

	public GameObject change_sides;

	public UISprite LeftScoreBG;

	public UISprite LeftScoreLine01;

	public UISprite LeftScoreLine02;

	public UISprite RightScoreBG;

	public UISprite RightScoreLine01;

	public UISprite RightScoreLine02;

	public UISprite LeftNextRoundBG;

	public UISprite LeftNextRoundLine01;

	public UISprite LeftNextRoundLine02;

	public UISprite RightNextRoundBG;

	public UISprite RightNextRoundLine01;

	public UISprite RightNextRoundLine02;

	public ParticleSystem LeftBoomVFXRender1;

	public ParticleSystem LeftBoomVFXRender2;

	public ParticleSystem LeftBoomVFXRender3;

	public ParticleSystem LeftBoomVFXRender4;

	public ParticleSystem RighttBoomVFXRender1;

	public ParticleSystem RighttBoomVFXRender2;

	public ParticleSystem RighttBoomVFXRender3;

	public ParticleSystem RighttBoomVFXRender4;

	public ParticleSystem TrasitionNextVFXParticle;

	public UISprite myFactionIcon;

	public UISprite oppoFactionIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
