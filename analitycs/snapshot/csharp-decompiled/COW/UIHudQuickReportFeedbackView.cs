using GCommon;
using UnityEngine;

namespace COW;

public class UIHudQuickReportFeedbackView : UIBaseView
{
	public UILabel Title;

	public UIButton ConfirmBtn;

	public UIButton MoreBtn;

	public Transform InfoRoot;

	public GameObject ReportSuccess;

	public GameObject ReportFailure;

	public UITable TagTableOnSuccess;

	public UILabel ScoreDeltaLabel;

	public UITable TagTableOnFailure;

	public UILabel SimpleNickName;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
