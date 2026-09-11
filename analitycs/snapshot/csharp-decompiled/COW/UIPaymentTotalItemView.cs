using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentTotalItemView : UIBaseView
{
	public UILabel DescLabel;

	public UILabel ClaimedLabel;

	public GameObject ClaimedSprite;

	public UIButton ClaimButton;

	public UIButton TopupButton;

	public UIGrid ContentsGrid;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
