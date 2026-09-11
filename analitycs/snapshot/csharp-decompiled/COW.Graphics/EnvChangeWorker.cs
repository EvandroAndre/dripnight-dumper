using System.Collections.Generic;
using UnityEngine;

namespace COW.Graphics;

public class EnvChangeWorker : MonoBehaviour
{
	public string ControllerID;

	public bool AutoTransparentSWITCHING;

	public bool SetRenderTypeOpaque;

	public bool DeactivateBeforeSwitchStart;

	public bool DeactivateAfterSwitchEnd;

	public bool EnableFasterBlend;

	public List<Material> MaterialArray;

	public List<Renderer> ToHideRendererArray;

	public List<Material> GetMaterialArray()
	{
		return null;
	}

	private void Hide(object[] data)
	{
	}

	private void Show(object[] data)
	{
	}

	private void Awake()
	{
	}

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
