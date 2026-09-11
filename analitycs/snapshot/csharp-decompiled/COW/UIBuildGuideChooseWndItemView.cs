using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildGuideChooseWndItemView : UIBaseView
{
	public UIToggleButton ToggleBtn;

	public UISprite AvatarIcon_Veteran;

	public GameObject Newbie;

	public GameObject Veteran;

	public UILabel NewbieDescLabel;

	public Transform NewbieSkillPos;

	public UILabel VeteranDescLabel;

	public Transform VeteranSkillPos1;

	public Transform VeteranSkillPos2;

	public Transform VeteranSkillPos3;

	public UILabel AvatarNameLabel;

	public UISprite AvatarIcon_Newbie;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
