using GCommon;
using UnityEngine;

namespace COW;

public class UICheckIsNewbieOrVeteranView : UIBaseView
{
	public Animation AnimSwitch;

	public GameObject WindowContainer;

	public UIButton BtnNewbie;

	public Animation BtnNewbieAni;

	public UIButton BtnVeteran;

	public Animation BtnVeteranAni;

	public UIButton BtnMaster;

	public Animation BtnMasterAni;

	public UIButton BtnConfirm;

	public GameObject GoActiveBtnConfirm;

	public GameObject NewbieSelect;

	public GameObject NewbieUnSelect;

	public GameObject VeteranSelect;

	public GameObject VeteranUnSelect;

	public GameObject MasterSelect;

	public GameObject MasterUnSelect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
