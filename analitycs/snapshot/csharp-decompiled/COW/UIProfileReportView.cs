using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileReportView : UIBaseView
{
	public GameObject GameSecurity;

	public UIToggleButton ReportHistoryToggleButton;

	public UIToggleButton PenzaltyHistoryToggleButton;

	public UILabel ReportName;

	public UILabel ReportTime;

	public UILabel ReportType;

	public UILabel TipsLabel;

	public UIButton BtnGameSecurity;

	public GameObject EmptyNode;

	public UILabel NoDataLabel;

	public UIEasyList HistoryList;

	public GameObject ScrollView;

	public GameObject ReportLabelContainer;

	public UILabel ReportSchedule;

	public GameObject PenzaltyLabelContainer;

	public UILabel PenzaltyType;

	public UILabel PenzaltyTime;

	public UILabel PenzaltyDay;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
