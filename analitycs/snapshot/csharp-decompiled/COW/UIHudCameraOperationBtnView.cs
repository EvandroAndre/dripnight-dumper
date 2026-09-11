using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCameraOperationBtnView : UIBaseView
{
	public GameObject MainPhotoSprite;

	public UILabel RecordTimeLabel;

	public UIButton SideBtn;

	public UIButton ScrollContainer;

	public GameObject NormalStateContainer;

	public UIPanel NormalStateContainerPanel;

	public GameObject ActiveStateContainer;

	public UILabel LittleFocalLengthLabel;

	public UILabel BigFocalLengthLabel;

	public Transform BigScrollSprite;

	public TweenAlpha TweenAlphaIn;

	public UIWidget TweenInWidget;

	public GameObject MainVedioGameObject;

	public GameObject SidePhotoSprite;

	public GameObject SideVedioSprite;

	public GameObject MainVideoRECGameObject;

	public GameObject SeasonReplayBubble;

	public UIPanel UIHudCameraOperationBtn;

	public TweenAlpha TweenAlphaOut;

	public UIWidget TweenOutWidget;

	public UIButton MainBtn;

	public Transform PortraitSideBtnContianer;

	public Transform LandScapeSideBtnContainer;

	public UIWidget Widget;

	public Transform LandScapeVideoRECContainer;

	public Transform PortraitVideoRECContianer;

	public UIButton RotationScrollContainer;

	public GameObject RotationNormalStateContainer;

	public UIPanel RotationNormalStateContainerPanel;

	public GameObject RotationActiveStateContainer;

	public UILabel BigRotationAngleLabel;

	public UILabel LittleRotationAngleLabel;

	public Transform BigRotationAngleScrollSprite;

	public TweenAlpha RotationTweenAlphaIn;

	public UIWidget RotationTweenInWidget;

	public TweenAlpha RotationTweenAlphaOut;

	public UIWidget RotationTweenOutWidget;

	public UILabel CameraHeightLabel;

	public UICameraModeHeightAdjustSlider HeightSlider;

	public GameObject CameraHeightHeightSlider;

	public UIPanel CameraHeightHeightSliderPanel;

	public UIWidget CameraHeightHeightSliderGuideWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
