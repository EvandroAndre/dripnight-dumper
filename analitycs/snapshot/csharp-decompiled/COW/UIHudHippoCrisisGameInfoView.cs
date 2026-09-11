using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisGameInfoView : UIBaseView
{
	public GameObject UIHudHippoCrisisGameInfo;

	public UISprite GradeIcon;

	public UILabel ScoreNum;

	public UISprite BGLevel;

	public UIColor LineLevel;

	public Transform IncreaseAnim;

	public UILabel IncreaseLabel;

	public Animation Score;

	public UIButton Btn;

	public UILabel KillCount;

	public Transform B;

	public Transform A;

	public Transform S;

	public Transform SS;

	public Transform SSS;

	public UISprite Killicon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
