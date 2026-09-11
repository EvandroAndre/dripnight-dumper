using GCommon;
using UnityEngine;

namespace COW;

public class UIReplayKitNodeView : UIBaseView
{
	public UITable Table;

	public GameObject ReplayEmpty;

	public UIToggleButtonGroup ReplayLobbyToggleBtnGroup;

	public UIToggleButton LobbyBtnOn;

	public UIToggleButton LobbyBtnOff;

	public UILabel LblMemory;

	public UISprite IconMemory;

	public UISprite IconReplayMemory;

	public UIToggleButtonGroup ReplayInGameToggleBtnGroup;

	public UIToggleButton InGameBtnOn;

	public UIToggleButton InGameBtnOff;

	public GameObject Down;

	public GameObject ReplayContent;

	public UIButton BtnTips;

	public UIInput SearchInput;

	public UIButton SearchBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
