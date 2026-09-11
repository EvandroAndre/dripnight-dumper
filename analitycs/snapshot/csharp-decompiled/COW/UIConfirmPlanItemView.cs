using GCommon;
using UnityEngine;

namespace COW;

public class UIConfirmPlanItemView : UIBaseView
{
	public Transform MainSkillPos;

	public Transform EquipSkillPos1;

	public Transform EquipSkillPos2;

	public Transform EquipSkillPos3;

	public UILabel Skill0Property;

	public UIButton SkillTipsBtn0;

	public UIButton SkillTipsBtn1;

	public UIButton PurchaseAvatarBtn0;

	public UIButton PurchaseAvatarBtn1;

	public UIButton SkillTipsBtn2;

	public UIButton PurchaseAvatarBtn2;

	public UIButton SkillTipsBtn3;

	public UIButton PurchaseAvatarBtn3;

	public UISprite PetSkillNotOwnIcon;

	public UISprite PetSkillIcon;

	public UIButton PetTipsBtn;

	public UIButton PetPurchaseBtn;

	public Transform LoadoutPos;

	public UIButton LoadoutTipsBtn;

	public UIButton LoadoutPurchaseBtn;

	public GameObject PetEmpty;

	public GameObject SelectSprite;

	public UIToggleButton BGBtn;

	public UILabel PresetPlanName;

	public UILabel RecPlanName;

	public GameObject NameContainer;

	public GameObject IncompleteMask;

	public GameObject EditPanelBG;

	public UISprite CharacterSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
