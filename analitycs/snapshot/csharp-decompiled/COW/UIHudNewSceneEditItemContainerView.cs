using GCommon;
using UnityEngine;

namespace COW;

public class UIHudNewSceneEditItemContainerView : UIBaseView
{
	public UISprite ItemSprite;

	public GameObject Highlight;

	public UIButton ItemButton;

	public UIHudSceneEditItemDragDropItem DragDropItem;

	public UIDragScrollView DragSrcollView;

	public BoxCollider ItemButtonCollider;

	public GameObject ForbiddenSprite;

	public GameObject NewObj;

	public GameObject MustModeSprite;

	public GameObject AITag;

	public UILabel LabelName;

	public GameObject Loading;

	public GameObject Mask;

	public GameObject OpenShopBtn;

	public GameObject LabelBg;

	public UIButton Edit;

	public UITexture ItemTexture;

	public UINetworkTexture ItemNetworkTexture;

	public UISprite SpriteShopStatus;

	public UIButton ButtonShopStatus;

	public GameObject AIGenBtn;

	public UISprite SpriteBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
