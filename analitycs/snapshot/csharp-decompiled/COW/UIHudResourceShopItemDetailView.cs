using GCommon;
using UnityEngine;

namespace COW;

public class UIHudResourceShopItemDetailView : UIBaseView
{
	public UINetworkTexture NetworkTextureCover;

	public UITexture TextureCover;

	public UIButton BtnAdd;

	public UIButton BtnRemove;

	public UIButton BtnUse;

	public UILabel LabelDesc;

	public UIButton BtnDownload;

	public UIButton BtnTakeDown;

	public UIGrid StateGrid;

	public UIButton BtnReviewing;

	public UILabel LabelAuthor;

	public UIGrid TagContainer;

	public UILabel LabelStatus;

	public GameObject Review;

	public UISprite SpriteStatus;

	public UILabel LabelLike;

	public UIToggle ToggleLike;

	public UILabel LabelBuy;

	public UILabel LabelCost;

	public GameObject Cost;

	public UIButton BtnReport;

	public UIButton BtnLike;

	public UIButton BtnClose;

	public UILabel LabelTitle;

	public UIButton BtnCode;

	public UIButton Mask;

	public UISprite SpriteAuthor;

	public UILabel LabelTime;

	public GameObject LikeFX;

	public GameObject LabelNewLike;

	public UILabel BtnUseLabel;

	public UISprite SpriteCover;

	public UIGrid ButtonGrid;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
