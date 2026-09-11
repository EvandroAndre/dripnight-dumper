using UnityEngine;

public class TextureMipmapBias : MonoBehaviour
{
	public string[] textureNames;

	public bool[] textureMipmapBias;

	private MeshRenderer renderer;

	private void Awake()
	{
	}

	public void SetMipmapBias(bool forceUpdate = false)
	{
	}
}
