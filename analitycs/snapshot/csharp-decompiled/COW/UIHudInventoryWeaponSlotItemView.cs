using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInventoryWeaponSlotItemView : UIBaseView
{
	public UIInventoryItemDragDropContainer DragDropContainer;

	public UIInventoryItemDrapDrop DragDropItem;

	public UIToggle ItemToggle;

	public GameObject DragGO;

	public UISprite ItemDragIcon;

	public GameObject DeleteMask;

	public GameObject NonDragGO;

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

	public GameObject CombineSprite;

	public GameObject GoGradeLv1;

	public GameObject GoGradeLv2;

	public GameObject GoGradeLv3;

	public UILabel AmmoCount;

	public UILabel WeaponName;

	public GameObject GoldWeaponUpgradeEffect;

	public UIButton UpgradeButton;

	public GameObject RealUpgradeVFX;

	public GameObject GlodSlotCannotUpgradeBg;

	public UIButton BtnCannotUpgrade;

	public GameObject InfiniteSprite;

	public UISprite ActivityBG;

	public GameObject BG;

	public GameObject Attachment101;

	public GameObject Attachment6;

	public UIButton ActivityIconBtn;

	public UISprite ActivityIcon;

	public GameObject BgContainer;

	public GameObject EighthInfiniteBgContainer;

	public GameObject ActivityIconBg;

	public Transform ReinforcedBG;

	public GameObject WeaponMountgrenade;

	public GameObject CustomGradeRoot;

	public UIGrid CustomGradeGride;

	public UISprite CustomGradeOneSprite;

	public UISprite EffectLevelBg;

	public VFXCreateHelper AwakenVFX;

	public GameObject WeaponTerm;

	public UIEventListener WeaponTermEventLisener;

	public UISprite TermIcon;

	public UILabel TermDesc;

	public UIButton AwakenTab;

	public UILabel AwakenLabel;

	public UISprite AwakenIcon;

	public UISprite AwakenTabBG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
