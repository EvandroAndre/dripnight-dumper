using System;
using UnityEngine;

namespace COW;

public class TriggerDelegator : MonoBehaviour
{
	public IOnTriggerEnterExit TriggerEnterTarget;

	public Action<Collider> OnEnter;

	public Action<Collider> OnExit;

	protected virtual bool CheckCollider(Collider other)
	{
		return false;
	}

	public void OnTriggerEnter(Collider other)
	{
	}

	public void OnTriggerExit(Collider other)
	{
	}

	protected virtual void OnEnterTriggerChecked(Collider other)
	{
	}

	protected virtual void OnExitTriggerChecked(Collider other)
	{
	}
}
