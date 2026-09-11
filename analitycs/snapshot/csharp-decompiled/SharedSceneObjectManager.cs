using System.Collections.Generic;

public class SharedSceneObjectManager : MonoSingleton<SharedSceneObjectManager>
{
	private Dictionary<int, SharedSceneObjectRecord> objectDict;

	public void Register(SharedSceneObject obj, int key)
	{
	}

	public void Unregister(SharedSceneObject obj, int key)
	{
	}

	protected override void OnDestroy()
	{
	}
}
