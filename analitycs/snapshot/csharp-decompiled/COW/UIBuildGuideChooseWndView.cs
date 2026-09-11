using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildGuideChooseWndView : UIBaseView
{
	public UILabel DescLabel;

	public Transform NewbiePos1;

	public Transform NewbiePos2;

	public Transform NewbiePos3;

	public UIButton VeteranConfirmBtn;

	public UIToggleButtonGroup VeteranSkillContainer;

	public Transform VeteranPos1;

	public Transform VeteranPos2;

	public Transform VeteranPos3;

	public UILabel TitleLabel;

	public GameObject NewbieSkillContainer;

	public UIButton NewbieConfirmBtn;

	public UICountDownLabel NewbieCountDownLabel;

	public GameObject NewbieEnableSprite;

	public GameObject NewbieDisableSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
