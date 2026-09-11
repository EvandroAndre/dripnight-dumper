using GCommon;
using UnityEngine;

namespace COW;

public class UIWorkShopMapDetailPopupWindowView : UIBaseView
{
	public UIButton BlackBG;

	public Transform WindowContainer;

	public UIButton BtnClose;

	public UIButton BtnLeft;

	public UIButton BtnRight;

	public GameObject DotNode;

	public UIGrid DotGrid;

	public UISprite DotNodeItem;

	public UIScrollView MapScrollView;

	public UICenterOnChild CenterOnChildComponent;

	public UIGrid ContentGrid;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
