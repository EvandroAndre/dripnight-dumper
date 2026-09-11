using GCommon;
using UnityEngine;

namespace COW;

public class UIHudRoomOBInfoListView : UIBaseView
{
	public UIButton ShowBtn;

	public TweenPosition Pivot;

	public GameObject AllTab;

	public UIToggleButton AllToggleBtn;

	public GameObject NearTab;

	public UIToggleButton NearToggleBtn;

	public GameObject NearBy;

	public UIScrollView NearByListPanel;

	public UITable2 NearByTable;

	public GameObject All;

	public UIScrollView AllListPanel;

	public UITable2 AllTable;

	public GameObject ClosePanel;

	public UIButton HideBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
