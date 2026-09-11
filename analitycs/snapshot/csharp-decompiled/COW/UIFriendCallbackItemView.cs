using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendCallbackItemView : UIBaseView
{
	public UIButton headbtn;

	public UINetworkTexture HeadIcon;

	public UIEffectSprite HeadSprite;

	public GameObject FakeSprite;

	public UILabel NickName;

	public GameObject PlatformName;

	public GameObject PlatformIcon;

	public UILabel PlatformNickNameLabel;

	public UILabel LastLoginTime;

	public UISprite RequestBG;

	public UISprite BigEventBG;

	public UILabel StateOnline;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
