using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityOverviewItemView : UIBaseView
{
	public UIButton UIActivityOverviewItem;

	public UIButton LittleGoTo;

	public UILabel BtnTitle;

	public GameObject GoToRedpoint;

	public UILabel Title;

	public UINetworkTexture BGCDN;

	public GameObject FinishState;

	public GameObject ComingState;

	public GameObject NormalState;

	public UIButton GotoBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
