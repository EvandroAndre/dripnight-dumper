using GCommon;
using UnityEngine;

namespace COW;

public class UIInGameChatView : UIBaseView
{
	public UIButton EnterBtn;

	public UIInput InputContainer;

	public UIWidget InputWidget;

	public Transform MessageContainer;

	public GameObject SendMessageContainer;

	public GameObject VoiceToTextContainer;

	public UIButton DisableEnterBtn;

	public UIButton VoiceBtn;

	public GameObject BubbleTips;

	public GameObject AntiAddictionBRHint;

	public GameObject AntiAddictionBRCantChatContainer;

	public UILabel AntiAddictionBRCantChatLabel;

	public GameObject NewMessage;

	public UIButton NewMessageBtn;

	public UILabel NewMessageLabel;

	public UISprite InputBg;

	public UILabel InputDefaultLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
