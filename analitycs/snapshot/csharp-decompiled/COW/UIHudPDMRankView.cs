using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPDMRankView : UIBaseView
{
	public UILabel SelfRank;

	public UILabel Total;

	public UIScrollView ItemScroll;

	public Transform ItemRoot;

	public UIGrid Grid;

	public GameObject Light1;

	public GameObject Light2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
