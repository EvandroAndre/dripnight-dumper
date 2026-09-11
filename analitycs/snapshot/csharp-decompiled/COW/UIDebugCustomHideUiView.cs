using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugCustomHideUiView : UIBaseView
{
	public Transform UIDebugCustomHideUi;

	public UIButton ConfirmButton;

	public UIButton ResetButton;

	public UIButton ReverseButton;

	public UITable2 ItemList;

	public UIInput Input;

	public UIButton SaveButton;

	public UIButton LoadButton;

	public BoxCollider SmallMask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
