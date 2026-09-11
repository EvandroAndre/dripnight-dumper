using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomClanWarHistoryItemView : UIBaseView
{
	public UIButton Button;

	public ProfileCustomDragDropItem DragItem;

	public GameObject Selected;

	public UIButton RemoveBtn;

	public GameObject Icon;

	public GameObject NormalBG;

	public UISprite ClanWarHistoryIcon;

	public UILabel GloryNumLabel;

	public UIButton GotoGloryBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
