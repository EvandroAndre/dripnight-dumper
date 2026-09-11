namespace COW.Gameplay.UGC;

public class UGCVisibilityManager
{
	private readonly UGCEntityDataStore m_DS;

	public UGCVisibilityManager(UGCEntityDataStore ds)
	{
	}

	public void OnCameraCullingMaskChanged()
	{
	}

	public static bool GetFinalVisibility(string m_UGCEntityID, bool withExtraLayer = false)
	{
		return false;
	}
}
