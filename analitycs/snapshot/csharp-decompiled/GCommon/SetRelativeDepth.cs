using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class SetRelativeDepth : MonoBehaviour, UISuspendable
{
	public enum PositionType
	{
		Above,
		Behind
	}

	public UIWidget widget;

	public PositionType position;

	public bool m_ChangeChildren;

	private int sortingOrder;

	private int renderQueue;

	private bool m_Suspended;

	private UIPanel m_Panel;

	private const bool updateEveryFrame = true;

	private List<Renderer> _CachedChildrenRenderers;

	private List<Renderer> CachedChildrenRenderers => null;

	private void Start()
	{
	}

	private void OnValidate()
	{
	}

	private void LateUpdate()
	{
	}

	private void RegisterUIPanel()
	{
	}

	private void UnregisterUIPanel()
	{
	}

	public void Suspend()
	{
	}

	public void Resume()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Refresh(bool isForce = false)
	{
	}
}
