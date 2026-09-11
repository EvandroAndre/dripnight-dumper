using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFootballGameMatchResultView : UIBaseView
{
	public GameObject TitleWin;

	public GameObject TitleLoss;

	public UILabel Team1Score;

	public UILabel Team2Score;

	public UIButton BtnShare;

	public UIButton BtnContinue;

	public GameObject TitleDraw;

	public GameObject BannerWin;

	public GameObject BannerLoss;

	public GameObject BannerDraw;

	public Transform Data;

	public UILabel ContinueLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
