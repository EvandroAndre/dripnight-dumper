using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_PersonalProgress_BarItemView : UIBaseView
{
	public UILabel LabelNodeValue;

	public UIButton BtnAward;

	public UINetworkTexture TextureRewardCantClaimMark;

	public UINetworkTexture TextureRewardBg;

	public Transform TrItemRoot;

	public GameObject GoFinish;

	public UINetworkTexture TextureNormalBg;

	public UINetworkTexture TextureLightBg;

	public UISprite SpriteRedDot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
