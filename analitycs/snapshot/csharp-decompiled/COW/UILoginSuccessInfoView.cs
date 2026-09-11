using GCommon;
using UnityEngine;

namespace COW;

public class UILoginSuccessInfoView : UIBaseView
{
	public UIButton BtnStartGame;

	public UIButton BgStartGame;

	public UIButton BtnLogout;

	public UIWidget CachedPlayerInfo;

	public UILabel CachedNicknameLabel;

	public GameObject StartGameLabel;

	public UISprite LogoutSprite;

	public Transform TopLeft;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
