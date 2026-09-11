using GCommon;
using UnityEngine;

namespace COW;

public class UIHud_QTE_UnFreezeView : UIBaseView
{
	public GameObject ParticleRoot;

	public Animation UIFX_PVE_Ice;

	public Animation UIFX_PVE_flaw;

	public Animation UIFX_PVE_broken;

	public UIButton LeftBtn;

	public UIButton RightBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
