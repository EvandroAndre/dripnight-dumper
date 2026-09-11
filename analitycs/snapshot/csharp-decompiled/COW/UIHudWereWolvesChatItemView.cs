using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWereWolvesChatItemView : UIBaseView
{
	public GameObject OtherNode;

	public UILabel OtherNameLabel;

	public UISprite OtherHeadPic;

	public UISprite OtherHeadBg;

	public UISprite OtherCountBG;

	public UILabel OtherCountLabel;

	public UILabel OtherChatLabel;

	public UISprite OtherChatBG;

	public GameObject SelfNode;

	public UILabel SelfNameLabel;

	public UISprite SelfHeadPic;

	public UISprite SelfHeadBg;

	public UISprite SelfCountBG;

	public UILabel SelfCountLabel;

	public UILabel SelfChatLabel;

	public UISprite SelfChatBG;

	public GameObject VoteNode;

	public UISprite VoteCountBG;

	public UILabel VoteCountLabel;

	public UILabel VoteInfoLabel;

	public GameObject RoundNode;

	public UILabel RoundLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
