using GCommon;
using UnityEngine;

namespace COW;

public class UIAntiHackWindowView : UIBaseView
{
	public GameObject AntiHackContainer;

	public UILabel LabelAntiHack;

	public UIButton BtnRefresh;

	public GameObject ReportContent;

	public GameObject PenzaltyContent;

	public GameObject WebviewContent;

	public GameObject EmptyNode;

	public UILabel ReportName;

	public UILabel ReportTime;

	public UILabel ReportType;

	public UILabel ReportSchedule;

	public UILabel PenzaltyType;

	public UILabel PenzaltyTime;

	public UILabel PenzaltyDay;

	public UILabel PenzaltyTipsLabel;

	public UILabel ReportTipsLabel;

	public UIEasyList ReportList;

	public UIEasyList PenzaltyList;

	public GameObject BlackBG;

	public GameObject CompensationContent;

	public UIEasyList CompensationList;

	public UILabel PenzaltyReason;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
