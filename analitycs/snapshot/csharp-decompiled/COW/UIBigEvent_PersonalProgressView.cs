using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_PersonalProgressView : UIBaseView
{
	public UINetworkTexture TextureTitle;

	public UIButton BtnRule;

	public UISprite Sprite;

	public UILabel LabelOpenTime;

	public UIButton BtnClose;

	public UISprite SpriteBtnClose;

	public UINetworkTexture TextureBtnClose;

	public Transform TrAdsScrollRoot;

	public UINetworkTexture TextureAdsBg;

	public UIGrid GridLeftBtns;

	public UINetworkTexture TextureBg;

	public UIButton BtnShare;

	public UINetworkTexture TextureShareBtn;

	public UILabel LabelMotivateShare;

	public Transform ShareBtnBubble;

	public UILabel LabelProcessValue;

	public UINetworkTexture TextureProcessTokenBg;

	public UIProgressBar ProgressBar;

	public UISprite ProcessBarBg;

	public GameObject TopLeft;

	public UIAnchor TopLeftAnchor;

	public GameObject TopRight;

	public GameObject Right;

	public GameObject Left;

	public UIButton Mask;

	public GameObject PersonalProcessContainer;

	public Transform TrBarItemRoot;

	public Transform TrHelpTipRoot;

	public UINetworkTexture TextureProgressBg;

	public Transform Content;

	public UINetworkTexture TextureShareBubbleBg;

	public UINetworkTexture TextureMotivateShare;

	public Transform TokenItemTrans;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
