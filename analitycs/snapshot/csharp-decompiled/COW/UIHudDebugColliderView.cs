using GCommon;
using UnityEngine;

namespace COW;

public class UIHudDebugColliderView : UIBaseView
{
	public UIButton ToggleDebugCollider;

	public UIButton DumpVisibleRenderers;

	public UIButton DumpOne;

	public UIButton DumpRepeat;

	public UILabel RepeatLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
