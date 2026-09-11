using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarSkillItemView : UIBaseView
{
	public UIButton SkillBtn;

	public UILabel SkillName;

	public UILabel SkillDesc;

	public GameObject SelectSprite;

	public UIPanel AvatarIconPanel;

	public UISprite AvatarIcon;

	public UIPanel OtherContainerPanel;

	public Transform SkillIcon;

	public GameObject EquipInfo;

	public UIButton TipButton;

	public UILabel SkillCd;

	public Transform TipsRight;

	public GameObject MaskBg;

	public GameObject RecommendIcon;

	public GameObject LoveNode;

	public GameObject BGMASK;

	public UIButton BuyBtn;

	public UIButton SharedSkillBtn;

	public UISprite TagSprite;

	public UILabel TagLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
