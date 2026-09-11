using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCBigEvent_GlobalProgressView : UIBaseView
{
	public GameObject TopLeft;

	public UINetworkTexture TextureTitle;

	public UIButton BtnRule;

	public UILabel LabelOpenTime;

	public UIButton BtnClose;

	public UISprite SpriteBtnClose;

	public GameObject Right;

	public UILabel LabelProgress;

	public UINetworkTexture TextureLabelProgressBg;

	public UIProgressBar ProgressBar;

	public UISprite ProcessBarBg;

	public Transform TrBarItemRoot;

	public Transform TrAdsScrollRoot;

	public UINetworkTexture TextureAdsBg;

	public GameObject Left;

	public UIGrid GridLeftBtns;

	public UIButton Mask;

	public UINetworkTexture TextureBg;

	public UIButton BtnShare;

	public GameObject Content;

	public GameObject ShareCDN;

	public UISprite IconOpenTime;

	public UINetworkTexture TextureShareBtn;

	public UINetworkTexture TextureBtnClose;

	public Transform TokenItemTrans;

	public GameObject GoActivity;

	public Transform GoOpenTimeContainer;

	public UINetworkTexture TextureUGCRightTitle;

	public GameObject LoadingbgSprite;

	public UINetworkTexture TextureShare;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
