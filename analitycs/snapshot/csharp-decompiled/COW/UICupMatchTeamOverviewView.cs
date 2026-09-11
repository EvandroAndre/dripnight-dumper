using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchTeamOverviewView : UIBaseView
{
	public GameObject Content;

	public UISprite TeamIcon;

	public UIButton TeamIconBtn;

	public UILabel TeamName;

	public GameObject FlagBg;

	public UISprite NationFlag;

	public UIButton InfoEdit;

	public UIButton InfoEdit_bg;

	public UIButton TeamTier;

	public UILabel TierLevel;

	public GameObject NoTeamIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
