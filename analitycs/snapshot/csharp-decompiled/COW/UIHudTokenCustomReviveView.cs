using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTokenCustomReviveView : UIBaseView
{
	public UIEventListener RevivalBtn;

	public UIWidget RevivalBtnWidget;

	public UILabel TipsLabel;

	public UILabel NameLabel;

	public UISprite ProgressBg;

	public UIGrid TeammateGrid;

	public UIColor Teammate1;

	public UIColor Teammate2;

	public UIColor Teammate3;

	public GameObject ProtectingState;

	public GameObject CountdownState;

	public GameObject LandingFightProtectGroupContainer;

	public UICountDownLabel CountDownLabel;

	public UISprite ProtectStateIcon;

	public GameObject RedEffect;

	public GameObject YellowEffect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
