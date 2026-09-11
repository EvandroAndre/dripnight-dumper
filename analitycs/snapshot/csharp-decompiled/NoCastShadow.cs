using UnityEngine;
using UnityEngine.Rendering;

public class NoCastShadow : MonoBehaviour
{
	public bool ForceDisableBRShadow;

	public Renderer[] renderers;

	public ShadowCastingMode[] shadowCastingMode;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
