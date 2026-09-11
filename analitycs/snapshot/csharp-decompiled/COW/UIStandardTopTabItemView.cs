using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardTopTabItemView : UIBaseView
{
	public UIButton Button;

	public BoxCollider Collider;

	public UIWidget ItemWidget;

	public GameObject Select;

	public UISprite SelectBg;

	public UISprite SelectLine;

	public UILabel SelectLabel;

	public UISprite NewTabIcon;

	public GameObject UnSelect;

	public UISprite UnSelectBg;

	public UILabel UnSelectLabel;

	public UISprite TabIcon;

	public UITipsButton RedPoint;

	public GameObject LineUnSelect;

	public GameObject Hotbg;

	public UISprite UnSelectIcon;

	public GameObject NoticeContainer;

	public UILabel NoticeLabel;

	public UISprite NoticeBg;

	public UISprite NoticeBg02;

	public GameObject Line;

	public UINetworkTexture BgCdn;

	public UINetworkTexture TabIconCdn;

	public UINetworkTexture NewTabIconCdn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
