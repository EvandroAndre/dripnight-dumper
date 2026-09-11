using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisBackpackItemView : UIBaseView
{
	public UIHudHippoCrisisDragDropItem Drag;

	public UIWidget DragWidget;

	public UIButton ClickBtn;

	public GameObject NoDrag;

	public UISprite DragIcon;

	public UIColor QuailtyBg;

	public UISprite ItemIcon;

	public UISprite LightBG;

	public UILabel ItemNum;

	public GameObject Selected;

	public UILabel WeightLabel;

	public GameObject HasAttach;

	public UILabel ValueLabel;

	public UISprite Red;

	public UISprite QualityBG_NEW;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
