using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWereWolvesVoteItemView : UIBaseView
{
	public UIButton BtnItem;

	public GameObject PredictWolfIcon;

	public GameObject PredictHumanIcon;

	public GameObject SelfBG;

	public UISprite BG;

	public UILabel NameLabel;

	public UIWidget QuickChatTutorialWidget;

	public UIButton BtnQuickChat;

	public UISprite HeadPic;

	public UISprite HeadPicBg;

	public GameObject SelectObj;

	public GameObject Voted;

	public UISprite CountBG;

	public UILabel CountLabel;

	public GameObject DeadSprite;

	public GameObject Mic;

	public UIGrid VotedGridList;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
