using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentSquadTreasureLeaderNoticePopupWindowView : UIBaseView
{
	public UILabel TitleLabel;

	public UITable TeamListTable;

	public GameObject UnActiveContainer;

	public GameObject ActiveContainer;

	public UILabel DescLabel;

	public UIButton OkBtn;

	public UIButton InviteBtn;

	public UIButton IAPBtn;

	public UILabel TeamNameLabel;

	public GameObject Top;

	public UIButton Close;

	public Animation Main;

	public GameObject UIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
