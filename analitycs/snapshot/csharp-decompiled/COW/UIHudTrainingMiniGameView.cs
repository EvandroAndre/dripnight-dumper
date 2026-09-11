using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTrainingMiniGameView : UIBaseView
{
	public GameObject MiniGameMap;

	public Transform CountDown;

	public UILabel labelTips;

	public UISprite labelbgwidget;

	public UISprite warningIcon;

	public UISprite warningwidget;

	public UILabel timeCount;

	public TweenAlpha TweenAlpha;

	public Transform ScoreInfo;

	public UILabel Score;

	public UILabel TargetCount;

	public UILabel PopScore;

	public Animation AddScoreAnim;

	public GameObject PreCountDown;

	public UILabel PreCountNum;

	public UIButton QuitGameBtn;

	public Transform Victory;

	public TweenScale VictoryTween;

	public UILabel VictoryTxt;

	public Transform Defeat;

	public TweenScale DefeatTween;

	public UILabel DefeatTxt;

	public GameObject End;

	public Transform Btns;

	public UIGrid Grid;

	public UIButton ShareBtn;

	public UIButton BackBtn;

	public UILabel LabelBack;

	public UIButton PlayAgain;

	public UIButton SkipMask;

	public GameObject Result;

	public UILabel ResultSummary;

	public UILabel ResultTitle1;

	public UILabel EndLeftTimeLabel;

	public UILabel ResultTitle2;

	public UILabel HeadShotCntLabel;

	public UILabel ResultTitle3;

	public UILabel KillLabel;

	public UILabel ResultTitle4;

	public UILabel EndScoreLabel;

	public GameObject Reward;

	public UISprite ItemIcon;

	public UILabel ItemNum;

	public GameObject SelectShootLevel;

	public UIToggle ShootLeve_L;

	public UIToggle ShootLeve_M;

	public UIToggle ShootLeve_H;

	public UIButton SelectShootLevelBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
