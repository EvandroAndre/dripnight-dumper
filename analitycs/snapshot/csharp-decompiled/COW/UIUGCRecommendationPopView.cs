using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCRecommendationPopView : UIBaseView
{
	public UIButton BlackBG;

	public Transform WindowContainer;

	public UIScrollView MapScrollView;

	public UITable ContentTable;

	public GameObject EditRecHead;

	public UILabel EditRecMainTile;

	public UILabel EditRecSideTille;

	public UINetworkTexture EditRecCDNIcon;

	public UITexture EditRecCDNTexture;

	public UILabel EditRecDesc;

	public GameObject HotHead;

	public GameObject SelfdomHead;

	public UILabel HotHeadMainTile;

	public UILabel HotHeadSideTile;

	public UILabel SelfdomHeadMainTile;

	public UIButton RecomRefreshBtn;

	public TweenRotation SelfdomRefreshIcon;

	public UIGrid Grid;

	public GameObject sep;

	public GameObject ExternalDisplayHead;

	public UILabel ExternalDisplayHeadTile;

	public GameObject NewPlayer;

	public UILabel NewPlayerTitle;

	public UILabel NewPlayerTime;

	public UILabel NewPlayerDesc;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
