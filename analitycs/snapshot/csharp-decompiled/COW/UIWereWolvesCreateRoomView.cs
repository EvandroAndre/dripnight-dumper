using GCommon;
using UnityEngine;

namespace COW;

public class UIWereWolvesCreateRoomView : UIBaseView
{
	public UIPanel TopPanel;

	public UILabel Title;

	public GameObject RoomGameSettingBtnGo;

	public UIButton close;

	public GameObject InfoPanel;

	public UIWidget RoomSettingPanel;

	public UISprite Map;

	public UILabel MapName;

	public UIInput NameInput;

	public UIInput CodeInput;

	public GameObject PlayerCountSettingRoot;

	public UILabel SettingPagePlayerCountLabel;

	public UIWidget PlayerCountPopMenu;

	public UIWidget WolfCountPopMenu;

	public UIButton CreateRoomBtn2;

	public UIButton LanguageBtn;

	public UISprite LanguageSprite;

	public GameObject LanguagaeCreateRoot;

	public UIPanel RoomSettingMaskPanel;

	public UIButton RoomSettingMask;

	public UIWidget GameSettingPanel;

	public UIButton CreateRoomBtn1;

	public UIButton ResetBtn;

	public UIToggleButton TrapOnBtn;

	public UIToggleButton TrapOffBtn;

	public UIToggleButton PredictOnBtn;

	public UIToggleButton PredictOffBtn;

	public UIGrid ParamsGrid;

	public UIPanel GameSettingMaskPanel;

	public UIButton GameSettingMask;

	public GameObject RoomCardGo;

	public UIWidget LevelLimitPopMenu;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
