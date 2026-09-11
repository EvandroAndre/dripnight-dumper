using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisLobbyEquipmentView : UIBaseView
{
	public Transform VestSlot;

	public GameObject VestHolderEmptyBG;

	public UIToggle VestToggle;

	public Transform HelmetSlot;

	public GameObject HelmetHolderEmptyBG;

	public UIToggle HelmetToggle;

	public Transform BagSlot;

	public GameObject BagHolderEmptyBG;

	public UIToggle BagToggle;

	public Transform CamouflageSlot;

	public GameObject CamouflageHolderEmptyBG;

	public UIToggle CoverToggle;

	public Transform Prim1WeaponSlot;

	public GameObject P1HolderEmptyBG;

	public UIToggle PrimaryWToggle;

	public Transform MeleeWeaponSlot;

	public GameObject M1HolderEmptyBG;

	public UIToggle MeleeToggle;

	public Transform Prim2WeaponSlot;

	public GameObject P2HolderEmptyBG;

	public UIToggle SecondaryWToggle;

	public Transform SecWeaponSlot;

	public GameObject S1HolderEmptyBG;

	public UIToggle SideWToggle;

	public UIButton MainClickBtn;

	public UILabel EquipmentValueLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
