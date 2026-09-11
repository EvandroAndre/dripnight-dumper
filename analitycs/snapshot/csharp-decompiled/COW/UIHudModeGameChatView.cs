using GCommon;
using UnityEngine;

namespace COW;

public class UIHudModeGameChatView : UIBaseView
{
	public GameObject ChatPanelContainer;

	public GameObject ChatPanelContainerBg;

	public GameObject NoChatLabel;

	public UIScrollView ChatPanel;

	public UILabel ChatItemTemplate;

	public UIButton QuickViewBtn;

	public GameObject ChatContainer;

	public GameObject BeforeInput;

	public GameObject AfterInput;

	public UILabel InputLabel;

	public UIButton SendBtn;

	public GameObject SendBtnSprite;

	public GameObject CDContainer;

	public UILabel CDLabel;

	public UIButton HideQuickViewBtn;

	public Transform Arrow;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
