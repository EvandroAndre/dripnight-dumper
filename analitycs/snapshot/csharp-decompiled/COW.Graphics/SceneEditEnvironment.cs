namespace COW.Graphics;

public class SceneEditEnvironment : MonoSingleton<SceneEditEnvironment>
{
	public SceneEditEnvironmentPlaneAO PlaneAOMgr;

	public SceneEditEnvironmentAOFields AOFieldsMgr;

	private new void Awake()
	{
	}

	private new void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnGameLoadingOver(object[] data)
	{
	}

	private bool CheckAOFields()
	{
		return false;
	}

	private bool CheckPlaneAO()
	{
		return false;
	}
}
