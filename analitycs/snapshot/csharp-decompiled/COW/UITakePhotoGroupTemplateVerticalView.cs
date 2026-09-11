using GCommon;
using UnityEngine;

namespace COW;

public class UITakePhotoGroupTemplateVerticalView : UIBaseView
{
	public UIEasyList EasyList;

	public UILabel Desc;

	public UIButton ExpandBtn;

	public UISprite IsExpandIcon;

	public UISprite UnExpandIcon;

	public UIButton Uncheck;

	public UISprite Check;

	public Animation main;

	public UIPanel ScrollView;

	public UIPanel RootPanel;

	public UIWidget ScrollViewWidget;

	public UIWidget Drag;

	public UIAnchor Top;

	public UIAnchor Bottom;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
