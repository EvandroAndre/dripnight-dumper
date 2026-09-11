using GCommon;
using UnityEngine;

namespace COW;

public class UIRelayMartDiscountCodeStateItemView : UIBaseView
{
	public GameObject ProfileInfoContainer;

	public UILabel DiscountCodeLabel;

	public GameObject UsedState;

	public GameObject UnusedState;

	public GameObject ClaimedState;

	public UIButton ClaimBtn;

	public UIButton CopyBtn;

	public UIButton ShareBtn;

	public UIButton IsPublicCheckBox;

	public GameObject SpriteSelect;

	public UILabel RebateDiamondsCount;

	public GameObject DiscountCodeUsedLabel;

	public GameObject CheckNoticeBubble;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
