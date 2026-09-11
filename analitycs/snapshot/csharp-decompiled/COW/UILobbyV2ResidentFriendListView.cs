using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2ResidentFriendListView : UIBaseView
{
	public UIButton AddFriendBtn;

	public UIScrollView FriendScrollView;

	public Transform BriefBoxPos;

	public UISprite BG;

	public UIEasyList FriendList;

	public UIWidget ScrollViewWidget;

	public UISprite FriendAddWidget;

	public Animation InAnim;

	public VFXCreateHelper CSPeakNotiy;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
