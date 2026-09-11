using GCommon;
using UnityEngine;

namespace COW;

public class UIHudRegionLeaderboardView : UIBaseView
{
	public UIButton BtnClose;

	public GameObject TapToClose;

	public GameObject CurMatchPanel;

	public GameObject RegionRankPanel;

	public UIEasyList CurMatchGridEasyList;

	public UIEasyList RegionRankGridEasyList;

	public UIToggleButtonGroup ToggleGroup;

	public UIToggleButton Right;

	public UIToggleButton Left;

	public UILabel LabelTotalGame;

	public UILabel LabelAccKill;

	public UILabel LabelKD;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
