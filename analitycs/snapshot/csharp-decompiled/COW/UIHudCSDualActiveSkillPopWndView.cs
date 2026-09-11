using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSDualActiveSkillPopWndView : UIBaseView
{
	public GameObject ActiveSkillPos1;

	public GameObject ActiveSkillPos2;

	public UIGrid Grid;

	public UILabel CountDown;

	public GameObject Popover;

	public UILabel PopSkillName;

	public UILabel PopSkillDesc;

	public UIButton PopCloseBtn;

	public UIButton ConfirmBtn;

	public GameObject Enable;

	public GameObject Disable;

	public UILabel TipMessage;

	public GameObject Tip;

	public UILabel SelectedNum;

	public UIScrollView ScrollView;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
