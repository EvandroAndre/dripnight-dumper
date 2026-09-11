using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileReportItemView : UIBaseView
{
	public UILabel ReportName;

	public UILabel ReportTime;

	public UILabel ReportType;

	public GameObject BG;

	public GameObject Sprite;

	public UILabel ReportSchedule;

	public GameObject ReportLabelContainer;

	public GameObject PenzaltyLabelContainer;

	public UILabel PenzaltyType;

	public UILabel PenzaltyTime;

	public UILabel PenzaltyDay;

	public UIButton ReportNameBtn;

	public UIWidget ReportNameBtnWidget;

	public UILabel PenzaltyReason;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
