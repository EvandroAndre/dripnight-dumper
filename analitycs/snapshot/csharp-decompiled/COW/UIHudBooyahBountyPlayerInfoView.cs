using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBooyahBountyPlayerInfoView : UIBaseView
{
	public UILabel TotalNumTxt;

	public GameObject DetailContent;

	public UIButton BtnShowDetail;

	public UILabel DeltaNumTxt;

	public GameObject DeltaNumRoot;

	public GameObject UIFX_BooyahIcon;

	public UIHudBooyahBountyPlayerDetailItem UIHudBooyahBountyDetailItem;

	public UIButton CloseMask;

	public UIWidget DetailGrid;

	public UITable DetailTable;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
