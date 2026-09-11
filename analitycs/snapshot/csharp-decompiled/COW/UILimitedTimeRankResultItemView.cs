using GCommon;
using UnityEngine;

namespace COW;

public class UILimitedTimeRankResultItemView : UIBaseView
{
	public GameObject RankBeforeContanier;

	public GameObject RankAfterContanier;

	public UILabel RankPointDiff;

	public UISprite RankBeforeIcon;

	public UILabel RankBeforeLabel;

	public UISprite RankAfterIcon;

	public UILabel RankAfterLabel;

	public Animation MainContainer;

	public UIButton RankPointDetailBtn;

	public GameObject Arrow;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
