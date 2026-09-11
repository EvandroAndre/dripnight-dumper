using GCommon;
using UnityEngine;

namespace COW;

public class UIWorkShopMapInfoDetailView : UIBaseView
{
	public UIButton ItemContentBtn;

	public UIForwardEvents DragForwardEvents;

	public UIWidget ScrollContentWidget;

	public UIScrollView MapScrollView;

	public UIWrapContent WrapContent;

	public UICenterOnChild CenterOnChildComponent;

	public UIPanel DotObj;

	public UIGrid DotGrid;

	public UIWidget UIWidgetDotGrid;

	public UISprite DotNodeItem;

	public GameObject BtnGoPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
