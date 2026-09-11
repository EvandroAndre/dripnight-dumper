using GCommon;
using UnityEngine;

namespace COW;

public class UIVeteranReturnBarrageView : UIBaseView
{
	public GameObject HeadAndNameContainer;

	public GameObject FriendOnlineStyleContainer;

	public GameObject RankAndStreakStyleContainer;

	public GameObject WeaponPowerAndGMRankStyleContainer;

	public UISprite HeadPic;

	public UILabel CenterNickNameLabel;

	public UILabel TopNickNameLabel;

	public UILabel OnlineLabel;

	public UILabel SocialLabel;

	public UISprite StreakIcon;

	public UILabel StreakLabel;

	public UISprite RankIcon;

	public Transform WeaponPowerTrans;

	public Transform BRGMContainer;

	public Transform CSGMContainer;

	public GameObject GMContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
