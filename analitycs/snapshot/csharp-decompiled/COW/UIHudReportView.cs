using GCommon;
using UnityEngine;

namespace COW;

public class UIHudReportView : UIBaseView
{
	public UISprite mask;

	public UIScrollView ScrollView;

	public UITable ToggleBtnTable;

	public UIButton btnConfirm;

	public UIButton btnCancel;

	public GameObject ReporteeContainer;

	public GameObject PanelReport;

	public GameObject FailedFeedback;

	public UIButton btnConfirmFailed;

	public GameObject SuccessFeedback;

	public UIEffectSprite PersonHeadSprite;

	public UILabel Personnickname;

	public UILabel CreditReduceTxt;

	public UILabel CreditCurrentTxt;

	public UILabel PunilshTxt;

	public UIButton btnConfirmSuccess;

	public UIButton BtnClose;

	public UILabel ProtectCompensationPointsTxt;

	public GameObject DetailInfo;

	public UILabel FailedFeedbackDesc;

	public UILabel ImportantReport;

	public UITable SuccessFeedbackTable;

	public UIGrid ReporteeGrid;

	public UIScrollView ReporteeScrollView;

	public Transform ReporteeGuildGrid;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
