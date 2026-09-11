namespace COW.Gameplay.UGC;

public class AICmd
{
	public float GameTime;

	public ESceneEditAILogType Type;

	public string EntityID;

	public virtual ExportAILogCmd Export()
	{
		return null;
	}
}
