using UnityEngine;

public class VignetteEffect : MonoBehaviour
{
	public Shader curShader;

	public float VignettePower;

	private Material curMaterial;

	private Material material => null;

	private void Start()
	{
	}

	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
	}

	private void OnDisable()
	{
	}
}
