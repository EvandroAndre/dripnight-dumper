using GCommon;
using UnityEngine;

namespace COW;

public class UGCLevelObjBoundingBoxManager : SingletonModule<UGCLevelObjBoundingBoxManager>
{
	protected override void OnInit()
	{
	}

	public bool GetItemBounds(int itemID, ref Bounds bound)
	{
		return false;
	}

	private Vector3 ConvertArrayToVector3(float[] values)
	{
		return default(Vector3);
	}

	protected override void OnCleanup()
	{
	}
}
