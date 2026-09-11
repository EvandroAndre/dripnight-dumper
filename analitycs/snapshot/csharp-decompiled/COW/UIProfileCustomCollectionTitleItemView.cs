using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionTitleItemView : UIBaseView
{
	public UIButton Button;

	public ProfileCustomDragDropItem DragItem;

	public UIButton RemoveBtn;

	public GameObject Selected;

	public Transform Title;

	public GameObject Icon;

	public GameObject NormalBgContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
