using System.Collections;

namespace GCommon;

public interface ICombineShare : IShare
{
	CombineScreenshotData OnBeforeCombineScreenshot(int index);

	void OnAfterCombineScreenshot(int index);

	IEnumerator PrepareControllerBeforeScreenshot();
}
