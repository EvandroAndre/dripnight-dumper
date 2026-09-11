using GCommon;
using UnityEngine;

namespace COW;

public class UIBigMapObEventView : UIBaseView
{
	public GameObject eventContainer;

	public UIBigMapObEventDragDropItem DragDropItem;

	public UISprite eventIcon;

	public GameObject onRelease;

	public UIButton yes;

	public UISprite yesSprite;

	public UIButton no;

	public GameObject targetPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
