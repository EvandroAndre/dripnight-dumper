using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassRewardPreviewView : UIBaseView
{
	public GameObject Main;

	public UIWidget PreviewBorder;

	public UILabel BPDiscountLabel;

	public UIButton BtnUnlock;

	public GameObject LabelOneChange;

	public UINetworkTexture CDNPreview;

	public UIGrid FPGrid;

	public UIGrid BPGrid;

	public UIButton EPLockBtn;

	public UILabel LabelUnlock;

	public UINetworkTexture MainBgTexture;

	public UINetworkTexture PremiumCDN;

	public UISprite BpDiscountSprite;

	public Transform Plane_loop;

	public UISprite Salebg;

	public GameObject BPVeteranDiscountContainer;

	public UILabel BPVeteranDiscountLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
