using GCommon;
using UnityEngine;

namespace COW;

public class UIRecLoadoutPlanListItemView : UIBaseView
{
	public UIButton ClickBtn;

	public GameObject UnselectedBg;

	public GameObject SelectedBg;

	public GameObject PublishedLabel;

	public GameObject UnPublishedLabel;

	public UILabel PlanNameLabel;

	public GameObject EditSprite;

	public GameObject Empty;

	public GameObject LikeButton;

	public GameObject LikedIcon;

	public GameObject NoLikeIcon;

	public Object NoLikeBtn;

	public GameObject LikeFX;

	public UILabel LikeLabel;

	public UILabel NumLabel;

	public UISprite AvatarSprite;

	public UILabel NoContentLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
