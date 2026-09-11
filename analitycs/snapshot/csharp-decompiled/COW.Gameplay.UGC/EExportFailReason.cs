namespace COW.Gameplay.UGC;

public enum EExportFailReason
{
	None,
	UIModelNull,
	ModeEditNull,
	GraphEditorExportFailed,
	MapEditorExportFailed,
	WorkflowEditorExportFailed,
	EntityEditorExportFailed,
	HudEditorExportFailed,
	ModeSettingEditorExportFailed,
	ResourceEditorExportFailed,
	PlotEditorExportFailed,
	CustomEventEditorExportFailed,
	CollectResRefInProjectFailed,
	SerializeDownloadDescFailed,
	MergeCustomLevelObjectDataFailed,
	SerializeProjectDataFailed,
	SerializeRuntimeDataFailed,
	SerializeProjectMetaDataFailed,
	ScreenShotPackFailed,
	EditorErrorPanic
}
