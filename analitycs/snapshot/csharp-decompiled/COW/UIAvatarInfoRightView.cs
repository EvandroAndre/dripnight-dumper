using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarInfoRightView : UIBaseView
{
	public GameObject NameContainer;

	public GameObject SkillContainer;

	public GameObject AwakenInfolContainer;

	public UIButton DetailAvatarStrategyBtn;

	public GameObject SkinColorContainer;

	public UIPanel UIAvatarInfoRight;

	public UILabel AvatarName;

	public Transform LoveNode;

	public Transform AvatarSkillSlot;

	public UITable SkillTagTable;

	public UILabel SkillName;

	public UILabel SkillProperty;

	public UIScrollView DetailSkillDescScrollView;

	public UIPanel DetailSkillDescScrollViewPanel;

	public UIButton AwakenNavigationBtn;

	public UISlider SkinColorSlider;

	public UIEventListener SkinColorSliderListener;

	public UIEventListener Thumb;

	public UISprite ThumbSprite;

	public UISprite colorResult;

	public GameObject HeadIcons;

	public UIButton OriAvatarSwitchBtn;

	public UIButton AwakenAvatarSwitchBtn;

	public GameObject OriIconHL;

	public GameObject OriIconLock;

	public GameObject AwakenIconHL;

	public GameObject AwakenIconLock;

	public UIColor Tag1;

	public UILabel TagLab1;

	public UIColor Tag2;

	public UILabel TagLab2;

	public UIColor Tag3;

	public UILabel TagLab3;

	public UIButton ReplaceBtn;

	public GameObject Selected;

	public UIButton PurchaseBtn;

	public GameObject ExpireTimeBtnGroup;

	public UILabel ExpireTimeLabel;

	public UIButton ReplaceGroupBtn;

	public UIButton ShopBtn;

	public UIButton AvatarProficiencyBtn;

	public UISprite ProgressBar;

	public UILabel LevelLabel;

	public UISprite GiftIcon;

	public UISprite NewIcon;

	public UILabel TokensLabel;

	public GameObject AwakenEntranceTips;

	public UILabel DetailSkillDescLabel;

	public UISprite AwakenHeadIcon;

	public UISprite OriHeadIcon;

	public GameObject PermanentBtnGroup;

	public GameObject ExpireSelected;

	public GameObject SkillName_VFX;

	public GameObject MaxBg;

	public GameObject FreeAvatarContainer;

	public GameObject NormalAvatarContainer;

	public UIButton FreeBtn;

	public UIButton FreeAvatarPurchaseBtn;

	public GameObject ActivityAvatarContainer;

	public UIButton GoposBtn;

	public GameObject AwakenEntranceGiftTips;

	public GameObject EvopassBtnNormal;

	public UIButton EvopassGotoBtnNormal;

	public GameObject EvopassBtn;

	public UIButton EvopassGotoBtn;

	public GameObject OriEquipIcon;

	public GameObject AwakeEquipIcon;

	public GameObject BriefContainer;

	public GameObject DetailContainer;

	public UILabel BriefSkillDescLabel;

	public UIButton BriefSwitchBtn;

	public UIButton DetailSwitchBtn;

	public UIButton BriefAvatarStrategyBtn;

	public Transform HideDetailBtnPos;

	public Transform ShowDetailBtnPos;

	public UIButton DetailSwitchBtn2;

	public UIButton DetailAvatarStrategyBtn2;

	public UIWidget DetailBtnWidget;

	public UILabel DetailSkillDescLabel2;

	public GameObject NotScrollContainer;

	public GameObject ScrollContainer;

	public UIWidget BriefBtnWidget;

	public Transform HideDetailBtnPos2;

	public Transform ShowDetailBtnPos2;

	public GameObject AvatarUGCTutorial;

	public UIButton AvatarUGCTutorialBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
