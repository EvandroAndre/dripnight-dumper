using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugTeleportMenuPopupView : UIBaseView
{
	public UIButton CloseBtn;

	public UIScrollView TabElementsScrollView0;

	public UITable TabElementsTable0;

	public UIScrollView TabElementsScrollView1;

	public UITable TabElementsTable1;

	public UIScrollView TeleportTargetsScrollView;

	public UIEasyList TeleportTargetsEasyList;

	public UIButton TeleportBtn;

	public UIButton DisabledTeleportBtn;

	public UILabel TargetsStatusTitle;

	public UILabel TargetsCount;

	public UILabel LocalPlayerPositionTitle;

	public UILabel LocalPlayerPosition;

	public GameObject TeleportTargetsDetailTitleGroup;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
