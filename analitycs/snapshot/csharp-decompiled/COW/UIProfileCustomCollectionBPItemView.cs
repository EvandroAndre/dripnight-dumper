using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionBPItemView : UIBaseView
{
	public UISprite EPIcon;

	public GameObject BpBriefDetailList;

	public UIButton BpBriefBtn;

	public UIGrid SmallBPGrid;

	public UIButton RemoveBtn;

	public UIButton Button;

	public ProfileCustomDragDropItem DragItem;

	public GameObject Selected;

	public GameObject Icon;

	public GameObject BpBriefIcon;

	public GameObject bg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
