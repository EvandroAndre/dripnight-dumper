using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaDoubleWheelCommonRewardItemView : UIBaseView
{
	public UIButton ClickButtonL;

	public BaseItemView2 BaseInfoViewL;

	public GameObject FinishedL;

	public BaseItemView2 BaseInfoViewR;

	public UIButton ClickButtonR;

	public GameObject FinishedR;

	public Animation HighlightL;

	public Animation HighlightR;

	public GameObject RefreshVFXL;

	public GameObject RefreshVFXR;

	public GameObject ComplimentaryL;

	public GameObject ComplimentaryR;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
