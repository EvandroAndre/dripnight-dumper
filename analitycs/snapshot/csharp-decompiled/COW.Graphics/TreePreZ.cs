using UnityEngine;

namespace COW.Graphics;

public class TreePreZ : MonoBehaviour
{
	public Shader ShaderDepth;

	public Shader ShaderColor;

	private const string PREZV2 = "_PreZV2_";

	private static bool m_EnablePreZPass;

	private static bool m_EnablePreZV2Pass;

	private void Start()
	{
	}
}
