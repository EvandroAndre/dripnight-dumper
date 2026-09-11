using GCommon;
using UnityEngine;

namespace COW;

public class UIMileStoneNavigationView : UIBaseView
{
	public UIButton ProficiencyInfo;

	public UIButton AchievementInfo;

	public UILabel ProficiencyTitle;

	public UILabel AchievementLevel;

	public UILabel AchievementTitle;

	public UIButton WeaponPicBtn01;

	public UIButton AchievementPicBtn;

	public GameObject AchievementRedPoint;

	public UIButton WeaponPicBtn02;

	public GameObject ProficiencyRedPoint;

	public UISprite ProficiencyIcon;

	public UILabel ProficiencyCount;

	public UISprite AchievementIcon;

	public Transform VFX;

	public Animator CenterAnimator;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
