using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_TwoTeamMatchInfoSimpleNewView : UIBaseView
{
	public UILabel LeftScore;

	public UILabel RightScore;

	public UISprite LeftDeadIcon;

	public UILabel LeftDeadCount;

	public UILabel RightAliveCount;

	public UISprite RightAliveIcon;

	public UISprite LeftAliveIcon;

	public UILabel LeftAliveCount;

	public UISprite RightDeadIcon;

	public UILabel RightDeadCount;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
