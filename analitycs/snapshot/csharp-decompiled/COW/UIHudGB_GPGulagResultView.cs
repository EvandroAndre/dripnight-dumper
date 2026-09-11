using GCommon;
using UnityEngine;

namespace COW;

public class UIHudGB_GPGulagResultView : UIBaseView
{
	public UILabel ResultLabel;

	public UICenterTargetHelper CenterHelper;

	public UILabel ReviveCountDown;

	public UIButton BtnRevive;

	public GameObject BackContainer;

	public GameObject WinOrDrawContainer;

	public GameObject LoseContainer;

	public Animation main;

	public UILabel DetailLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
