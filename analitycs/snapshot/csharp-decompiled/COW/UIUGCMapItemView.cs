using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCMapItemView : UIBaseView
{
	public UIButton UIUGCMapItem;

	public TweenAlpha MapItemTween;

	public UINetworkTexture CDNMapIcon;

	public UILabel MapModeTxt;

	public UILabel LikeLabel;

	public GameObject bg;

	public UILabel LabelSubscribeCount;

	public UILabel LastPlayTxt;

	public UINetworkTexture KolMapIcon;

	public UIButton KolMapIconTips;

	public GameObject LockedCon;

	public GameObject KolMapIconMask;

	public UILabel MapNameTxt;

	public GameObject GameMap;

	public UITexture GameBitMap;

	public UITexture GameBitOutLineMap;

	public UISprite IconItemSpite;

	public UITexture GameMapBg;

	public UISprite MapIcon;

	public GameObject NormalLike;

	public GameObject NormalLikeSucc;

	public GameObject SpriteSubscribe;

	public GameObject SpriteSubscribeSucc;

	public UIPanel miniMapPanel;

	public GameObject SelectedVfx;

	public GameObject Heat;

	public UIPanel KolPanel;

	public GameObject OfflineTag;

	public GameObject BubbleTips;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
