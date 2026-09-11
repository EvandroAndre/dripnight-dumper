using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildChoosePetSkillSideView : UIBaseView
{
	public UIPanel UIBuildChoosePetSkillSide;

	public UIPanel PetSkillPanel;

	public UIScrollView PetSkillScrollView;

	public UITable2 PetSkillList;

	public UITable2Item EquippedSkill;

	public UITable2Item SkillSplit;

	public UIButton BtnClose;

	public UISprite bg;

	public BoxCollider BGCollider;

	public GameObject RightArrowButton;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
