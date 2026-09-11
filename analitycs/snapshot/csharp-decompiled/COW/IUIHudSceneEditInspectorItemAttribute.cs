using System;

namespace COW;

public interface IUIHudSceneEditInspectorItemAttribute
{
	event Action OnRefreshListRequested;

	void TriggerRefresh();
}
