using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchNpc_RewardWndView : UIBaseView
{
	public UINetworkTexture BgTexture;

	public UILabel TitleLabel;

	public UIButton OkBtn;

	public UILabel OKBtnLabel;

	public UINetworkTexture BtnCdn;

	public UIGrid RewardGrid;

	public Transform BundleBoxVFX;

	public UIScrollView RewardScrollView;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
