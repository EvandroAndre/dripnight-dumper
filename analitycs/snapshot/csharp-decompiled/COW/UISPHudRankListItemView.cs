using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudRankListItemView : UIBaseView
{
	public UIWidget UISPHudRankListItem;

	public UILabel RankLabel;

	public GameObject Grade1;

	public GameObject Grade2;

	public GameObject Grade3;

	public UISprite TeamIcon;

	public UISprite FakeIcon;

	public UILabel TeamName;

	public UILabel ScoreLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
