using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCameraTemplatePanelView : UIBaseView
{
	public UILabel TitleDescLabel;

	public UIButton CloseBtn;

	public GameObject TimeProgressGameObject;

	public UISprite TimeProgressSprite;

	public UILabel TimeLabel;

	public UIGrid CameraTemplateItemGrid;

	public UIToggleButtonGroup TabToggleGroup;

	public UIToggleButton PhotoTemplateBtn;

	public UIToggleButton VedioTemplateBtn;

	public UIGrid VedioTemplateItemGrid;

	public UIPanel UIHudCameraTemplatePanel;

	public UIScrollView ScrollView;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
