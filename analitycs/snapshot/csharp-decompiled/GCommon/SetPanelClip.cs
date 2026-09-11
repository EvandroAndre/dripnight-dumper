using UnityEngine;

namespace GCommon;

public class SetPanelClip : MonoBehaviour, IOnWillRenderObjectInterface
{
	private UIPanel panel;

	private Shader originalShader;

	private Renderer CachedRenderer;

	private bool isParticle;

	private bool isLineRenderer;

	private Shader originalTrailShader;

	private static int[] LocalToPanelMatrix;

	private static int[] ClipRange;

	private static int[] ClipArgs;

	public bool NeedSetClip;

	public bool SetClipOnEnable;

	private void Start()
	{
	}

	public void SetClipping()
	{
	}

	private void RemoveClipping()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	void IOnWillRenderObjectInterface.OnWillRenderObject()
	{
	}

	private void OnWillRenderObject()
	{
	}
}
