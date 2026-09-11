using GCommon;
using UnityEngine;

namespace COW;

public class UILeaderBoardTitleIconView : UIBaseView
{
	public Transform Container;

	public Animator IconAnimator;

	public UILabel RankLabel;

	public UISprite BG;

	public UILabel RankLabelShadow1;

	public UILabel RankLabelShadow2;

	public Transform VFXPos;

	public GameObject PeakTitle;

	public GameObject NormalTitle;

	public UISprite PeakBG;

	public UILabel PeakLabel;

	public UILabel PeakShadow1;

	public UILabel PeakShadow2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
