using GCommon;
using UnityEngine;

namespace COW;

public class UISeasonStatsDetailView : UIBaseView
{
	public GameObject TableRoot;

	public UITable2 Table;

	public UIScrollView SeasonStatsDetailItemScrollView;

	public UIWidget ShareContainer;

	public UISprite MaskBg;

	public Transform LeftTabNode;

	public Transform TopTabNode;

	public UILabel GameModelLabel;

	public Transform TableTrans;

	public Transform NoTabTableTrans;

	public UILabel HistorySeasonDataNotice;

	public GameObject WillStartNotice;

	public GameObject TopRightNode;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
