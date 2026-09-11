using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBattleStyleScoreBoardBuildIconView : UIBaseView
{
	public UISprite BuildIcon;

	public UILabel LevelText;

	public UIEventListener PressBtn;

	public Transform PopoverPivot;

	public GameObject PresetPickHideContainer;

	public GameObject NormalViewContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
