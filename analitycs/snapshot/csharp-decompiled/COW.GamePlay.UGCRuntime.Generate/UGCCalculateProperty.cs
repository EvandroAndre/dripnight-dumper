using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime.Generate;

public class UGCCalculateProperty
{
	public static int GetAppearanceRepItemDiffuseAlpha(UGCLogicEntity appearance, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static int GetAppearanceRepItemRimAlpha(UGCLogicEntity appearance, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool SetAppearanceRepItemDiffuseAlpha(UGCLogicEntity appearance, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetAppearanceRepItemRimAlpha(UGCLogicEntity appearance, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static IUGCValue PropGetterNoGC(UGCLogicEntity entity, long index, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static bool PropSetterNoGC(UGCLogicEntity entity, long index, UGCSimpleValue value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static int GetCameraConfigRepItemCameraType(UGCLogicEntity cameraConfig, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static List<object> GetCameraConfigRepItemUseEntities(UGCLogicEntity cameraConfig, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static bool SetCameraConfigRepItemCameraType(UGCLogicEntity cameraConfig, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static int GetEffectEntityRepItemDiffuseAlpha(UGCLogicEntity effectEntity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool SetEffectEntityRepItemDiffuseAlpha(UGCLogicEntity effectEntity, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetEntityRepItemActiveParent(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetEntityRepItemActiveInHierarchy(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetFactionRepItemIsACE(UGCLogicEntity faction, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static List<object> GetFactionRepItemAllPlayers(UGCLogicEntity faction, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static List<object> GetFactionRepItemFriendlyFactions(UGCLogicEntity faction, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static List<object> GetFactionRepItemHostileFactions(UGCLogicEntity faction, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static List<object> GetFactionRepItemAllMembers(UGCLogicEntity faction, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static int GetFootballGoalRepItemTeamSeq(UGCLogicEntity footballGoal, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static string GetHudProfileInfoRepItemAccountID(UGCLogicEntity hudProfileInfo, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static bool SetHudProfileInfoRepItemAccountID(UGCLogicEntity hudProfileInfo, string value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetHudScrollViewRepItemVerticalScrollAmount(UGCLogicEntity hudScrollView, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static float GetHudScrollViewRepItemHorizontalScrollAmount(UGCLogicEntity hudScrollView, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetHudScrollViewRepItemVerticalScrollAmount(UGCLogicEntity hudScrollView, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetHudScrollViewRepItemHorizontalScrollAmount(UGCLogicEntity hudScrollView, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static int GetHudWidgetRepItemWidth(UGCLogicEntity hudWidget, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static int GetHudWidgetRepItemHeight(UGCLogicEntity hudWidget, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static Vector3 GetHudWidgetRepItemActualPosition(UGCLogicEntity hudWidget, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static Vector2 GetHudWidgetRepItemSize(UGCLogicEntity hudWidget, UGCRuntime ugcRuntime)
	{
		return default(Vector2);
	}

	public static bool SetHudWidgetRepItemWidth(UGCLogicEntity hudWidget, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetHudWidgetRepItemHeight(UGCLogicEntity hudWidget, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetHudWidgetRepItemActualPosition(UGCLogicEntity hudWidget, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetHudWidgetRepItemSize(UGCLogicEntity hudWidget, Vector2 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetRepItemActiveParentOverrideEntity(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetRepItemActiveInHierarchyOverrideEntity(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemPositionOverrideTransform(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static bool SetRepItemPositionOverrideTransform(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemRotationOverrideTransform(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static bool SetRepItemRotationOverrideTransform(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemScaleOverrideTransform(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static bool SetRepItemScaleOverrideTransform(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static object GetRepItemParentOverrideTransform(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static bool SetRepItemParentOverrideTransform(UGCLogicEntity entity, UGCLogicEntity value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Quaternion GetRepItemRotationQOverrideTransform(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Quaternion);
	}

	public static bool SetRepItemRotationQOverrideTransform(UGCLogicEntity entity, Quaternion value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemLocalPositionOverrideTransform(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static bool SetRepItemLocalPositionOverrideTransform(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Quaternion GetRepItemLocalRotationQOverrideTransform(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Quaternion);
	}

	public static bool SetRepItemLocalRotationQOverrideTransform(UGCLogicEntity entity, Quaternion value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemLocalRotationOverrideTransform(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static bool SetRepItemLocalRotationOverrideTransform(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemLocalScaleOverrideTransform(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static bool SetRepItemLocalScaleOverrideTransform(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemUpOverrideTransform(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static bool SetRepItemUpOverrideTransform(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemRightOverrideTransform(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static bool SetRepItemRightOverrideTransform(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemForwardOverrideTransform(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static bool SetRepItemForwardOverrideTransform(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static int GetRepItemDiffuseAlphaOverrideAppearance(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool SetRepItemDiffuseAlphaOverrideAppearance(UGCLogicEntity entity, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static int GetRepItemRimAlphaOverrideAppearance(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool SetRepItemRimAlphaOverrideAppearance(UGCLogicEntity entity, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static int GetRepItemTypeOverrideRigidbody(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool SetRepItemTypeOverrideRigidbody(UGCLogicEntity entity, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetRepItemUseGravityOverrideRigidbody(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetRepItemUseGravityOverrideRigidbody(UGCLogicEntity entity, bool value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetRepItemMassOverrideRigidbody(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemMassOverrideRigidbody(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemCenterOfMassOverrideRigidbody(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static Vector3 GetRepItemVelocityOverrideRigidbody(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static bool SetRepItemVelocityOverrideRigidbody(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemAngularVelocityOverrideRigidbody(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static bool SetRepItemAngularVelocityOverrideRigidbody(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetRepItemDragOverrideRigidbody(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemDragOverrideRigidbody(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetRepItemAngularDragOverrideRigidbody(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemAngularDragOverrideRigidbody(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static int GetRepItemConstrainOverrideRigidbody(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool SetRepItemConstrainOverrideRigidbody(UGCLogicEntity entity, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetRepItemUsePhysicalCCTOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetRepItemUsePhysicalCCTOverridePhysicalCCT(UGCLogicEntity entity, bool value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetRepItemSlopeLimitOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemSlopeLimitOverridePhysicalCCT(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetRepItemStepOffsetOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemStepOffsetOverridePhysicalCCT(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetRepItemSkinWidthOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemSkinWidthOverridePhysicalCCT(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetRepItemMinMoveDistanceOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemMinMoveDistanceOverridePhysicalCCT(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemCenterOffsetOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static float GetRepItemRadiusOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemRadiusOverridePhysicalCCT(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetRepItemHeightOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemHeightOverridePhysicalCCT(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemVelocityOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static float GetRepItemMaxSpeedOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemMaxSpeedOverridePhysicalCCT(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemGravityOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static bool SetRepItemGravityOverridePhysicalCCT(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetRepItemMassOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemMassOverridePhysicalCCT(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetRepItemIsSlidingOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetRepItemIsTopCollidingOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetRepItemIsSideCollidingOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetRepItemIsBottomCollidingOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetRepItemIsServerDrivenOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetRepItemIsServerDrivenOverridePhysicalCCT(UGCLogicEntity entity, bool value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetRepItemUseCustomPushForceOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetRepItemUseCustomPushForceOverridePhysicalCCT(UGCLogicEntity entity, bool value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetRepItemCustomPushForceOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemCustomPushForceOverridePhysicalCCT(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetRepItemIsGroundedOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetRepItemEnableRotateWithGravityOverridePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetRepItemJumpHeightOverridePlayerCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemJumpHeightOverridePlayerCCT(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static int GetRepItemMaxJumpCountOverridePlayerCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool SetRepItemMaxJumpCountOverridePlayerCCT(UGCLogicEntity entity, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static int GetRepItemRemainJumpCountOverridePlayerCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool GetRepItemCanMoveInAirOverridePlayerCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetRepItemCanMoveInAirOverridePlayerCCT(UGCLogicEntity entity, bool value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static List<object> GetRepItemAllItemGoodsTypeOverridePlayerBag(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static List<object> GetRepItemHostileTeamsOverrideTeam(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static List<object> GetRepItemFriendlyTeamsOverrideTeam(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static int GetRepItemTeamSeqOverrideTeam(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static List<object> GetRepItemHostilePlayersOverridePlayer(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static List<object> GetRepItemFriendlyPlayersOverridePlayer(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static int GetRepItemDiffuseAlphaOverridePresentEffect(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool SetRepItemDiffuseAlphaOverridePresentEffect(UGCLogicEntity entity, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static int GetRepItemWidthOverrideHudWidget(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool SetRepItemWidthOverrideHudWidget(UGCLogicEntity entity, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static int GetRepItemHeightOverrideHudWidget(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool SetRepItemHeightOverrideHudWidget(UGCLogicEntity entity, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemActualPositionOverrideHudWidget(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static bool SetRepItemActualPositionOverrideHudWidget(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector2 GetRepItemSizeOverrideHudWidget(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector2);
	}

	public static bool SetRepItemSizeOverrideHudWidget(UGCLogicEntity entity, Vector2 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static string GetRepItemAccountIDOverrideHudProfileInfo(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static bool SetRepItemAccountIDOverrideHudProfileInfo(UGCLogicEntity entity, string value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetRepItemVerticalScrollAmountOverrideHudScrollView(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemVerticalScrollAmountOverrideHudScrollView(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetRepItemHorizontalScrollAmountOverrideHudScrollView(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool SetRepItemHorizontalScrollAmountOverrideHudScrollView(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static int GetRepItemTeamSeqOverrideSpawnBox(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static int GetRepItemTeamSeqOverrideFootballGoal(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool GetRepItemIsACEOverrideFaction(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static List<object> GetRepItemAllPlayersOverrideFaction(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static List<object> GetRepItemFriendlyFactionsOverrideFaction(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static List<object> GetRepItemHostileFactionsOverrideFaction(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static List<object> GetRepItemAllMembersOverrideFaction(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static int GetRepItemCameraTypeOverrideCameraConfig(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool SetRepItemCameraTypeOverrideCameraConfig(UGCLogicEntity entity, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static List<object> GetRepItemUseEntitiesOverrideCameraConfig(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static object GetRepItemStartValueOverrideTween(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static bool SetRepItemStartValueOverrideTween(UGCLogicEntity entity, object value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static object GetRepItemEndValueOverrideTween(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static bool SetRepItemEndValueOverrideTween(UGCLogicEntity entity, object value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static object GetRepItemDeltaValueOverridePlayableSelfRelative(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static bool SetRepItemDeltaValueOverridePlayableSelfRelative(UGCLogicEntity entity, object value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static object GetRepItemDeltaValueOverridePlayableRelativeFrame(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static bool SetRepItemDeltaValueOverridePlayableRelativeFrame(UGCLogicEntity entity, object value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static int GetRepItemDiffuseAlphaOverrideEffectEntity(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool SetRepItemDiffuseAlphaOverrideEffectEntity(UGCLogicEntity entity, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetRepItemBonePositionOverrideSkeletonPart(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static Vector3 GetRepItemBoneRotationOverrideSkeletonPart(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static int GetRepItemPlayedTimeOverrideSoundEntity(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool GetPhysicalCCTRepItemUsePhysicalCCT(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetPhysicalCCTRepItemSlopeLimit(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static float GetPhysicalCCTRepItemStepOffset(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static float GetPhysicalCCTRepItemSkinWidth(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static float GetPhysicalCCTRepItemMinMoveDistance(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static Vector3 GetPhysicalCCTRepItemCenterOffset(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static float GetPhysicalCCTRepItemRadius(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static float GetPhysicalCCTRepItemHeight(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static Vector3 GetPhysicalCCTRepItemVelocity(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static float GetPhysicalCCTRepItemMaxSpeed(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static Vector3 GetPhysicalCCTRepItemGravity(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static float GetPhysicalCCTRepItemMass(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool GetPhysicalCCTRepItemIsSliding(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetPhysicalCCTRepItemIsTopColliding(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetPhysicalCCTRepItemIsSideColliding(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetPhysicalCCTRepItemIsBottomColliding(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetPhysicalCCTRepItemIsServerDriven(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetPhysicalCCTRepItemUseCustomPushForce(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetPhysicalCCTRepItemCustomPushForce(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static bool GetPhysicalCCTRepItemIsGrounded(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool GetPhysicalCCTRepItemEnableRotateWithGravity(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPhysicalCCTRepItemUsePhysicalCCT(UGCLogicEntity entity, bool value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPhysicalCCTRepItemSlopeLimit(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPhysicalCCTRepItemStepOffset(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPhysicalCCTRepItemSkinWidth(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPhysicalCCTRepItemMinMoveDistance(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPhysicalCCTRepItemRadius(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPhysicalCCTRepItemHeight(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPhysicalCCTRepItemMaxSpeed(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPhysicalCCTRepItemGravity(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPhysicalCCTRepItemMass(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPhysicalCCTRepItemIsServerDriven(UGCLogicEntity entity, bool value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPhysicalCCTRepItemUseCustomPushForce(UGCLogicEntity entity, bool value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPhysicalCCTRepItemCustomPushForce(UGCLogicEntity entity, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static object GetPlayableRelativeFrameRepItemDeltaValue(UGCLogicEntity playableRelativeFrame, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static bool SetPlayableRelativeFrameRepItemDeltaValue(UGCLogicEntity playableRelativeFrame, object value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static object GetPlayableSelfRelativeRepItemDeltaValue(UGCLogicEntity playableSelfRelative, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static bool SetPlayableSelfRelativeRepItemDeltaValue(UGCLogicEntity playableSelfRelative, object value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static List<object> GetPlayerBagRepItemAllItemGoodsType(UGCLogicEntity playerBag, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static float GetPlayerCCTRepItemJumpHeight(UGCLogicEntity playerCCT, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static int GetPlayerCCTRepItemMaxJumpCount(UGCLogicEntity playerCCT, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static int GetPlayerCCTRepItemRemainJumpCount(UGCLogicEntity playerCCT, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool GetPlayerCCTRepItemCanMoveInAir(UGCLogicEntity playerCCT, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPlayerCCTRepItemJumpHeight(UGCLogicEntity playerCCT, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPlayerCCTRepItemMaxJumpCount(UGCLogicEntity playerCCT, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetPlayerCCTRepItemCanMoveInAir(UGCLogicEntity playerCCT, bool value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static List<object> GetPlayerRepItemHostilePlayers(UGCLogicEntity player, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static List<object> GetPlayerRepItemFriendlyPlayers(UGCLogicEntity player, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static int GetPresentEffectRepItemDiffuseAlpha(UGCLogicEntity presentEffect, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool SetPresentEffectRepItemDiffuseAlpha(UGCLogicEntity presentEffect, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static int GetRigidbodyRepItemType(UGCLogicEntity rigidbody, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool GetRigidbodyRepItemUseGravity(UGCLogicEntity rigidbody, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static float GetRigidbodyRepItemMass(UGCLogicEntity rigidbody, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static Vector3 GetRigidbodyRepItemCenterOfMass(UGCLogicEntity rigidbody, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static Vector3 GetRigidbodyRepItemVelocity(UGCLogicEntity rigidbody, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static Vector3 GetRigidbodyRepItemAngularVelocity(UGCLogicEntity rigidbody, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static float GetRigidbodyRepItemDrag(UGCLogicEntity rigidbody, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static float GetRigidbodyRepItemAngularDrag(UGCLogicEntity rigidbody, UGCRuntime ugcRuntime)
	{
		return 0f;
	}

	public static int GetRigidbodyRepItemConstrain(UGCLogicEntity rigidbody, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static bool SetRigidbodyRepItemType(UGCLogicEntity rigidbody, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetRigidbodyRepItemUseGravity(UGCLogicEntity rigidbody, bool value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetRigidbodyRepItemMass(UGCLogicEntity rigidbody, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetRigidbodyRepItemVelocity(UGCLogicEntity rigidbody, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetRigidbodyRepItemAngularVelocity(UGCLogicEntity rigidbody, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetRigidbodyRepItemDrag(UGCLogicEntity rigidbody, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetRigidbodyRepItemAngularDrag(UGCLogicEntity rigidbody, float value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetRigidbodyRepItemConstrain(UGCLogicEntity rigidbody, int value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static Vector3 GetSkeletonPartRepItemBonePosition(UGCLogicEntity skeletonPart, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static Vector3 GetSkeletonPartRepItemBoneRotation(UGCLogicEntity skeletonPart, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static UGCLogicEntity GetSkeletonPartLookAtControllerRepItemLookAt(UGCLogicEntity skeletonPartLookAtController, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static int GetSoundEntityRepItemPlayedTime(UGCLogicEntity soundEntity, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static int GetSpawnBoxRepItemTeamSeq(UGCLogicEntity spawnBox, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static List<object> GetTeamRepItemHostileTeams(UGCLogicEntity team, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static List<object> GetTeamRepItemFriendlyTeams(UGCLogicEntity team, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static int GetTeamRepItemTeamSeq(UGCLogicEntity team, UGCRuntime ugcRuntime)
	{
		return 0;
	}

	public static Vector3 GetTransformRepItemPosition(UGCLogicEntity transform, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static Vector3 GetTransformRepItemRotation(UGCLogicEntity transform, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static Vector3 GetTransformRepItemScale(UGCLogicEntity transform, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static object GetTransformRepItemParent(UGCLogicEntity transform, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static Quaternion GetTransformRepItemRotationQ(UGCLogicEntity transform, UGCRuntime ugcRuntime)
	{
		return default(Quaternion);
	}

	public static Vector3 GetTransformRepItemLocalPosition(UGCLogicEntity transform, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static Quaternion GetTransformRepItemLocalRotationQ(UGCLogicEntity transform, UGCRuntime ugcRuntime)
	{
		return default(Quaternion);
	}

	public static Vector3 GetTransformRepItemLocalRotation(UGCLogicEntity transform, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static Vector3 GetTransformRepItemLocalScale(UGCLogicEntity transform, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static Vector3 GetTransformRepItemUp(UGCLogicEntity entity, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static Vector3 GetTransformRepItemRight(UGCLogicEntity transform, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static Vector3 GetTransformRepItemForward(UGCLogicEntity transform, UGCRuntime ugcRuntime)
	{
		return default(Vector3);
	}

	public static bool SetTransformRepItemPosition(UGCLogicEntity transform, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetTransformRepItemRotation(UGCLogicEntity transform, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetTransformRepItemScale(UGCLogicEntity transform, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetTransformRepItemParent(UGCLogicEntity transform, UGCLogicEntity value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetTransformRepItemRotationQ(UGCLogicEntity transform, Quaternion value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetTransformRepItemLocalPosition(UGCLogicEntity transform, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetTransformRepItemLocalRotationQ(UGCLogicEntity transform, Quaternion value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetTransformRepItemLocalRotation(UGCLogicEntity transform, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetTransformRepItemLocalScale(UGCLogicEntity transform, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetTransformRepItemUp(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetTransformRepItemRight(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetTransformRepItemForward(UGCLogicEntity entity, Vector3 value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	private static bool _SetTransformAxis(UGCLogicEntity entity, Vector3 target, UGCRuntime ugcRuntime, Vector3 axis)
	{
		return false;
	}

	public static object GetTweenRepItemStartValue(UGCLogicEntity tween, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static object GetTweenRepItemEndValue(UGCLogicEntity tween, UGCRuntime ugcRuntime)
	{
		return null;
	}

	public static bool SetTweenRepItemStartValue(UGCLogicEntity tween, object value, UGCRuntime ugcRuntime)
	{
		return false;
	}

	public static bool SetTweenRepItemEndValue(UGCLogicEntity tween, object value, UGCRuntime ugcRuntime)
	{
		return false;
	}
}
