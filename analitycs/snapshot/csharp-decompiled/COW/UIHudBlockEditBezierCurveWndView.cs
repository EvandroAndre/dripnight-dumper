using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBlockEditBezierCurveWndView : UIBaseView
{
	public GameObject UIHudBlockEditBezierCurveWnd;

	public UITexture Board;

	public UIInput X1Input;

	public UIInput Y1Input;

	public UIGrid PresetGrid;

	public UIButton Mask;

	public GameObject PresetTemplate;

	public GameObject ControlPoint1;

	public UISprite ControlPoint1Sprite;

	public GameObject RGBInputPanel;

	public UIInput CurveNameInput;

	public UIInput A1Input;

	public UITexture BoardContainer;

	public GameObject TangentPoint2;

	public UISprite TangentPoint2Sprite;

	public GameObject ControlPoint2;

	public UISprite ControlPoint2Sprite;

	public GameObject TangentPoint1;

	public UISprite TangentPoint1Sprite;

	public UILabel A1InputLabel;

	public GameObject Content;

	public UILabel X1InputLabel;

	public UILabel Y1InputLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
