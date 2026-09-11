using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW;

internal class UGCRepDataSmoothSystem
{
	public class Vector4Queue
	{
		private List<Vector4> m_List;

		public int Count => 0;

		// C# has no syntax for parameterized property 'Item'.
		public Vector4 get_Item(int index)
		{
			return default(Vector4);
		}

		public void EnqueueVector(Vector4 value)
		{
		}

		public Vector4 Dequeue()
		{
			return default(Vector4);
		}

		public void Clear()
		{
		}
	}

	private class Handle
	{
		public bool IsAllocated;

		public bool IsRunning;

		public string EntityID;

		public long PropID;

		public long PropType;

		public float ElapsedRatio;

		public Vector4 StartValue;

		private Vector4 m_TargetValue;

		private Vector4Queue m_PendingTargetQueue;

		public Vector4 LerpedValue;

		private const int SKIPSTEPTHRESHOLD = 10;

		private const int MAXSKIPSTEPS = 5;

		public Vector4 TargetValue
		{
			get
			{
				return default(Vector4);
			}
			set
			{
			}
		}

		public Vector4Queue PendingTargetQueue => null;

		public bool RefreshNextTarget()
		{
			return false;
		}

		private int GetSkipStep()
		{
			return 0;
		}

		public void Finished()
		{
		}

		public void AddTargetValue(KEJFJKMAHNF newval)
		{
		}

		public Vector4 GetTailValue()
		{
			return default(Vector4);
		}

		public void CheckShouldStart()
		{
		}
	}

	private UGCEntityDataStore m_DataStore;

	private const float C_DEFAULT_INTERNAL_30FPS = 0.033f;

	private const float C_DEFAULT_INTERNAL_15FPS = 0.066f;

	public static float ServerInterval;

	private float RealDeltaRatio;

	private float ClientInterval;

	private List<Handle> m_HandleList;

	private Dictionary<string, Dictionary<long, int>> m_HandleMap;

	public UGCRepDataSmoothSystem(UGCEntityDataStore ds)
	{
	}

	public void Destroy()
	{
	}

	private void CalculateInterval()
	{
	}

	public bool ContainsHandle(string entityID, long propId)
	{
		return false;
	}

	private bool TryGetNewHandle(string entityID, long propId, out Handle handle)
	{
		handle = null;
		return false;
	}

	private bool TryGetExistingHandle(string entityID, long propId, out Handle handle)
	{
		handle = null;
		return false;
	}

	public void ReleaseHandle(string entityID, long propId)
	{
	}

	public void SetEnergySavingMode(bool enable)
	{
	}

	public void Update()
	{
	}

	private void NotifyDataStore(Handle handle)
	{
	}

	public void ReceiveTargetValueFromServer(string entityID, long propID, KEJFJKMAHNF targetValue)
	{
	}
}
