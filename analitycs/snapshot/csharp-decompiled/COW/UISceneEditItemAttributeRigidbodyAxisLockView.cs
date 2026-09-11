using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditItemAttributeRigidbodyAxisLockView : UIBaseView
{
	public UILabel Pos_Label;

	public UILabel Rot_Label;

	public UIToggleButton Toggle_Pos_X;

	public UIToggleButton Toggle_Pos_Y;

	public UIToggleButton Toggle_Pos_Z;

	public UIToggleButton Toggle_Rot_X;

	public UIToggleButton Toggle_Rot_Y;

	public UIToggleButton Toggle_Rot_Z;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
