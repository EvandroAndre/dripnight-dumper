using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_SingleLeaderboardView : UIBaseView
{
	public UIScrollView TeamScrollView;

	public UIEasyList TeamGrid;

	public UIButton SpaceBtn;

	public UIGrid TitleGrid;

	public UILabel LabelTemp;

	public UILabel PlayerTitle;

	public Transform selfRank;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
