using GCommon;

namespace COW.Gameplay.UGC;

public class UGCTutorialAT_SelectSceneObject : UGCTutorialAtomicTaskBase
{
	private EventDispatcher.VEventHandler m_SelectionHandler;

	private bool m_Registered;

	private UGCTutorialContextContent_SceneItem m_ContextItem;

	protected override void OnStart()
	{
	}

	protected override void OnDispose()
	{
	}

	public override bool CheckCompletion()
	{
		return false;
	}

	private void OnSelectionChanged()
	{
	}
}
