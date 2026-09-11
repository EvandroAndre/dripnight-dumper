using UnityEngine;

namespace GCommon;

internal class BlackWhiteEffect : MonoBehaviour
{
	private Material m_CurMaterial;

	private Shader m_BWShader;

	private Shader BWShader => null;

	private Material CurMaterial => null;

	private void Start()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
