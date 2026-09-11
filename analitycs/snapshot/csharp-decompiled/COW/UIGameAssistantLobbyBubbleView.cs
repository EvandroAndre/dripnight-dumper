using GCommon;
using UnityEngine;

namespace COW;

public class UIGameAssistantLobbyBubbleView : UIBaseView
{
	public GameObject PetPanelEntry;

	public GameObject LobbyEntry;

	public Animation NewMessageAnim;

	public GameObject NoPetSprite;

	public UIButton LobbyEntryClickBtn;

	public GameObject Main;

	public UIButton PetPanelEntryClickBtn;

	public GameObject LobbyNewMessageIcon;

	public TweenScale EntryTweenScale;

	public TweenAlpha EntryTweenAlpha;

	public UISprite Lobbyicon;

	public UISprite Peticon;

	public GameObject LobbyTextBubbleEntry;

	public UIButton LabelButton;

	public UILabel PresetBubbleLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
