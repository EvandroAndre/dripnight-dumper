using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInventoryExchangeView : UIBaseView
{
	public GameObject ItemTemplate;

	public UIWidget ItemTemplateWidget;

	public UIButton CloseBtn;

	public UISprite CloseBtnWidget;

	public UIGrid ItemGrid;

	public UIWidget ItemGridWidget;

	public UISprite BG;

	public UISprite TitleIcon;

	public UISprite TitleBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
