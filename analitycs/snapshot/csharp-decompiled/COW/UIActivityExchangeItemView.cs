using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityExchangeItemView : UIBaseView
{
	public UIWidget UIActivityExchangeItem;

	public UIScrollView AwardScrollView;

	public UIGrid AwardGrid;

	public Transform ExchangeItemGrid;

	public UIButton Operation;

	public Animation ButtonAnimation;

	public GameObject BGGray;

	public GameObject BGYellow;

	public GameObject Gained;

	public UILabel GainedLabel;

	public UILabel Title;

	public UIToggle RedTipsOnOff;

	public GameObject ProgressIcon;

	public UILabel ProgressTips;

	public UIScrollView ExchangeItemScrollView;

	public UIGrid ExchangeItemsGrid;

	public GameObject RedTipLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
