using GCommon;
using UnityEngine;

namespace COW;

public class UIChampionshipReviewRewardListView : UIBaseView
{
	public UIWidget Container;

	public UIButton BtnClose;

	public UILabel EmptyTips;

	public GameObject ScrollViewTop;

	public GameObject ScrollViewBottom;

	public UIPanel ScrollPanel;

	public UIEasyList EasyList;

	public UILabel ChampionLabel;

	public UIGrid Grid;

	public GameObject ChampionshipDefaultIcon;

	public UINetworkTexture ChampionshipTexture;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
