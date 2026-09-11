using GCommon;
using UnityEngine;

namespace COW;

public class UIhudMicroPhoneMuteView : UIBaseView
{
	public UISprite MicSprite;

	public UISprite MicBanStyle2;

	public UISprite SpriteMuteToggleBg;

	public UISprite MicMuteState;

	public GameObject MicBanContainer;

	public UISprite MicBanStyle1;

	public UISprite DisconnectState;

	public UIButton DisconnectStateBtn;

	public UIButton ToggleBtn;

	public GameObject ConnectState;

	public Transform MemberVoiceContainer;

	public GameObject MicPressedVFX;

	public Transform MemberVoiceContainer_NoPress;

	public Transform LobbySocialMemberVoiceContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
