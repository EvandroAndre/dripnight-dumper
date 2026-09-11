using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentDiamondEventView : UIBaseView
{
	public GameObject BeforeBuy;

	public Transform ItemList;

	public UICountDownLabel EndTime;

	public UIProgressBar ProgressBar;

	public UILabel Count;

	public UILabel Count1;

	public UILabel Count2;

	public UILabel Count3;

	public UILabel Count4;

	public UIPanel VFXRoot;

	public UIButton GoPosButton;

	public UILabel GoPosLabel;

	public UISprite GoPosIcon;

	public UILabel purchasingCountLabel;

	public GameObject AfterBuy;

	public UILabel DiamondGotLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
