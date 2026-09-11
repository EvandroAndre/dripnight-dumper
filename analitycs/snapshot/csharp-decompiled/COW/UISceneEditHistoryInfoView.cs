using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditHistoryInfoView : UIBaseView
{
	public UIScrollView CenterSV;

	public UIToggleButton LatestPlayedBtn;

	public UIToggleButton HistoryPlayedtBtn;

	public UITable HistroyTable;

	public UISprite HistroyEmpty;

	public UIWidget CenterScrollable;

	public UIWidget ContentContainer;

	public GameObject tabbtns;

	public UIGrid Grid;

	public UIButton EmptyButton;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
