using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisChooseFactionView : UIBaseView
{
	public UIButton ToPoliceBtn;

	public UIButton ToCriminalBtn;

	public UIButton ConfirmBtn;

	public GameObject SelectPoliceBG;

	public UIButton CloseBtn;

	public GameObject SelectCriminalBG;

	public UILabel ConfirmDesc;

	public GameObject PoliceMask;

	public GameObject CriminalMask;

	public GameObject CriminalFullhint;

	public GameObject PoliceFullhint;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
