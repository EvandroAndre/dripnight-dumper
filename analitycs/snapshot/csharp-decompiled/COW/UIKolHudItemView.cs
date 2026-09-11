using GCommon;
using UnityEngine;

namespace COW;

public class UIKolHudItemView : UIBaseView
{
	public UIButton PlayerInfoBtn;

	public UISprite PlayerAvartarSprite;

	public UISprite FakeSprite;

	public UISprite VTag;

	public UILabel PlayerNameLabel;

	public UILabel NameLabel;

	public GameObject LikedIcon;

	public UIButton NoLikeIcon;

	public GameObject LikeFX;

	public UILabel LikeLabel;

	public TweenPosition NewLikeLabel;

	public GameObject SelectBg;

	public GameObject LikeButtonContainer;

	public UIButton Bg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
