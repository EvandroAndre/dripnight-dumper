using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchNpc_RepeatRewardPrePopView : UIBaseView
{
	public UILabel RepeatRewardDesc;

	public UIGrid RewardContainer;

	public UISprite BgMask;

	public UINetworkTexture CdnBg;

	public UIButton CloseClick;

	public UIScrollView RewardScrollView;

	public UIEasyList RewardEasyList;

	public UINetworkTexture DownArrow;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
