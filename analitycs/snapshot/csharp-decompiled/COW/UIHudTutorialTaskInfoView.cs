using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTutorialTaskInfoView : UIBaseView
{
	public GameObject MainTaskGroup;

	public GameObject PhaseTaskPanel;

	public GameObject MainTaskBar;

	public GameObject SafeZoneBar;

	public GameObject PhaseTaskHeader;

	public GameObject TaskList;

	public UIGrid TaskGrid;

	public UIWidget TaskListWidget;

	public UILabel MainTaskLabel;

	public UILabel PhaseNameLabel;

	public GameObject GameObjectScrollView;

	public UIScrollView UIScrollViewScrollView;

	public UIButton ExtendItemButton;

	public UILabel SafeZoneLabel;

	public GameObject PhaseIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
