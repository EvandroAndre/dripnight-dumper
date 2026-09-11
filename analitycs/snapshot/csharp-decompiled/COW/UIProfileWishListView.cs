using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileWishListView : UIBaseView
{
	public UIWidget PreviewWidget;

	public UIEasyList ListContainer;

	public Transform SortFilterContainer;

	public UILabel TotalNumLabel;

	public GameObject NothingView;

	public UIButton SendGiftBtn;

	public UIButton GoPosBtn;

	public UISprite GoPosIcon;

	public UILabel GoPosLabel;

	public UILabel NoGoPosLabel;

	public UITable GoposTable;

	public UIAnchor Left;

	public UIAnchor BottomRight;

	public GameObject CountDownContent;

	public UICountDownLabel CountDownLabel;

	public GameObject NoChannelLabel;

	public UIButton SkipAnimMaskBtn;

	public GameObject WishListRankGoToBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
