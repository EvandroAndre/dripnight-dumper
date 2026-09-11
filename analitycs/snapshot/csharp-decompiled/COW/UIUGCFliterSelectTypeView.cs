using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCFliterSelectTypeView : UIBaseView
{
	public UILabel TypeLabel;

	public UIScrollView TypeSV;

	public UITableWithBorder TypeTable;

	public UIToggleButtonGroup TypeGroup;

	public UIWidget MinContainer;

	public UIWidget TableMinHeight;

	public GameObject SVCollider;

	public GameObject Arrow;

	public UIWidget MaxContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
