using GCommon;
using UnityEngine;

namespace COW;

public class UIElitePassChallengeItemView : UIBaseView
{
	public UILabel Desc;

	public UILabel ProcessLabel;

	public UIButton ClaimBtn;

	public GameObject Claimed;

	public UIGrid RewardList;

	public Transform RewardListTransform;

	public GameObject GoTask;

	public UIButton GoTaskBtn;

	public GameObject Lock;

	public UILabel ClaimLabel;

	public UILabel LockLabel;

	public UILabel ClaimedLabel;

	public UILabel GoTaskLabel;

	public GameObject UIElitePassChallengeItem;

	public UIWidget ItemWidget;

	public GameObject main;

	public UIButton RefreshBtn;

	public Transform CountDownTransform;

	public GameObject LadderMatchTaskBG;

	public UILabel DoubleExpLabel;

	public GameObject DoubleExp;

	public GameObject EXPBGMask;

	public GameObject ExpUIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
