using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCHudWidgetInspectorView : UIBaseView
{
	public UIButton SwitchBtn;

	public GameObject BG;

	public UIScrollView ScrollView;

	public UITable Table;

	public GameObject NameAttribute;

	public UISprite Icon;

	public UILabel Name;

	public UILabel TextAttribute;

	public UILabel ImageAttribute;

	public UILabel ButtonAttribute;

	public UILabel TransformAttribute;

	public UIButton EditBtn;

	public UIWidget Container;

	public Transform ZEnd;

	public UILabel EmptyAttribute;

	public UIWidget GuideMask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
