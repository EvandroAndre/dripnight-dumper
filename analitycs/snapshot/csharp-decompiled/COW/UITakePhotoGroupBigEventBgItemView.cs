using GCommon;
using UnityEngine;

namespace COW;

public class UITakePhotoGroupBigEventBgItemView : UIBaseView
{
	public UINetworkTexture PreviewSpriteCDN;

	public UILabel Name;

	public UIButton SelectBtn;

	public GameObject Selected;

	public UILabel NotOwnedName;

	public UIButton GoToBtn;

	public GameObject NotOwnedGopos;

	public GameObject NotOwnedContainer;

	public GameObject Name_Container;

	public GameObject LeftTimeContainer;

	public UILabel LeftTimeLabel;

	public UISprite BackGroundPreview;

	public UILabel GoPosLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
