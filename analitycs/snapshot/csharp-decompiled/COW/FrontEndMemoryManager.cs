using System.Collections.Generic;
using GCommon;

namespace COW;

public class FrontEndMemoryManager : SingletonModule<FrontEndMemoryManager>
{
	private int loadedCGCount;

	private int loadedUMACount;

	private HashSet<ResourceID> loadedPreview3dModelIds;

	private const int lowMemoryThreshold = 150;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public void OnLoadCGCount(int count)
	{
	}

	public void OnLoadUMACount(int count)
	{
	}

	public void OnLoadPreview3dModel(ResourceID modelId)
	{
	}

	public void TryClearMemory()
	{
	}

	public bool WouldUnloadUma()
	{
		return false;
	}

	public void ClearUnusedAssets(bool uma = true, bool bTryCleanupFor32bitAndroid = false, bool bForceCleanup = false)
	{
	}

	public bool SkipGachaFullCG()
	{
		return false;
	}
}
