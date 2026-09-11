using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBlockEditTweenCurveWndView : UIBaseView
{
	public GameObject UIHudBlockEditTweenCurveWnd;

	public UITexture Board;

	public UIInput X1Input;

	public UIInput Y1Input;

	public UIInput X2Input;

	public UIInput Y2Input;

	public UIGrid PresetGrid;

	public UIButton AddPresetBtn;

	public UIButton Mask;

	public GameObject PresetTemplate;

	public GameObject ControlPoint1;

	public GameObject ControlPoint2;

	public UITable OperationTable;

	public UIButton RenameBtn;

	public UIButton DeleteBtn;

	public UISprite ControlPoint1Line;

	public UISprite ControlPoint2Line;

	public UIButton OperationMask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
