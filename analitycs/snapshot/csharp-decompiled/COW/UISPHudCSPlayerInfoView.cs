using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudCSPlayerInfoView : UIBaseView
{
	public GameObject EPNode;

	public UISprite EPBarFG;

	public UILabel Name;

	public UISprite HPBar;

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

	public UILabel SmokeBombCount;

	public UILabel GrenadeCount;

	public UILabel LabelHP;

	public UISprite WeaponIcon;

	public Transform LeftAnchor;

	public UIGrid Skills;

	public UISPHudSkillItemView SkillTemplate;

	public UILabel TokenNum;

	public GameObject Token;

	public Transform GoldEffect;

	public Transform SpriteGoldPlus;

	public Transform SpriteRedPlus;

	public GameObject GoGradeLv1;

	public GameObject GoGradeLv2;

	public GameObject GoGradeLv3;

	public GameObject x;

	public GameObject y;

	public GameObject z;

	public UISPHudSkillItemView CharacterTemplate;

	public VFXCreateHelper VFXPlayerSkillPersonaEPUp;

	public VFXCreateHelper VFXPlayerSkillPersonaEPDown;

	public GameObject Top;

	public GameObject SPNode;

	public GameObject SPItemList;

	public UIHudPlayerSPItem SPItem;

	public UISprite BG;

	public GameObject SecondWeaponContainer;

	public UISprite SecondWeaponIcon;

	public GameObject SecondGoGradeLv1;

	public GameObject SecondGoGradeLv2;

	public GameObject SecondGoGradeLv3;

	public GameObject Secondx;

	public GameObject Secondy;

	public GameObject Secondz;

	public UISprite IceWallEmpty;

	public UISprite GrenadeEmpty;

	public UISprite SmokeBomblEmpty;

	public UISprite MedkitlEmpty;

	public UISprite UseGrenadeItem;

	public GameObject UIFX;

	public UISprite ReinforcedBg;

	public UISprite SecondReinforcedBg;

	public Transform SpriteAwaken;

	public Transform SpriteGold;

	public Transform SpriteRed;

	public GameObject SecondAwakenIcon;

	public GameObject AwakenIcon;

	public UISprite MaxHPChangeBar;

	public UISPHudSkillItemView LoadoutTemplate;

	public UIGrid BuffGrid;

	public UISPHudBuffItemView BuffTemplate;

	public UISprite SpriteCrystal;

	public UISprite SpriteCrystalLevel;

	public UIGrid DeBuffGrid;

	public UIGrid ActiveSkillGrid;

	public GameObject ActiveSkill;

	public UISprite CharacterIcon;

	public UISprite SkillIcon;

	public GameObject CDMask;

	public UISprite TakeEffectProgress;

	public UISprite DisableProgress;

	public UISprite highLightSprite;

	public UISprite CDProgress;

	public GameObject ActiveSkill2;

	public UISprite CharacterIcon2;

	public UISprite SkillIcon2;

	public GameObject CDMask2;

	public UISprite TakeEffectProgress2;

	public UISprite DisableProgress2;

	public UISprite highLightSprite2;

	public UISprite CDProgress2;

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
