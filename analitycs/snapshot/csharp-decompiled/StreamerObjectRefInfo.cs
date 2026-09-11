public abstract class StreamerObjectRefInfo
{
	public int RefCount;

	public void InCreaseRefCount()
	{
	}

	public void DecreaseRefCount(SceneStreamerInfoHelper helper)
	{
	}

	public abstract void UnLoadAsset(SceneStreamerInfoHelper helper);
}
