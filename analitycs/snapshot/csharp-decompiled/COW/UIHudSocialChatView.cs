using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSocialChatView : UIBaseView
{
	public GameObject UIHudSocialChat;

	public UIButton RecruitTeammateBtn;

	public UIButton ChatBtn;

	public Transform ChatRedTips;

	public GameObject LatestMessage;

	public UILabel LatestMessageLabel;

	public UIButton ChatMessageBtn;

	public GameObject CommonChatBG;

	public GameObject MessageChatBtnBG03;

	public UIGrid ChatBtnGroup;

	public UIButton ChatRecruitBtn;

	public GameObject ChatBtnBG01;

	public GameObject CommonChatBGMin;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
