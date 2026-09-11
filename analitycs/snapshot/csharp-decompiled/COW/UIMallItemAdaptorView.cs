using GCommon;
using UnityEngine;

namespace COW;

public class UIMallItemAdaptorView : UIBaseView
{
	public GameObject UIMallItemAdaptor;

	public UITipsButton Tips;

	public GameObject DiscountEffect;

	public GameObject Free;

	public GameObject OverDueTitle;

	public GameObject LimitedTitle;

	public GameObject PreviewFemale;

	public GameObject PreviewMale;

	public GameObject PreviewCommon;

	public GameObject OtherChannelContainer;

	public UILabel OtherChannelTitle;

	public UISprite OtherChannelIcon;

	public UISprite RankIcon;

	public UILabel ClanLevelLabel;

	public UILabel PurchaseLimit;

	public UILabel PeriodLimit;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
