using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSpeakerMuteView : UIBaseView
{
	public UISprite SpeakerNotMuteSprite;

	public UISprite SpeakerMutedSprite;

	public UISprite CloseSprite;

	public UISprite bg;

	public UISprite DisconnectState;

	public GameObject ConnectState;

	public UIWidget SpeakerMuteToggleWidget;

	public UIButton SpeakerMuteToggle;

	public UIButton DisconnectStateBtn;

	public Transform MemberVoiceContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
