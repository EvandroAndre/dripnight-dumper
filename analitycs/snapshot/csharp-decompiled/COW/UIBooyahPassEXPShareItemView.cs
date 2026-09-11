using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassEXPShareItemView : UIBaseView
{
	public GameObject ProfileInfo;

	public UIButton GetEXPBtn;

	public GameObject SendEXPCon;

	public UILabel LevelBP;

	public UILabel LevelPP;

	public UILabel ShareTimes;

	public GameObject GetExpCon;

	public UIButton SendExpActiveBtn;

	public UIButton SendExpLockBtn;

	public GameObject BG1;

	public GameObject BG2;

	public UIWidget GuideWidget;

	public Animation ClaimVFX;

	public Animation SendVFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
