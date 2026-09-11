using GCommon;
using UnityEngine;

namespace COW;

public class UIHudReportNewView : UIBaseView
{
	public UIScrollView ReportTypeScrollView;

	public UITable ReportTypeToggleBtnTable;

	public UIButton btnConfirm;

	public GameObject FailedFeedback;

	public UIButton btnConfirmFailed;

	public GameObject SuccessFeedback;

	public UIEffectSprite PersonHeadSprite;

	public UILabel Personnickname;

	public UILabel CreditReduceTxt;

	public UILabel CreditCurrentTxt;

	public UILabel PunilshTxt;

	public UIButton btnConfirmSuccess;

	public UILabel ProtectCompensationPointsTxt;

	public GameObject DetailInfo;

	public UILabel FailedFeedbackDesc;

	public UILabel ImportantReport;

	public UITable SuccessFeedbackTable;

	public GameObject Report;

	public UIEasyList ReportPlayerEasyList;

	public GameObject Empty;

	public GameObject ReportPlayerExcludeTitle;

	public GameObject ReportTypeExcludeTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
