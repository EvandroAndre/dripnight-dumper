using GCommon;
using UnityEngine;

namespace COW;

public class LadderMatchLeaderboardView : UIBaseView
{
	public TweenPosition BoardTween;

	public UIEasyList EasyList;

	public UIToggleButton BtnFriend;

	public UIToggleButton BtnAll;

	public Transform SelfRank;

	public UIButton BtnOpen;

	public Transform Arrow;

	public UIButton BtnHide;

	public TweenAlpha Mask;

	public UIWidget MainWidget;

	public UIButton BtnClose;

	public GameObject NoDataTips;

	public UILabel NoDataTipsLabel;

	public UILabel ScoreInfoTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
