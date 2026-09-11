using GCommon;
using UnityEngine;

namespace COW;

public class UIActivitySimpleExchangeItemView : UIBaseView
{
	public UIWidget UIActivitySimpleExchangeItem;

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

	public GameObject PlusSprite;

	public GameObject OrLabel;

	public UITable ItemTable;

	public Transform Arrow;

	public UITable ExchangeItemTable;

	public GameObject RedTipLabel;

	public GameObject main;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
