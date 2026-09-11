using GCommon;
using UnityEngine;

namespace COW;

public class UILootBoxCustomItemView : UIBaseView
{
	public UIButton UILootBoxCustomItem;

	public UIDragScrollView ItemDragScrollView;

	public UILabel Label;

	public GameObject IndexNum;

	public UIGrid IndexContainer;

	public GameObject IndexBg_Select;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
