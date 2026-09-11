using GCommon;
using UnityEngine;

namespace COW;

public class UIHudDragonEnterView : UIBaseView
{
	public UILabel LabelScore;

	public UIButton BtnSkipDragonTask;

	public UILabel TxtResult;

	public UILabel TxtTime;

	public Transform SkipTaskContainer;

	public Transform PosObserver;

	public GameObject TipCenter;

	public UICenterTargetHelper Helper;

	public UILabel ShowResultLabel;

	public UIButton ShowResultBtn;

	public UILabel returnLobbyTime;

	public GameObject TipStill;

	public UILabel TxtStill;

	public UIButton DisableBtn;

	public UILabel DisableBtnLabel;

	public UIButton SoloQuickNextBtn;

	public UIButton MultQuickNextBtn;

	public UIButton ReadyBtn;

	public GameObject ReadyLabel;

	public GameObject CancelReadyLabel;

	public GameObject NoticeVFX;

	public UILabel MentionLabel;

	public GameObject MatchMaking;

	public GameObject SkipContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
