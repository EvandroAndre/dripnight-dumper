using UnityEngine;
using UnityEngine.Rendering;

public class PlannarShadowRenderer : MonoBehaviour
{
	public delegate void OnPLShadowContainerChanged(PlannarShadowRenderer shadowRenderer, bool isAdd);

	public CommandBuffer commandBuffer;

	public Camera drawCamera;

	public bool inconsistentCamera;

	public OnPLShadowContainerChanged onContainerChanged;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
