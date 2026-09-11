using COW;
using UnityEngine;

public class LightmapTextureInfoPatch : MonoBehaviour
{
	public StreamPrefabSource patchType;

	public int patchIndex;

	public int[] lightmapIndexes;

	public Texture2D[] lightmaps;

	public Texture2D[] shadowmasks;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
