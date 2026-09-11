using GCommon;
using UnityEngine;

namespace COW;

public class TeamScoreBoardSkillView : UIBaseView
{
	public UISprite SkillSprite;

	public UIEventListener SkillBtn;

	public UISprite SkillCDProgress;

	public UISprite SkillEffectProgress;

	public GameObject GoCDBg;

	public UIButton EmptyBtn;

	public GameObject PresetPickHideContainer;

	public GameObject NormalViewContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
