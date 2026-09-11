using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudTeamAccStatsListView : UIBaseView
{
	public TweenPosition InfoPanel;

	public GameObject team;

	public UIScrollView TeamList;

	public UIGrid TeamGrid;

	public UILabel TeamTab;

	public UILabel PTSTab;

	public UILabel ElimsTab;

	public UILabel AliveTab;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
