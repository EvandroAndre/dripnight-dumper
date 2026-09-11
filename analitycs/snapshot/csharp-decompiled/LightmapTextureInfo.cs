using UnityEngine;

public class LightmapTextureInfo : MonoBehaviour
{
	public int lightmapOffset;

	public Texture2D[] lightmaps;

	public Texture2D[] shadowmasks;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
