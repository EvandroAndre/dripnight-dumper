using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisMissionView : UIBaseView
{
	public UIButton CloseBtn;

	public UIEasyList ItemList;

	public UIButton PoliceBtn;

	public UIButton CriminalBtn;

	public UIButton PrisonerBtn;

	public UISprite BG;

	public GameObject PoliceNormal;

	public GameObject PoliceDisable;

	public GameObject CriminalNormal;

	public GameObject CriminalDisable;

	public GameObject PrisonerNormal;

	public GameObject PrisonerDisable;

	public UIWidget BonusContent;

	public UILabel BonusTxt;

	public GameObject ItemListScrollView;

	public UIButton CloseMaskBtn;

	public Transform ItemListPosition;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
