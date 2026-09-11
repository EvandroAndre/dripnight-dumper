using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildChoosePetSkillSideItemView : UIBaseView
{
	public UILabel SkillName;

	public UILabel SkillDesc;

	public UIPanel PetIconPanel;

	public UISprite PetIcon;

	public UIButton BuyBtn2;

	public UIButton SkillBtn;

	public UISprite SelectSprite;

	public UIPanel OtherContainerPanel;

	public UILabel SkillCd;

	public GameObject LockPet;

	public GameObject EquipInfo;

	public BaseItemView BaseItemViewPetIcon;

	public Transform SkillIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
