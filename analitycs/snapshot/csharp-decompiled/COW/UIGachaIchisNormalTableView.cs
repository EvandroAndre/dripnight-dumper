using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIchisNormalTableView : UIBaseView
{
	public UIGachaIchisTableBaseView BaseView;

	public TweenPosition TableTweenPos;

	public Animation MainAnim;

	public UIPanel Panel;

	public UIButton CarouselBtn;

	public GameObject UIFX_Ichis_Normal_Entry;

	public UIPanel MidPanel;

	public UIPanel PrizePoolPanel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
