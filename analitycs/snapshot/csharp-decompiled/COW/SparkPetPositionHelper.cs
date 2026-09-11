using UnityEngine;

namespace COW;

public static class SparkPetPositionHelper
{
	public struct SparkPetScreenOffsets
	{
		public float leftOffset;

		public float rightOffset;

		public float bottomOffset;

		public float topOffset;
	}

	public static Vector3 CalculateBuddyPosition(UISparkPetAvatar mainSparkPet, UISparkPetAvatar buddySparkPet, SparkPetDisplaySettings settings, bool placeOnRight, UIRoot uiRoot, bool calSpacing)
	{
		return default(Vector3);
	}

	public static Vector3 CalculateMainPositionFromBuddy(UISparkPetAvatar mainSparkPet, UISparkPetAvatar buddySparkPet, SparkPetDisplaySettings settings = null, bool buddyIsOnRight = true, UIRoot uiRoot = null)
	{
		return default(Vector3);
	}

	public static float GetWorldSpaceSpacing(SparkPetDisplaySettings settings, UIRoot uiRoot)
	{
		return 0f;
	}

	private static Vector3 CalculateRelativePosition(UISparkPetAvatar mainSparkPet, UISparkPetAvatar buddySparkPet, float spacing, bool buddyOnRight, bool isReverse)
	{
		return default(Vector3);
	}

	public static float GetSparkPetHalfWidth(UISparkPetAvatar sparkPet)
	{
		return 0f;
	}

	public static Vector3 CalculateWorldPositionFromNormalized(float normalizedX, float normalizedY, Camera uiCamera, float zDepth)
	{
		return default(Vector3);
	}

	public static Vector2 ConvertWorldToNormalized(Vector3 worldPosition, Camera uiCamera)
	{
		return default(Vector2);
	}

	public static SparkPetScreenOffsets CalculateScreenOffsets(UISparkPetAvatar sparkPet, Camera camera, float screenToUIRatio)
	{
		return default(SparkPetScreenOffsets);
	}

	public static float CalculateSparkPetHeightInUI(Bounds totalBounds, Camera camera, float screenToUIRatio)
	{
		return 0f;
	}

	public static float CalculateSparkPetWidthInUI(Bounds totalBounds, Camera camera, float screenToUIRatio)
	{
		return 0f;
	}

	public static void ChangeMaskWidgetPos(UIWidget widget, Vector3 sparkPetScreenPos, Camera camera, float screenToUIRatio)
	{
	}

	public static ESparkPetDialoguePosition GetSparkPetDialoguePosition(UISparkPetAvatar sparkPet, Camera uiCamera, UIWidget dialogueWidget, Transform dialogueTransform, float screenToUIRatio, SparkPetDisplaySettings settings = null)
	{
		return ESparkPetDialoguePosition.None;
	}

	private static bool HasSpaceAbove(Vector3 worldPosition, UIWidget widget, Camera uiCamera, float screenToUIRatio)
	{
		return false;
	}
}
