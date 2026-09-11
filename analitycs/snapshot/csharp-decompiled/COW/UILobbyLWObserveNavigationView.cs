using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyLWObserveNavigationView : UIBaseView
{
	public UIButton CloseBtn;

	public Transform ScoreboardRoot;

	public UIButton SwitchBtn;

	public UINetworkTexture HeadIcon;

	public UIEffectSprite HeadSprite;

	public UISprite HeadFakeSprite;

	public UIButton AddFriendBtn;

	public UILabel NameLabel;

	public UIButton CloseBtn2;

	public GameObject AddFriendSprite;

	public GameObject IsFriendSprite;

	public UIButton AntihackBtn;

	public UICountDownLabel QuitLabel;

	public GameObject BG1;

	public GameObject BG2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
