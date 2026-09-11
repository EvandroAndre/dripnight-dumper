using GCommon;
using UnityEngine;

namespace COW;

public class UITakePhotoFilterView : UIBaseView
{
	public UIGrid FilterGrid;

	public UIButton CloseBtn;

	public UIColor Color;

	public UILabel Title;

	public GameObject TabRoot;

	public UIButton FilterTabBtn;

	public UIButton EffectTabBtn;

	public GameObject FilterTabSelect;

	public GameObject FilterTabUnselect;

	public GameObject EffectTabSelect;

	public GameObject EffectTabUnselect;

	public UIGrid EffectGrid;

	public Transform ScrollViewRoot;

	public UIScrollView ScrollView;

	public Transform PosUnderTab;

	public Transform PosUnderLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
