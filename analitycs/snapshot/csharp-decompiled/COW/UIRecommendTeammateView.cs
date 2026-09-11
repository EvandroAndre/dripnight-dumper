using GCommon;
using UnityEngine;

namespace COW;

public class UIRecommendTeammateView : UIBaseView
{
	public UILabel TimeLabel;

	public UIButton BtnClose;

	public UILabel MessageLabel;

	public UILabel MessageLabel2;

	public UIButton AcceptBtn;

	public GameObject Mask;

	public UILabel BtnLabel;

	public UILabel PlayerIndex;

	public UISprite PlayerIndexBG;

	public UILabel PlayerName;

	public UISprite HeadPicIcon;

	public GameObject WinStreak;

	public UISprite WinStreakIcon;

	public UILabel WinStreakLabel;

	public GameObject WeaponPower;

	public GameObject HeadPic;

	public GameObject PrivilegeIcon;

	public Transform AvatarFramePos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
