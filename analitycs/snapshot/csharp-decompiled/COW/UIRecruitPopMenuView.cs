using GCommon;
using UnityEngine;

namespace COW;

public class UIRecruitPopMenuView : UIBaseView
{
	public UIWidget UIRecruitPopMenu;

	public UIPanel Container;

	public GameObject MainPart;

	public UIButton UIButtonOpenBtn;

	public UISprite UISpriteOpenBtn;

	public GameObject OpenBtn;

	public UISprite ArrUp;

	public UISprite ArrDown;

	public UILabel NoIconLabel;

	public UISprite Icon;

	public GameObject ScrollViewUpContainer;

	public UIScrollView UIScrollViewScrollViewUp;

	public UIPanel UIPanelScrollViewUp;

	public UIGrid Table;

	public UISprite BGUp;

	public GameObject ScrollViewDownContainer;

	public UIScrollView UIScrollViewScrollViewDown;

	public UIPanel UIPanelScrollViewDown;

	public UIGrid Grid;

	public UISprite BGDown;

	public UISprite SpriteBgArrUp;

	public UIColor ColorBgArrUp;

	public UISprite SpriteBgArrDown;

	public UIColor ColorBgArrDown;

	public UIButton Mask;

	public UILabel WithIconLabel;

	public Transform BRIconTrans;

	public UISprite CSPeakIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
