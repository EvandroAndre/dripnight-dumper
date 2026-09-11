using GCommon;
using UnityEngine;

namespace COW;

public class UIIPCollabBottomTabItemView : UIBaseView
{
	public GameObject UIIPCollabBottomTabItem;

	public UIButton UIIPCollabBottomTabItemBtn;

	public GameObject DefaultBG;

	public UILabel Label;

	public GameObject SelectCDNBg;

	public UINetworkTexture SelectCDNBgNetWorkTexture;

	public GameObject CustomVFX;

	public GameObject SelectSprite;

	public GameObject UnSelectSprite;

	public GameObject SelectVFX;

	public UINetworkTexture UnSelectCDNBGNetWorkTexture;

	public GameObject UnSelectCDNBG;

	public GameObject SelectContainer;

	public GameObject UnSelectContainer;

	public UINetworkTexture AllOwnCDNBGNetworkTexture;

	public GameObject AllOwnCDNBG;

	public GameObject NotAllOwnCDNBG;

	public UINetworkTexture NotAllOwnCDNBGNetworkTexture;

	public GameObject RedPoint;

	public UIColor line;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
