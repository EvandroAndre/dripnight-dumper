using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public abstract class StatedTaggedTriggerDelegator : TriggerDelegator
{
	private List<int> m_WithinTriggers;

	public Action OnEnterState;

	public Action OnExitState;

	public bool IsInTriggers => false;

	protected override void OnEnterTriggerChecked(Collider other)
	{
	}

	protected override void OnExitTriggerChecked(Collider other)
	{
	}

	private void CallActionForCount(Action a, int i)
	{
	}

	public void Clear()
	{
	}

	public void _003C_003EiFixBaseProxy_OnEnterTriggerChecked(Collider P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnExitTriggerChecked(Collider P0)
	{
	}
}
