using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSTeamGoalBtnView : UIBaseView
{
	public UIGrid SelectResultContainer;

	public GameObject SelectResultTemplate;

	public GameObject LeftGoContainer;

	public UIButton TeamGoalBtn;

	public GameObject RightGoContainer;

	public UIButton LeftTeamGoalBtn;

	public UIButton RightTeamGoalBtn;

	public Animation GoContainer;

	public GameObject TipUIFX;

	public VFXCreateHelper SelectUIFX;

	public GameObject NormalVFX;

	public GameObject AuroraVFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
