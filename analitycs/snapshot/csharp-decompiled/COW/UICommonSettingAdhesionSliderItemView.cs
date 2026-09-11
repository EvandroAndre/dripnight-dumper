using GCommon;
using UnityEngine;

namespace COW;

public class UICommonSettingAdhesionSliderItemView : UIBaseView
{
	public UIWidget Widget;

	public UILabel LeftLabel;

	public UIButton TipBtn;

	public UISlider Slider;

	public UILabel Value;

	public Transform AdhesionPoint;

	public UIWidget AsChildWidget;

	public UILabel ChildLabel;

	public GameObject AsNormal;

	public UISprite RightSprite;

	public UISprite LeftSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
