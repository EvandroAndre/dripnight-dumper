using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLobbySocialAreaDanceRewardView : UIBaseView
{
	public UILabel ProgressLabel;

	public UIButton GoBtn;

	public GameObject UnfinishedState;

	public GameObject FinishedState;

	public GameObject ClaimedState;

	public UILabel UnfinishedBtnLabel;

	public UILabel FinishedBtnLabel;

	public UILabel ClaimedBtnLabel;

	public UINetworkTexture CDN;

	public Transform TitleVFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
