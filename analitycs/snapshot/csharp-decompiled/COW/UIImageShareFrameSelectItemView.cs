using GCommon;
using UnityEngine;

namespace COW;

public class UIImageShareFrameSelectItemView : UIBaseView
{
	public GameObject SelectedContainer;

	public UISprite FrameIcon;

	public UILabel FrameLabel;

	public GameObject EmptyContainer;

	public UIButton FrameBtn;

	public GameObject TagContainer;

	public GameObject TimeLimitTag;

	public GameObject HotTag;

	public GameObject NewTag;

	public Transform NewTipContainer;

	public UINetworkTexture FrameIconCDN;

	public UIButton GoToBtn;

	public GameObject NotOwnedContainer;

	public GameObject LeftTimeContainer;

	public UILabel LeftTimeLabel;

	public GameObject LockIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
