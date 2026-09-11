namespace COW.Gameplay.UGC;

public static class UGCTutorialAtomicTaskFactory
{
	public const string TYPE_CLICK_ITEM_CATEGORY = "ClickItemCategory";

	public const string TYPE_SELECT_ITEM = "SelectItem";

	public const string TYPE_PLACE_ITEM_TO_SCENE = "PlaceItemToScene";

	public const string TYPE_DRAG_ITEM_CATEGORY = "DragItemCategory";

	public const string TYPE_MOVE_ITEM_TO_POSITION = "MoveItemToPosition";

	public const string TYPE_SELECT_SCENE_OBJECT = "SelectSceneObject";

	public const string TYPE_OPEN_ITEM_ATTRIBUTE_MODE = "OpenItemAttributeMode";

	public const string TYPE_CLOSE_ITEM_ATTRIBUTE_MODE = "CloseItemAttributeMode";

	public const string TYPE_OPEN_ITEM_FUNC_COLOR = "OpenItemFuncColor";

	public const string TYPE_PICK_COLOR_WHEEL_PRESET = "PickColorWheelPreset";

	public const string TYPE_CLOSE_COLOR_WHEEL = "CloseColorWheel";

	public const string TYPE_CLICK_PLAY_BUTTON = "ClickPlayButton";

	public const string TYPE_EXIT_PREVIEW_MODE = "ExitPreviewMode";

	public const string TYPE_CLICK_EXIT_EDITOR = "ClickExitEditor";

	public const string TYPE_CLICK_SAVE_AND_PUBLISH = "ClickSaveAndPublish";

	public const string TYPE_PUBLISH_IN_DIALOG = "PublishInDialog";

	public static UGCTutorialAtomicTaskBase Create(string taskType)
	{
		return null;
	}
}
