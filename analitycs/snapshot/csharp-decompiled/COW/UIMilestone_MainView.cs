using GCommon;
using UnityEngine;

namespace COW;

public class UIMilestone_MainView : UIBaseView
{
	public UINetworkTexture Left_TextureTitle;

	public UIButton Left_RuleBtn;

	public UILabel Left_OpenTimeLabel;

	public UIButton Right_BtnClose;

	public GameObject Right_CloseBtnSprite;

	public UINetworkTexture Right_CloseBtnTexture;

	public UIGrid GridLeftBtns;

	public UISprite Left_OpenTime;

	public Transform RightContainer;

	public Transform CenterContainer;

	public Transform MissionContainer;

	public UIPanel GuidePanel;

	public GameObject TokenContainer;

	public Transform MileageAccGo;

	public UIButton MileageAccBtn;

	public UINetworkTextureExt MileageAccBtnCdn;

	public UILabel MileageAccBtnLabel;

	public Transform MileagePromptGo;

	public UINetworkTextureExt MileagePromptCdn;

	public UILabel MileagePromptLabel;

	public UINetworkTexture TokenConsumeBg;

	public UISprite TokenConsumeIcon;

	public UILabel TokenConsumeCount;

	public GameObject TokenConsumeGo;

	public UINetworkTextureExt StartPointNumIcon;

	public UILabel StartPointGoText;

	public Animation main;

	public Transform FirstInAnimContainer;

	public GameObject MileageAccBtnGo;

	public UILabel AddMileagePromptLabel;

	public GameObject AddMileagePromptGo;

	public MilestoneProgressView Progress1;

	public MilestoneProgressView Progress2;

	public MilestoneProgressView Progress3;

	public MilestoneProgressView Progress4;

	public GrandPrizeProgressView GrandPrize;

	public CycleProgressView CycleProgress;

	public UIButton TutorialBtn;

	public UINetworkTexture TutorialBtnTexture;

	public UINetworkTexture ProgressMask;

	public UINetworkTextureExt MileageAccRedDotCdn;

	public UINetworkTexture Left_RuleBtnTexture;

	public GameObject Left_RuleBtnSprite;

	public UINetworkTexture LeftMask;

	public GameObject MileageAccBtnEffect;

	public GameObject ProgressMaskEffect;

	public GameObject SkipGo;

	public UIButton SkipBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
