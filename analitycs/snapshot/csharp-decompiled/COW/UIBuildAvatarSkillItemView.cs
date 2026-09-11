using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildAvatarSkillItemView : UIBaseView
{
	public Transform SkillSlotPosition;

	public UIButton SkillDescBtn;

	public UIWidget SkillDescBtnWidget;

	public UILabel SkillNameLabel;

	public UILabel SkillDescLabel;

	public UIButton AvatarBtn;

	public GameObject DefaultAvatarIcon;

	public UISprite AvatarIcon;

	public GameObject SharedSkillSprite;

	public Transform Placeholder;

	public UIWidget PlaceholderWidget;

	public GameObject SelectSprite;

	public UILabel SkillActiveLabel;

	public GameObject SkillEmptyLabel;

	public GameObject DescContainer;

	public UIWidget VolumelessContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
