using GCommon;
using UnityEngine;

namespace COW;

public class FrontEndPreviewUIConfigData : CSVBaseData
{
	public Vector3 QuickMessagePreviewScale;

	public FrontendPreviewType FrontendPreviewType;

	public UIFrontEndPreviewVehiclePropertyPanelStyle UIFrontEndPreviewVehiclePropertyPanelStyle;

	public EUIAnchor PrivilegeCarouselAnchor;

	public Vector3? PrivilegeCarouselPos;

	public Vector3? WeaponProgressBarPos;

	public Vector3? BundlePreviewTitleScale;

	public Vector3? NormalDownLoadContainerPos;

	public Vector3? AvatarTransformLevelPos;

	public EUIAnchor AvatarTransformLevelAnchor;

	public UIFrontEndPreviewWeaponSkinUpgradeStyle UIFrontEndPreviewWeaponSkinUpgradeStyle;

	public EUIAnchor LaunchTagAnchor;

	public Vector3? EvoAccessContainerPos;

	public EUIAnchor EvoAccessContainerAnchor;

	public Vector3? LaunchTagPos;

	public Vector3? BattleCardViewPos;

	public UIFrontEndPreviewBackpackLevelStyle UIFrontEndPreviewBackpackLevelStyle;

	public Vector3? WeaponChangeSkinPos;

	public Vector3? SpecialBundleLinkPos;

	public EUIAnchor CustomBtnAnchor;

	public Vector3? CustomBtnPos;

	public Vector3? TrialBtnPos;

	public UIFrontEndPreviewHairStyleLevelStyle UIFrontEndPreviewHairStyleLevelStyle;

	public EUIAnchor TrialBtnAnchor;

	public UIFrontEndPreviewHotfixDownloadStyle UIFrontEndPreviewHotfixDownloadStyle;

	public UIFrontEndPreviewController.ProbabilityStyleType ProbabilityStyleType;

	public UIFrontEndPreviewWeaponPropertyPanelStyle UIFrontEndPreviewWeaponPropertyPanelStyle;

	public Vector3? BooyahPassPreviewPos;

	public UIFrontEndPreviewController.SkillTipsType SkillTipsType;

	public Vector3? SkillInfoPos;

	public EUIAnchor SkillInfoAnchor;

	public Vector3? ItemDescPos;

	public EUIAnchor ItemDescAnchor;

	public Vector3? BundlePreviewTitlePos;

	public EUIAnchor BundlePreviewTitleAnchor;

	public Vector3? BackPackLevelPos;

	public EUIAnchor BackPackLevelAnchor;

	public Vector3? BackPackLevelRightPos;

	public EUIAnchor BackPackLevelRightAnchor;

	public Vector3? PropertyIconTablePos;

	public Vector3? PropertyContainerPos;

	public EUIAnchor PropertyContainerAnchor;

	public Vector3? HairStyleLevelPos;

	public EUIAnchor HairStyleLevelAnchor;

	public Vector3? NotificationContainerPos;

	public Vector2? SpecialItemCdnSIze;

	public Vector3? SpecialItemCdnPos;

	public EUIAnchor QuickMessageLinkAnchor;

	public Vector3? QuickMessageViewPos;

	public Vector3? SkillEffectChangeBtnPos;

	public EUIAnchor NotificationContainerAnchor;

	public Vector3? QuickMessageLinkPos;

	public Vector3? WeaponSkinUpgradeLevelPos;

	public EUIAnchor WeaponSkinUpgradeLevelAnchor;

	public Vector2? UIQualityWidgetSize;

	public Vector3? WeaponSkinUpgradeLevelRightPos;

	public ResDownloadType DownloadAllType;

	public EUIAnchor WeaponSkinUpgradeLevelRightAnchor;

	public Vector3? VirtualBrandLinkPos;

	public Vector3? IconGridPos;

	public EUIAnchor IconGridAnchor;

	public Vector4? UIBundleScrollViewRegion;

	public Vector3? HairStyleLevelRightPos;

	public Vector3? UIHeadPicViewPos;

	public EUIAnchor HairStyleLevelRightAnchor;

	public Vector3? UIItemViewIconPos;

	public Vector3? TailorClothUpgradeLevelPos;

	public EUIAnchor TailorClothUpgradeLevelAnchor;

	public Vector3? UIBannerViewPos;

	public EUIAnchor VirtualBrandLinkAnchor;

	public UIFrontEndPreviewDetailSkillInfoPanelStyle UIFrontEndPreviewDetailSkillInfoPanelStyle;

	public UIFrontEndPreviewWeaponPropertyItemStyle UIFrontEndPreviewWeaponPropertyItemStyle;

	public Vector3? AvatarDownloadContainerPos;

	public UIFrontEndPreviewItemDescBaseStyle UIFrontEndPreviewItemDescStyle;

	public UIFrontEndPreviewBundlePreviewStyle UIFrontEndPreviewBundlePreviewStyle;

	public uint WeaponChangeSkinAnchor;

	public float Preview2DItemScale;

	public uint BrandLinkCheckCondition;

	public bool NeedShowPrivilegeCarousel;

	public bool NeedAdjustPropertyContainer;

	public bool NeedLogMagnifierClick;

	public bool NeedShowIPCollab;

	public bool FistNeedShowWeaponProgressBar;

	public bool NeedEfeectIconChangeGrid;

	public bool NeedMagnifierFacial;

	public bool NeedAvatarTransformLevel;

	public bool NeedZoomBtn;

	public bool NeedBagPackPreviewSwitch;

	public bool NeedWeaponSwitchBtn;

	public bool NeedLaunchTag;

	public bool NeedChangeBattleCardUIState;

	public bool NeedZoomWithCameraBtn;

	public bool NeedBackpackLevel;

	public bool NeedPlayBtn;

	public bool NeedShowHairStyleIcon;

	public bool NeedSpecialBundleLink;

	public bool NeedShowEpicClothStyle;

	public bool ShowWeaponPrivilegeAfterCgShow;

	public bool NeedWeaponChangeSkin;

	public bool NeedCustomBtn;

	public bool NeedTrialBtn;

	public bool OnlyShowItemDescWithPrivilegeIcon;

	public bool NeedCloseBundleItemOwnState;

	public bool NeedShowPrivilegeShowContainer;

	public bool NeedOptionalDownloadRefresh;

	public bool NeedEffectIcon;

	public bool NeedShowDownloadAllBtn;

	public bool NeedDisplayTailorClothUI;

	public bool NeedVirtualBrandLink;

	public bool NeedVerticalPreviewBtn;

	public bool UIItemDescShow;

	public bool NeedSexIcon;

	public bool NeedAdjustPropertySkillInfoPanel;

	public bool NeedAvatarProfileLink;

	public bool NeedWishListBtn;

	public bool NeedShowHyperBook;

	public bool NeedShowTokenExchangeBtn;

	public bool NeedWishValue;

	public bool PreviewRefreshWithoutDownloadUI;

	public bool NeedOnlyShowClothesInBundle;

	public bool NeedEvoAccess;

	public bool NeedShowSkillEffectChangeBtn;

	public bool NeedShowWeaponSkinUpgradeLevel;

	public bool NeedPrivilegeEffectBtn;

	public bool NeedMagnifierBtn;

	public UIFrontEndPreviewPveWeaponPropertyStyle UIFrontEndPreviewPveWeaponPropertyStyle;

	public UIFrontEndPreviewTailorClothUpgradeStyle UIFrontEndPreviewTailorClothUpgradeStyle;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public Vector2? TransStringToVector2(string str)
	{
		return null;
	}

	public Vector2? TransStringToVector2(string head, string[] headers, string[] values)
	{
		return null;
	}

	public Vector3? TransStringToVector3(string str)
	{
		return null;
	}

	public Vector3? TransStringToVector3(string head, string[] headers, string[] values)
	{
		return null;
	}

	public Vector4? TransStringToVector4(string str)
	{
		return null;
	}

	public Vector4? TransStringToVector4(string head, string[] headers, string[] values)
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
