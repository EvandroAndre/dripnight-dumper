using GCommon;
using UnityEngine;

namespace COW;

public class UIHudReinforcedAnviWeaponInfoView : UIBaseView
{
	public UISprite WeaponIcon;

	public GameObject MuzzleSlotEmptyBG;

	public Transform MuzzleSlot;

	public GameObject ForegripSlotEmptyBG;

	public Transform ForegripSlot;

	public GameObject MagazineSlotEmptyBG;

	public Transform MagazineSlot;

	public Transform SightSlot;

	public GameObject SightSlotEmptyBG;

	public GameObject HighlightGO;

	public Transform GunstockSlot;

	public GameObject GunstockSlotEmptyBG;

	public GameObject GoldSlotEmptyBG;

	public Transform GoldSlot;

	public GameObject GoGradeLv1;

	public GameObject GoGradeLv2;

	public GameObject GoGradeLv3;

	public GameObject BG;

	public GameObject Attachment6;

	public GameObject BgContainer;

	public UISprite WeaponIconSelected;

	public UIButton ReinforceBtn;

	public UILabel TokenTxt;

	public UILabel WeaponName;

	public UIButton UIHudReinforcedAnviWeaponInfo;

	public Animation NameAnim;

	public GameObject ReinforcedBG;

	public UIButton NotEnoughTokenBtn;

	public UILabel TokenTxt2;

	public UILabel EventItemMask;

	public VFXCreateHelper ReinforcedVFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
