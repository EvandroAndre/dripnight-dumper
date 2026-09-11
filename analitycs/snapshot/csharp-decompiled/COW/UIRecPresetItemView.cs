using GCommon;
using UnityEngine;

namespace COW;

public class UIRecPresetItemView : UIBaseView
{
	public Transform PosSlot0;

	public UIButton SkillTipsBtn0;

	public UISprite CharacterSprite;

	public UIButton PurchaseAvatarBtn0;

	public Transform PosSlot1;

	public UIButton PurchaseAvatarBtn1;

	public UIButton SkillTipsBtn1;

	public UIButton PurchaseAvatarBtn2;

	public UIButton SkillTipsBtn2;

	public Transform PosSlot3;

	public Transform PosSlot2;

	public UIButton SkillTipsBtn3;

	public UIButton PurchaseAvatarBtn3;

	public Transform PetSkillPos;

	public UIButton PetTipsBtn;

	public UIButton PetPurchaseBtn;

	public Transform LoadoutPos;

	public UIButton LoadoutTipsBtn;

	public UIButton LoadoutPurchaseBtn;

	public UILabel PlanDescTitleLabel;

	public UILabel PlanDescLabel;

	public UITable TagsTable;

	public UIAnchor TagsTableAnchor;

	public UIButton DisApplyBtn;

	public UIButton ApplyBtn;

	public Transform MainSkillPos;

	public Transform EquipSkillPos1;

	public Transform EquipSkillPos2;

	public Transform EquipSkillPos3;

	public UISprite PetSkillNotOwnIcon;

	public UISprite PetSkillIcon;

	public UILabel Skill0Property;

	public GameObject PlayerInfo;

	public UISprite PlayerAvartarSprite;

	public UILabel PlayerNameLabel;

	public UIButton DetailInfoBtn;

	public UIButton PlayerInfoBtn;

	public UILabel RoleLabel;

	public UISprite RoleIcon;

	public GameObject LikedIcon;

	public UIButton NoLikeIcon;

	public GameObject LikeFX;

	public UILabel LikeLabel;

	public UINetworkTexture PlayerAvartarIcon;

	public UISprite FakeSprite;

	public UISprite VTag;

	public GameObject RecommendTag;

	public GameObject LikeButtonContainer;

	public GameObject OfficialRecTab;

	public GameObject NewRoleTab;

	public Animation TagsAnimation;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
