using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCBigEvent_GlobalProgress_BarItemView : UIBaseView
{
	public UILabel LabelPercentage;

	public UIButton BtnAward;

	public UINetworkTexture TextureRewardCantClaimMask;

	public UISprite SpriteRedDot;

	public UINetworkTexture TextureRewardBg;

	public Transform TrItemRoot;

	public GameObject GoFinish;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
