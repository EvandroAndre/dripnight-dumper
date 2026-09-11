using GCommon;
using UnityEngine;

namespace COW;

public class UIReportReplaySubmitView : UIBaseView
{
	public UISprite mask;

	public UIScrollView ScrollView;

	public UITable ToggleBtnTable;

	public UIButton btnConfirm;

	public UIButton btnCancel;

	public GameObject ReporteeContainer;

	public GameObject PanelReport;

	public UIButton BtnClose;

	public UIInput InputContainer;

	public GameObject StatusContainer;

	public UILabel MatchId;

	public UITable UnusualDamageTabel;

	public UITable UnusualMoveTable;

	public UISprite SpriteNormal;

	public UISprite SpriteDisbale;

	public UITable UnusualToxicTable;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
