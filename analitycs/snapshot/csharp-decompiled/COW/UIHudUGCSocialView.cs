using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGCSocialView : UIBaseView
{
	public UIButton FriendListBtn;

	public UIButton ChatBtn;

	public GameObject LatestMessage;

	public UILabel LatestMessageLabel;

	public UIButton ChatMessageBtn;

	public Transform ChatRedTips;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
