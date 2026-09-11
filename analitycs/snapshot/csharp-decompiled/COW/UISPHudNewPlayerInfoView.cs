using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudNewPlayerInfoView : UIBaseView
{
	public GameObject EPNode;

	public UISprite EPBarFG;

	public UILabel LabelHP;

	public UISprite HPBarFG;

	public UILabel Name;

	public UISprite SpriteHelmet;

	public UISprite FilledHelmet;

	public UISprite FilledHelmetEnhanced;

	public UISprite SpriteHelmetLevel;

	public UISprite SpriteArmor;

	public UISprite Filled;

	public UISprite FilledEnhanced;

	public UISprite SpriteArmorLevel;

	public UILabel MedkitCount;

	public UILabel IceWallCount;

	public UISprite ItemIcon;

	public UILabel ItemCount;

	public UILabel Kill;

	public UISprite WeaponIcon;

	public Transform LeftAnchor;

	public UIGrid Skills;

	public UISPHudSkillItemView SkillTemplate;

	public UILabel Nation;

	public UISprite NationBg;

	public UISPHudCustomHud CustomNationBg;

	public UILabel TokenNum;

	public GameObject ActiveSkill;

	public UISprite SkillIcon;

	public UISprite CDProgress;

	public GameObject Token;

	public GameObject CDMask;

	public UISprite TakeEffectProgress;

	public UISprite DisableProgress;

	public UISprite highLightSprite;

	public Transform FsHypeNode;

	public Transform GoldEffect;

	public Transform SpriteGoldPlus;

	public Transform SpriteRedPlus;

	public GameObject GoGradeLv1;

	public GameObject GoGradeLv2;

	public GameObject GoGradeLv3;

	public GameObject x;

	public GameObject y;

	public GameObject z;

	public UISprite CharacterIcon;

	public UISPHudSkillItemView CharacterTemplate;

	public VFXCreateHelper VFXPlayerSkillPersonaEPUp;

	public VFXCreateHelper VFXPlayerSkillPersonaEPDown;

	public GameObject SPNode;

	public GameObject SPItemList;

	public UIHudPlayerSPItem SPItem;

	public UISprite MiddleContainerBG;

	public GameObject Top;

	public UISprite iceWallIcon;

	public UISprite spriteMedkit;

	public GameObject ActiveSkill2;

	public UISprite CharacterIcon2;

	public UISprite SkillIcon2;

	public GameObject CDMask2;

	public UISprite TakeEffectProgress2;

	public UISprite DisableProgress2;

	public UISprite highLightSprite2;

	public UISprite CDProgress2;

	public GameObject TechDeviceSlot;

	public UISprite TechDeviceSlotIcon;

	public UIGrid ActiveSkillGrid;

	public GameObject HelmetArmorBG;

	public UITexture CustomHelmetArmorBG;

	public GameObject WeaponBG;

	public UITexture CustomWeaponBG;

	public GameObject MedKitBG;

	public UITexture CustomMedKitBG;

	public GameObject ItemBG;

	public UITexture CustomItemBG;

	public GameObject IceWallBG;

	public UITexture CustomIceWallBG;

	public UILabel killtitle;

	public UISprite NameBG;

	public GameObject RoleNode;

	public UISprite RoleIcon;

	public UILabel RoleName;

	public UISprite RoleBG;

	public UISPHudCustomHud CustomRoleBG;

	public GameObject MiddleContainer;

	public GameObject RightContainer;

	public UISprite ReinfrocedBG;

	public GameObject AwakenIcon;

	public Transform SpriteAwaken;

	public Transform SpriteGold;

	public Transform SpriteRed;

	public UISPHudSkillItemView LoadoutTemplate;

	public UIGrid BuffGrid;

	public UISPHudBuffItemView BuffTemplate;

	public Transform UpgradeGemGetPos;

	public GameObject Crystal;

	public UISprite SpriteCrystalLevel;

	public UIGrid DeBuffGrid;

	public UILabel ActiveSkillAvailableLabel;

	public UILabel ActiveSkillAvailableLabel2;

	public GameObject Unusable;

	public GameObject Unusable2;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
