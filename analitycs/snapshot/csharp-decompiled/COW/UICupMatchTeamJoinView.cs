using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchTeamJoinView : UIBaseView
{
	public UIInput SearchInput;

	public UIButton SearchButton;

	public UIButton ResetButton;

	public UIEasyList TeamList;

	public GameObject EmptyTips;

	public UIButton Refresh;

	public GameObject RefreshIcon;

	public UICountDownLabel CountDownLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
