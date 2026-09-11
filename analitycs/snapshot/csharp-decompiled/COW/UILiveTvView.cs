using GCommon;
using UnityEngine;

namespace COW;

public class UILiveTvView : UIBaseView
{
	public UIToggleButton LiveTv;

	public UILabel LiveSelectLabel;

	public UILabel LiveUnSelectLabel;

	public UIToggleButton BooyahTv;

	public UILabel BooyahUnSelectLabel;

	public UILabel BooyahSelectLabel;

	public UIButton BtnRefresh;

	public UIToggleButton Tournament;

	public UILabel TournamentSelectLabel;

	public UILabel TournamentUnSelectLabel;

	public UIGrid ToggleBtnGrid;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
