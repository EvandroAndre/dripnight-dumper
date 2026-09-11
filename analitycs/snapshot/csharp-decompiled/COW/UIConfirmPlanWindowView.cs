using GCommon;
using UnityEngine;

namespace COW;

public class UIConfirmPlanWindowView : UIBaseView
{
	public UIScrollView PresetItemScrollView;

	public UIButton ApplyBtn;

	public UITable PresetItemTable;

	public UIToggleButtonGroup PresetItemBtnGroup;

	public Transform RecPlanPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
