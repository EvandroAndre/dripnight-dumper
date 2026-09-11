using GCommon;
using UnityEngine;

namespace COW;

public class UIHudAceTeamView : UIBaseView
{
	public GameObject TeamWipeoutIcon;

	public GameObject ClanWipeoutIcon;

	public Animation main;

	public TweenAlpha AceTeamContainer;

	public GameObject BGRoot;

	public UISprite PrivilegeTeamWipeoutIcon;

	public GameObject KillCount;

	public GameObject TeamWipeoutLabel;

	public UILabel NormalTeamWipeoutLabel;

	public GameObject PrivilegeLabelRoot;

	public UILabel PrivilegeTeamWipeoutLabel;

	public UISprite TeamWipeoutBg;

	public Transform SpecialVFX;

	public GameObject OriginLabelRoot;

	public Transform ConfigPrivilegeLabelRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
