using GCommon;
using UnityEngine;

namespace COW;

public class UINewPlayerV3MissionView : UIBaseView
{
	public GameObject AllDone;

	public GameObject MissionCon;

	public GameObject BigAwardMission;

	public GameObject NormalAwardMission;

	public UIScrollView NormalMissionScrollView;

	public UIPanel NormalMissionScrollViewPanel;

	public Transform NormalMissionScrollViewTrans;

	public UIEasyList NormalMissionEasyList;

	public GameObject normalbg;

	public UISprite MissionVerticalLineBg;

	public UISprite MissionHorizontalLineBg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
