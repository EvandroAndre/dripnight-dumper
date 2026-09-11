using GCommon;
using UnityEngine;

namespace COW;

public class UINewbieRecPresetItemView : UIBaseView
{
	public UILabel LevelLabel;

	public UIButton UseBtn;

	public UIButton GetBtn;

	public GameObject UnLockBtn;

	public Transform MainSkillPos;

	public Transform EquipSkillPos1;

	public Transform EquipSkillPos2;

	public Transform EquipSkillPos3;

	public GameObject AlreadyUseLabel;

	public UISprite CharacterSprite;

	public GameObject TitleBGUnavailable;

	public GameObject TitleBGAvailable;

	public Transform BG;

	public GameObject UIFX_UINewbiePresetRecommendWindow_BG_Glow;

	public GameObject PlanDescTitleLabel;

	public UILabel PlanDescLabel;

	public GameObject UIFX_UINewbiePresetRecommendWindow_Btn_Border;

	public GameObject UIFX_UINewbiePresetRecommendWindow_Btn_Once_Glow;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
