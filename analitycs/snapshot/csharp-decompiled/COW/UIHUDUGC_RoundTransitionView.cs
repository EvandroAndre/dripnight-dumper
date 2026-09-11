using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_RoundTransitionView : UIBaseView
{
	public Animator Animator;

	public GameObject roundResultDetailsContainer;

	public UILabel coins;

	public UILabel coinValue;

	public UILabel roundInfo;

	public GameObject winSprite;

	public GameObject loseSprite;

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

	public UISprite myFactionIcon;

	public UISprite myTeamIcon;

	public UILabel myTeamName;

	public GameObject myScores;

	public UILabel myScoreCurrent;

	public UILabel myScorePrevious;

	public TweenAlpha myTweenAlpha;

	public TweenPosition myTweenPos;

	public GameObject myVFX;

	public UISprite oppoFactionIcon;

	public UILabel oppoTeamName;

	public UISprite oppoTeamIcon;

	public GameObject oppScores;

	public UILabel oppoScoreCurrent;

	public UILabel oppoScorePrevious;

	public TweenAlpha oppoTweenAlpha;

	public TweenPosition oppoTweenPos;

	public GameObject oppoVFX;

	public UILabel LastRoundHint;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
