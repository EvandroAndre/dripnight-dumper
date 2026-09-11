using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchRewardWndView : UIBaseView
{
	public UIButton ClaimBtn;

	public UIButton GotoBtn;

	public UIButton ConfirmBtn;

	public UIButton CloseBtn;

	public GameObject Congratulation;

	public GameObject MatchWin;

	public GameObject MatchLose;

	public GameObject LoseToChallenge;

	public Transform BoxContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
