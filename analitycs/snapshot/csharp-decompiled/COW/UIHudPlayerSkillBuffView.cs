using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPlayerSkillBuffView : UIBaseView
{
	public UIGrid Skills;

	public UIGrid Buffs;

	public GameObject SkillBufferGrid;

	public UIGrid GunBuff;

	public Transform PopRoot;

	public UIWidget SkillsMaskContainer;

	public UIWidget BuffsMaskContainer;

	public UIWidget GunMaskContainer;

	public Transform Root;

	public UIWidget LeftGunMaskContainer;

	public GameObject PetLine;

	public GameObject CopyPresetBtnContainer;

	public UIGrid DynamicSkillGrid;

	public UIButton CopyPresetBtn;

	public UITable LeftTableBottom;

	public UITable RightTableTop;

	public UITable RightTableBottom;

	public GameObject LevelSys;

	public GameObject ExpNode;

	public UILabel UISpriteExpLevel;

	public UICustomHoverButton UICustomHoverButtonExpLevel;

	public UIWidget zombieExptutorialWidget;

	public GameObject tips;

	public UILabel levelDescription;

	public UILabel addExp;

	public UISprite UISpriteExpBar;

	public UICustomHoverButton UICustomHoverButtonExpBar;

	public UISprite LevelSysExpBarBG;

	public UILabel LabelExp;

	public UISprite LevelSysExpLevelBg;

	public Transform TableGroup;

	public GameObject EmptySpace;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
