using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionBattleCardItemView : UIBaseView
{
	public UILabel ValueLabel;

	public UILabel KeyLabel;

	public UILabel ModeLabel;

	public GameObject Selected;

	public UIButton RemoveBtn;

	public UIButton Button;

	public ProfileCustomDragDropItem DragItem;

	public GameObject BRBgContainer;

	public GameObject CSBgContainer;

	public GameObject Icon;

	public GameObject Main;

	public GameObject CSPeakBgContainer;

	public GameObject StreakMedalContainer;

	public UILabel StreakMedalLabel;

	public UISprite StreakMedalIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
