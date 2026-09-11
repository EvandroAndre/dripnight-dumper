using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMatchResult2TeamsGridItemBombView : UIBaseView
{
	public GameObject Self;

	public UIButton SimpleProfileInfo;

	public UIEffectSprite bannerBg;

	public GameObject fakeBg;

	public UIEffectSprite HeadIcon;

	public GameObject infoContainer;

	public UILabel nickname;

	public UILabel clanName;

	public UILabel Kill;

	public UILabel Death;

	public UILabel Assist;

	public UILabel Damage;

	public UILabel BD;

	public UILabel BP;

	public UILabel Evaluation;

	public GameObject Mvp;

	public UIButton AddFriendBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
