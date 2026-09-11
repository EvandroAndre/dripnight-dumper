using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileRecentVisitorPopWndView : UIBaseView
{
	public UILabel TotalVisitorNum;

	public UILabel TodayNewAddNum;

	public UILabel TotalVisitorDesc;

	public UILabel TodayNewAddDesc;

	public UIScrollView ScrollView;

	public UIEasyList EasyListContainer;

	public GameObject VisitorConatiner;

	public GameObject NoVisitorContainer;

	public UILabel NoVisitorLabel;

	public Transform BriefBoxOpenTrans;

	public Transform LeftContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
