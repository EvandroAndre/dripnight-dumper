using UnityEngine;

public class LightmapTextureInfo2 : MonoBehaviour
{
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
