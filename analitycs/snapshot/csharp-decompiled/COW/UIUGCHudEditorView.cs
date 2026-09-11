using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudEditorView : UIBaseView
{
	public UIButton CloseBtn;

	public UISprite Panel;

	public UIButton Undo;

	public UIButton Redo;

	public UIButton Label;

	public UIButton Image;

	public UIButton Button;

	public GameObject PanelZoomMax;

	public GameObject PanelZoomMin;

	public GameObject PanelZoomRatio;

	public UILabel PanelZoomRatioLabel;

	public UILabel Y;

	public UILabel X;

	public UILabel Width;

	public UILabel Height;

	public UILabel Angle;

	public GameObject TransformInfo;

	public UIButton Texture;

	public GameObject HudBg;

	public GameObject EyeOpen;

	public GameObject EyeClose;

	public UIButton HudBtn;

	public UIButton Empty;

	public UIButton Input;

	public UIWidget categoryMask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
