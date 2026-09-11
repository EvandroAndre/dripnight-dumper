using GCommon;
using UnityEngine;

namespace COW;

public class UICommonSettingDragableSliderItemView : UIBaseView
{
	public UILabel LeftLabel;

	public UICommonSettingDragDropContainer DragDropContainer;

	public UICommonSettingDragDropItem DragDropItem;

	public BoxCollider DragCollider;

	public UIWidget Widget;

	public UIButton DecreaseBtn;

	public UIButton IncreaseBtn;

	public UILabel SliderValue;

	public UISlider Slider;

	public GameObject Container;

	public UIButton TipBtn;

	public UICommonSettingDragDropItem DragDropBtn;

	public GameObject DraggingHighLight;

	public GameObject DownHighLight;

	public GameObject UpHighLight;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
