using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisMissionItemView : UIBaseView
{
	public UILabel MissionNameTxt;

	public UILabel MissionDescTxt;

	public GameObject Tracking;

	public GameObject Normal;

	public UIButton BtnTrack;

	public UIButton BtnFinish;

	public GameObject Lock;

	public UIGrid AwardGrid;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
