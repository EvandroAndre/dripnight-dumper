using GCommon;
using UnityEngine;

namespace COW;

public class UIHudIIVGPCursedEnergyMainView : UIBaseView
{
	public GameObject DetailInfo;

	public UISprite Icon;

	public UILabel Name;

	public UILabel Desc;

	public UIHudIIVGPCursedEnergyMainItem Item1;

	public UIButton BtnClose;

	public UIButton BtnCloseMask;

	public UIHudIIVGPCursedEnergyMainItem Item2;

	public UIHudIIVGPCursedEnergyMainItem Item4;

	public UIHudIIVGPCursedEnergyMainItem Item3;

	public UIHudIIVGPCursedEnergyMainItem Item5;

	public UIHudIIVGPCursedEnergyMainItem Item6;

	public UIButton BtnBg;

	public UISprite BG;

	public GameObject LockSkill;

	public UILabel CostProgress;

	public Transform UnlockRoot;

	public UILabel RemainProgress;

	public Transform NormalRoot;

	public GameObject CabinTips;

	public UILabel TipLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
