using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisLobbyDifficultyPanelView : UIBaseView
{
	public UIToggleButton EasyMode;

	public UIWidget soloBtnWidget;

	public UIGrid DifficultyGrid;

	public UIToggleButtonGroup DifficultyGroup;

	public UIToggleButton HardMode;

	public UIWidget duoBtnWidget;

	public UISprite ModesBg;

	public UIPanel UIHippoCrisisLobbyDifficultyPanel;

	public GameObject Limit_Container;

	public UILabel Label;

	public Transform OpenTimePos;

	public UIButton HardMask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
