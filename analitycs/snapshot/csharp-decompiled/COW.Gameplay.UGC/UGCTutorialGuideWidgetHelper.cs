using UnityEngine;

namespace COW.Gameplay.UGC;

public static class UGCTutorialGuideWidgetHelper
{
	private const int ITEM_PANEL_DRAG_GUIDE_INDEX = 22;

	private const int ITEM_PANEL_DRAG_GUIDE2_INDEX = 23;

	public const int GUIDE_DEPTH_OFFSET_ABOVE_POPUP = 2;

	public const string REGISTRY_KEY_ADJUST_ATTRIBUTE_BTN = "SceneEdit_Adjust_AttributeBtn";

	public const string REGISTRY_KEY_INSPECTOR_CLOSE_BTN = "SceneEdit_Inspector_CloseBtn";

	public const string REGISTRY_KEY_ITEM_FUNC_COLOR_BTN = "SceneEdit_ItemAttribute_ColorBtn";

	public const string REGISTRY_KEY_SCENE_EDIT_PLAY_BTN = "SceneEdit_Option_PlayBtn";

	public const string REGISTRY_KEY_SCENE_EDIT_EXIT_PREVIEW_BTN = "SceneEdit_Option_ExitPreviewBtn";

	public const string REGISTRY_KEY_SCENE_EDIT_BACK_BTN = "SceneEdit_LeftOption_BackBtn";

	public const string REGISTRY_KEY_EXIT_EDITOR_SAVE_AND_PUBLISH_BTN = "ExitEditor_SaveAndPublishBtn";

	public const string REGISTRY_KEY_PUBLISH_CHECK_PUBLISH_BTN = "PublishCheck_PublishBtn";

	public const string REGISTRY_KEY_PREFIX_COLOR_WHEEL_PRESET = "ColorWheel_Preset_";

	public const string REGISTRY_KEY_COLOR_WHEEL_POPUP_CONTENT = "ColorWheel_PopupContent";

	public static UIWidget FindItemPanelViewWidget(int viewVarIndex)
	{
		return null;
	}

	public static UIWidget FindItemPanelDragGuide()
	{
		return null;
	}

	public static UIWidget FindItemPanelSubTypeTabWidget()
	{
		return null;
	}

	public static void RegisterItemPanelWidgets()
	{
	}

	public static string GetMainTabRegistryKey(int tabIndex)
	{
		return null;
	}

	public static UIScrollView FindSliderScrollView()
	{
		return null;
	}

	public static UIWidget FindMainTabWidget(int tabIndex)
	{
		return null;
	}

	public static bool IsMainTabVisibleInScrollView(UIScrollView scrollView, UIWidget tabWidget)
	{
		return false;
	}

	public static void RegisterMainTabWidget(int tabIndex)
	{
	}

	public static string GetItemCellRegistryKey(uint prefabId)
	{
		return null;
	}

	public static void RegisterItemCellWidget(uint prefabId)
	{
	}

	public static bool TryGetPopupAdjustedGuideDepth(UIWidget targetWidget, out int targetDepth)
	{
		targetDepth = default(int);
		return false;
	}

	public static bool TryGetPopupAdjustedGuideDepth(GameObject targetObject, out int targetDepth)
	{
		targetDepth = default(int);
		return false;
	}

	public static bool TryGetPopupAdjustedGuideDepth(Transform targetTransform, out int targetDepth)
	{
		targetDepth = default(int);
		return false;
	}

	public static bool TryGetPopupAdjustedGuideDepth(UIWidget targetWidget, int offsetAbovePopup, out int targetDepth)
	{
		targetDepth = default(int);
		return false;
	}

	public static bool TryGetPopupAdjustedGuideDepth(Transform targetTransform, int offsetAbovePopup, out int targetDepth)
	{
		targetDepth = default(int);
		return false;
	}

	public static string GetColorWheelPresetHexKey(string hex)
	{
		return null;
	}

	public static void RegisterItemAdjustAttributeButton()
	{
	}

	public static void RegisterInspectorCloseButton()
	{
	}

	public static void RegisterItemAttributeColorButtonIfPresent()
	{
	}

	public static void RegisterSceneEditPlayButton()
	{
	}

	public static void RegisterSceneEditExitPreviewButton()
	{
	}

	public static void RegisterSceneEditBackButton()
	{
	}

	public static void RegisterExitEditorSaveAndPublishButton()
	{
	}

	public static void RegisterColorWheelPresetItems()
	{
	}

	public static void RegisterColorWheelPopupContent()
	{
	}

	public static void RegisterPublishCheckPublishButton(UIUGCMyWorksPublishCheckController ctrl)
	{
	}
}
