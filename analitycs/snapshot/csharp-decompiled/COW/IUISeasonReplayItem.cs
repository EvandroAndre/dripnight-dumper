using GCommon;

namespace COW;

public interface IUISeasonReplayItem
{
	void Selected(bool isFirstEnter);

	void UnSelected();

	void Init(bool isBR);

	void HidePreview();

	void RecoverPreview();

	void HideView();

	CombineScreenshotData BeforeCombineShare();

	void AfterCombineShare();

	void PrepareControllerBeforeScreenshot();
}
