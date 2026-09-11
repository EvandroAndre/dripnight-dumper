using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildPetSkillItemView : UIBaseView
{
	public GameObject SkillSlot;

	public UIButton SkillBtn;

	public UILabel SkillName;

	public UILabel SkillDesc;

	public UISprite SkillIcon;

	public UIButton PetIconBtn;

	public UISprite PetIcon;

	public GameObject SelectSprite;

	public GameObject DefaultPetIcon;

	public Transform Main;

	public GameObject SkillEmptyDesc;

	public UISprite SkillNotOwnIcon;

	public GameObject EmptyAddLine;

	public GameObject PetLock;

	public Transform LockTransForm;

	public UIButton Mask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
