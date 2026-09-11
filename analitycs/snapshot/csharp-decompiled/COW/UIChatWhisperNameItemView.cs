using GCommon;
using UnityEngine;

namespace COW;

public class UIChatWhisperNameItemView : UIBaseView
{
	public UIButton Btn;

	public UIButton Delate;

	public GameObject Highlight;

	public UISprite HeadPic;

	public UILabel Name;

	public UISprite LadderIcon;

	public UILabel Status;

	public UINetworkTexture HeadNetPic;

	public GameObject UnreadTip;

	public GameObject PrivilegeIcon;

	public Transform AvatarFramePos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
