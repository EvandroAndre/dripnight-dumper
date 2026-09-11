using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_TwoTeamFactionView : UIBaseView
{
	public UILabel myTeamName;

	public UILabel myTeamDesc;

	public UISprite myTeamIcon;

	public UISprite myDefaultTeamIcon;

	public UILabel oppoTeamName;

	public UILabel oppoTeamDesc;

	public UISprite oppoTeamIcon;

	public UISprite oppoDefaultTeamIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
