using GCommon;
using UnityEngine;

namespace COW;

public class UIChatBottomLeftView : UIBaseView
{
	public GameObject InputNode;

	public GameObject SendMessageContainer;

	public UIInput InputContainer;

	public UIButton EnterBtn;

	public UIGrid OtherSendBtnGrid;

	public UIButton OpenStickerBtn;

	public UIButton LoudSpeakerBtn;

	public UISprite SpeakerIcon;

	public UILabel SpeakerNum;

	public GameObject MutedNode;

	public UIButton MutedHintBtn;

	public Transform MutedCountDown;

	public GameObject NewMessage;

	public UIButton NewMessageBtn;

	public UILabel NewMessageLabel;

	public GameObject IngameHint;

	public UILabel WhisperStatusHint;

	public Transform StickerNode;

	public UIButton SloganBubbleBtn;

	public UILabel SloganBubbleLabel;

	public Transform FastMessageNode;

	public UIPanel FastMessageNodePanel;

	public UIButton FastMessageBtn;

	public UIPanel main;

	public UIPanel SilenceContainer;

	public UILabel SilenceLabel;

	public Transform SilenceTime;

	public UILabel AntiAddictionBRHintLabel;

	public GameObject AntiAddictionBRCantChatContainer;

	public UILabel AntiAddictionBRCantChatLabel;

	public GameObject AntiAddictionBRHint;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
