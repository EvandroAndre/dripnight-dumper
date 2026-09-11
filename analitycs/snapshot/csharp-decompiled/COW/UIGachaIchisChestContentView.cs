using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIchisChestContentView : UIBaseView
{
	public Transform MainContainer;

	public GameObject GachaPrimeCountDown;

	public GameObject CountDownContent;

	public UICountDownLabel GachaCountDownLabel;

	public GameObject LocalTitleName;

	public GameObject CDNTitleName;

	public UINetworkTexture CDNTitleNetworkTexture;

	public GameObject VFXContainer;

	public GameObject BuyBtnContainer;

	public GameObject GuaranteedDrop;

	public GameObject GuaranteedDropGuideContainer;

	public UILabel GuaranteedDropLabel;

	public GameObject HighlightContainer;

	public Transform NotPrimeLimitBuyTipsTr;

	public Transform RightContainer;

	public UIWidget PreviewBorder;

	public UIBarrageLauncher BarragePanel;

	public UIBarrageLauncher BarragePanel2;

	public UIGachaIchisPoolSwitchAnimConfigHolder UIGachaIchisPoolSwitchAnimConfigHolder;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
