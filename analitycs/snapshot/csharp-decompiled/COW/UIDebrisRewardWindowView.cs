using GCommon;
using UnityEngine;

namespace COW;

public class UIDebrisRewardWindowView : UIBaseView
{
	public UILabel TitleLabel;

	public UIGrid AwardGrid;

	public AwardItemView ItemInstance;

	public UISprite RewardIcon;

	public UILabel ItemNameLabel;

	public UIButton BtnConfirm;

	public UISprite ConfirmBtnBg;

	public Transform BGTopPos2;

	public Transform BGBottomPos2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
