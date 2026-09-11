using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisPlayerInfoView : UIBaseView
{
	public UILabel FactionNameTxt;

	public UIGrid StarGrid;

	public UIHudMetropolisFactionStar FactionStar;

	public GameObject DetailInfoContent;

	public UILabel DetailFactionNameTxt;

	public UIGrid DetailStarGrid;

	public UIHudMetropolisFactionStar DetailFactionStar;

	public UILabel DetailLevelupTxt;

	public UIHudMetropolisSalaryInfo SalaryInfo1;

	public UIHudMetropolisSalaryInfo SalaryInfo2;

	public UIHudMetropolisSalaryInfo SalaryInfo3;

	public UIEventListener DetailInfoBtn;

	public GameObject PoliceBG;

	public GameObject CriminalBG;

	public GameObject CriminalDetailBG;

	public GameObject PoliceDetailBG;

	public UIButton SwitchFactionBtn;

	public UILabel CurScoreTxt;

	public UILabel MaxScoreTxt;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
