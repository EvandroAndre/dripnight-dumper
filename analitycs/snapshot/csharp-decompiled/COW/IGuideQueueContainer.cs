using UnityEngine;

namespace COW;

public interface IGuideQueueContainer
{
	bool IsAvailable();

	bool IsStepAvailable(string stepKey, out UIWidget targetWidget, out UIButton finishButton);

	GameObject GetGuideMask();

	UICommonGuideController OpenGuideController(string stepKey);
}
