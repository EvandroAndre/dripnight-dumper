using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_Template_LobbyWarmUpView : UIBaseView
{
	public UINetworkTexture BgTexture;

	public UICountDownLabel CountDown;

	public UILabel ActivityDesc;

	public UINetworkTexture TitleTexture;

	public UINetworkTexture LeftGiftTex;

	public UINetworkTexture RightGiftTex;

	public UIButton BtnClose;

	public Animation main;

	public UINetworkTexture CloseSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
