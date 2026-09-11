using System.Collections.Generic;
using GCommon;

namespace COW.Gameplay.UGC;

public class UGCTutorialAT_PlaceItemToScene : UGCTutorialAtomicTaskBase
{
	private EventDispatcher.VEventHandler m_AddObjectHandler;

	private uint m_TargetItemId;

	private bool m_Registered;

	private UGCTutorialAtomicTaskParam_PlaceItemToScene m_Param;

	private HashSet<int> m_PreExistingInstances;

	public const string REGISTRY_KEY_SCENE_CENTER = "Scene_Center";

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

	protected override void AutoComplete()
	{
	}

	private void OnAddObject()
	{
	}

	private int FindNewTargetInstanceIndex()
	{
		return 0;
	}

	private HashSet<int> SnapshotTargetInstances()
	{
		return null;
	}

	private void ProduceOutputContext(int instanceIndex)
	{
	}

	public void _003C_003EiFixBaseProxy_AutoComplete()
	{
	}
}
