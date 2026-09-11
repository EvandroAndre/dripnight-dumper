using GCommon;
using UnityEngine;

namespace COW;

public class UIHudChooseSkillPresetItemView : UIBaseView
{
	public UILabel Title;

	public UISprite Skill1Sprite;

	public UILabel Skill1Name;

	public UISprite Skill2Sprite;

	public UILabel Skill2Name;

	public UILabel Skill1Title;

	public UILabel Skill1Desc;

	public UILabel Skill2Title;

	public UILabel Skill2Desc;

	public UIButton SelectBtn;

	public GameObject SelectedMark;

	public UIButton DragArea;

	public GameObject Tag1;

	public GameObject Tag2;

	public UILabel Tag1Label;

	public UILabel Tag2Label;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
