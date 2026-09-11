using GCommon;
using UnityEngine;

namespace COW;

public class UILadderMatchNextRankInfoItemView : UIBaseView
{
	public Transform RankIconRoot;

	public UILabel RankNameLabel;

	public UILabel RankInfoLabel;

	public GameObject StarInfoContainer;

	public UILabel StarNum;

	public GameObject CurRankEffectContainer;

	public UISprite RankScoreIcon;

	public Transform CSRankIconRoot;

	public Transform HCRankRoot;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
