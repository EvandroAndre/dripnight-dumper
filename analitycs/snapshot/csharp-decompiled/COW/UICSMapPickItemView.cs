using GCommon;
using UnityEngine;

namespace COW;

public class UICSMapPickItemView : UIBaseView
{
	public UILabel Index;

	public UILabel MapName;

	public GameObject Highlight;

	public UIButton ItemBtn;

	public UILabel IndexSelect;

	public UILabel MapNameSelect;

	public GameObject Selected;

	public GameObject UnSelected;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
