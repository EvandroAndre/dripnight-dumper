using GCommon;
using UnityEngine;

namespace COW;

public class UISeasonReplaySocialItemView : UIBaseView
{
	public UIEffectSprite HeadIcon;

	public UILabel NickName;

	public UISprite ProfileBG;

	public GameObject Selected;

	public UIButton SelectBtn;

	public UIWidget SelectBtnWidget;

	public GameObject AlreadyAddFriendIcon;

	public GameObject NotAddFriendIcon;

	public UIButton AddFriendBtn;

	public UILabel RecommonedDesc;

	public TweenScale ItemTweenScale;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
