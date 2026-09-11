using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarEmblemHistoryItemView : UIBaseView
{
	public UILabel TimeLabel;

	public UISprite RankIcon;

	public UILabel RankLabel;

	public UILabel RankLabelShadow1;

	public UILabel RankLabelShadow2;

	public UIButton RuleBtn;

	public UILabel RegionGloryRankLabel;

	public UILabel LocationLabel;

	public UILabel GloryLabel;

	public GameObject Glory;

	public GameObject Emblem;

	public GameObject RegionGloryIcon;

	public GameObject GlobalGloryIcon;

	public UILabel GlobalGloryRankLabel;

	public UISprite EmblemBar;

	public UILabel EmblemLocationLabel;

	public GameObject UnSelectedFrame;

	public GameObject SelectedFrame;

	public UIButton ItemBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
