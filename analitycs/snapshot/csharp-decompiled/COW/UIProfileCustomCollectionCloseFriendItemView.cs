using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionCloseFriendItemView : UIBaseView
{
	public UILabel DuoNameLabel;

	public UIButton RemoveBtn;

	public UIEffectSprite MyHeadPic;

	public UIEffectSprite DuoFriendHeadPic;

	public UILabel DaysLabel;

	public UISprite RelationShipIcon;

	public UILabel RelationShipLevelLabel;

	public UIButton Button;

	public ProfileCustomDragDropItem DragItem;

	public GameObject Selected;

	public GameObject Icon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
