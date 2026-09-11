using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public class UGCGameObjectManager
{
	private sealed class _003CIterateAllGameObjects_003Ed__11 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private GameObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public UGCGameObjectManager _003C_003E4__this;

		private Dictionary<string, GameObject>.Enumerator _003C_003E7__wrap1;

		GameObject IEnumerator<GameObject>.Current => null;

		object IEnumerator.Current => null;

		public _003CIterateAllGameObjects_003Ed__11(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<GameObject> IEnumerable<GameObject>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public static readonly UGCGameObjectManager Empty;

	private UGCRuntime m_Runtime;

	private UGCTransformModule m_TransformModule;

	private bool m_TransformModuleBound;

	private Dictionary<string, GameObject> m_AllGameObject;

	private Dictionary<string, Action<GameObject>> m_OnGameObjectAddEvent;

	private Dictionary<string, Action<GameObject>> m_OnGameObjectRemoveEvent;

	private UGCTransformModule TransformModule => null;

	public UGCGameObjectManager Create(UGCRuntime runtime)
	{
		return null;
	}

	public void Destroy()
	{
	}

	public IEnumerable<GameObject> IterateAllGameObjects()
	{
		return null;
	}

	public GameObject TryGetEntityGameObject(string entityID)
	{
		return null;
	}

	public IUGCPlayer TryGetPlayerByEntityID(string entityID)
	{
		return null;
	}

	public void RegisterEntityGameObject(string entityID, GameObject obj)
	{
	}

	public GameObject UnRegisterEntityGameObject(string entityID)
	{
		return null;
	}

	public void RegisterGameObjectAddEvent(string entityID, Action<GameObject> handler)
	{
	}

	public void UnRegisterGameObjectAddEvent(string entityID, Action<GameObject> handler)
	{
	}

	public void RegisterGameObjectRemoveEvent(string entityID, Action<GameObject> handler)
	{
	}

	public void UnRegisterGameObjectRemoveEvent(string entityID, Action<GameObject> handler)
	{
	}

	private void AddTransformNode(string entityID, GameObject obj)
	{
	}
}
