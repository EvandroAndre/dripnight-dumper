using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityProgressTaskItemTemplateView : UIBaseView
{
	public UILabel Title;

	public UILabel AccumulateLabel;

	public UIDragScrollView DragView;

	public GameObject ItemRoot;

	public UISprite Daily;

	public GameObject main;

	public UITable ButtonTable;

	public UIButton Operation;

	public GameObject GotoBtnBg;

	public GameObject IncompleteBtnBg;

	public GameObject ClaimBtnBg;

	public GameObject GainedBg;

	public UILabel GainedLabel;

	public UILabel OperationTitle;

	public GameObject MissionBg;

	public UINetworkTexture MissionBgCnd;

	public UINetworkTexture GotoBtnCdn;

	public UINetworkTexture ClaimBtnCdn;

	public UINetworkTexture IncompleteBtnCdn;

	public GameObject TimeLockIcon;

	public UILabel TimeCountTitle;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
