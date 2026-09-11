using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBlockEditEnumPopWndView : UIBaseView
{
	public UIButton BtnConfirm;

	public UIGrid ToggleGrid;

	public UIHudBlockEditEnumPopItemController TemplateToggle;

	public UIGrid ItemGrid;

	public UIHudBlockEditEnumPopItemController TemplateItem;

	public UIGrid SpriteGrid;

	public UIHudBlockEditEnumPopItemController TemplateSprite;

	public Transform EnumPopPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
