using UnityEngine;
using proto;

namespace COW;

public class SparkPetDisplaySettings : ScriptableObject
{
	public float defaultUIPositionX;

	public float defaultUIPositionY;

	public float defaultUIPosition3DLobbyX;

	public float defaultUIPosition3DLobbyY;

	public float paddingX;

	public float paddingY;

	public float bubbleFlyVfxSpeed;

	public float bubbleFlyVfxArcRatio;

	public float bubbleFlyVfxLingerDuration;

	public float bubbleFlyVfxStartRatio;

	public float luckyDrawWinningVfxDuration;

	public float luckyDrawHighlightVfxDuration;

	public float luckyDrawPrizeScrollSpringStrength;

	public float luckyDrawPrizeScrollMaxDuration;

	public float cameraZDepth;

	public float buddySpacingUISizeX;

	public float tipsHeadOffset;

	public float animLoopInterval;

	public float pressAndHoldDelay;

	public Vector3 shareScreenshotPositionStage1;

	public Vector3 shareScreenshotRotationStage1;

	public Vector3 shareScreenshotScaleStage1;

	public Vector3 shareScreenshotPositionStage2;

	public Vector3 shareScreenshotRotationStage2;

	public Vector3 shareScreenshotScaleStage2;

	public Vector3 shareScreenshotPositionStage3;

	public Vector3 shareScreenshotRotationStage3;

	public Vector3 shareScreenshotScaleStage3;

	public Vector3 selfInitialRotationStage1;

	public Vector3 selfInitialRotationStage2;

	public Vector3 selfInitialRotationStage3;

	public Vector3 buddyInitialRotationStage1;

	public Vector3 buddyInitialRotationStage2;

	public Vector3 buddyInitialRotationStage3;

	public Vector3 selfInitialScaleStage1;

	public Vector3 selfInitialScaleStage2;

	public Vector3 selfInitialScaleStage3;

	public Vector3 buddyInitialScaleStage1;

	public Vector3 buddyInitialScaleStage2;

	public Vector3 buddyInitialScaleStage3;

	public Vector3 appearanceSettingPositionStage1;

	public Vector3 appearanceSettingScaleStage1;

	public Vector3 appearanceSettingPositionStage2;

	public Vector3 appearanceSettingScaleStage2;

	public Vector3 appearanceSettingPositionStage3;

	public Vector3 appearanceSettingScaleStage3;

	public SparkPetStageBoxColliderSettings boxColliderSettingsStage1;

	public SparkPetStageBoxColliderSettings boxColliderSettingsStage2;

	public SparkPetStageBoxColliderSettings boxColliderSettingsStage3;

	public float downloadCtrlOffsetX;

	public float downloadCtrlOffsetY;

	public float downloadCtrlScale;

	public float vfxRecoverOffsetX;

	public float vfxRecoverOffsetY;

	public float profilePanelRightPadding;

	public float profilePanelLeftPadding;

	public float profilePanelTopPadding;

	public float profilePanelBottomPadding;

	public float screenEdgeTopPadding;

	public float screenEdgeBottomPadding;

	public float screenEdgeLeftPadding;

	public float screenEdgeRightPadding;

	public Vector2 GetDefaultUIPosition()
	{
		return default(Vector2);
	}

	public Vector2 GetDefaultUIPosition3DLobby()
	{
		return default(Vector2);
	}

	public Vector3 GetShareScreenshotPositionByStage(uint stage)
	{
		return default(Vector3);
	}

	public Vector3 GetShareScreenshotRotationByStage(uint stage)
	{
		return default(Vector3);
	}

	public Vector3 GetShareScreenshotScaleByStage(uint stage)
	{
		return default(Vector3);
	}

	public Vector3 GetSelfInitialRotationByStage(uint stage)
	{
		return default(Vector3);
	}

	public Vector3 GetBuddyInitialRotationByStage(uint stage)
	{
		return default(Vector3);
	}

	public Vector3 GetSelfInitialScaleByStage(uint stage)
	{
		return default(Vector3);
	}

	public Vector3 GetBuddyInitialScaleByStage(uint stage)
	{
		return default(Vector3);
	}

	public Vector3 GetAppearanceSettingPositionByStage(uint stage)
	{
		return default(Vector3);
	}

	public Vector3 GetAppearanceSettingScaleByStage(uint stage)
	{
		return default(Vector3);
	}

	public SparkPetStageBoxColliderSettings GetBoxColliderSettingsByStage(uint stage)
	{
		return null;
	}

	public Vector3 GetBoxColliderCenter(uint stage, EFriend.SparkState sparkState)
	{
		return default(Vector3);
	}

	public Vector3 GetBoxColliderSize(uint stage, EFriend.SparkState sparkState)
	{
		return default(Vector3);
	}
}
