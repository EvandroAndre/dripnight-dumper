using GCommon;
using UnityEngine;

namespace COW;

public class UITakePhotoGroupTemplateItemView : UIBaseView
{
	public UINetworkTexture PreviewSpriteCDN;

	public UILabel Name;

	public UILabel MemberCount;

	public UIButton SelectBtn;

	public GameObject Selected;

	public Transform DownLoadPos;

	public UILabel NotOwnedName;

	public UIButton GoToBtn;

	public GameObject NotOwnedGopos;

	public GameObject NotOwnedContainer;

	public GameObject Name_Container;

	public GameObject SelectedTri;

	public UISprite EditBackGroundPreviewCDN;

	public GameObject LeftTimeContainer;

	public UILabel LeftTimeLabel;

	public Transform TipsContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
