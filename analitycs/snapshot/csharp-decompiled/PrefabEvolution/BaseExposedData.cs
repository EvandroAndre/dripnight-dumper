using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace PrefabEvolution;

public class BaseExposedData : ISerializationCallbackReceiver
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Comparer : IComparer<BaseExposedData>
	{
		public int Compare(BaseExposedData x, BaseExposedData y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public BaseExposedData parent;

		internal bool _003Cget_Brothers_003Eb__0(BaseExposedData i)
		{
			return false;
		}
	}

	[NonSerialized]
	public PEExposedProperties Container;

	private int guid;

	public string Label;

	public int ParentId;

	public float Order;

	public int SiblingIndex => 0;

	public int Id => 0;

	public BaseExposedData Parent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public IEnumerable<BaseExposedData> Children => null;

	public IEnumerable<BaseExposedData> Brothers => null;

	public bool Inherited => false;

	public bool Hidden
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual void OnBeforeSerialize()
	{
	}

	public virtual void OnAfterDeserialize()
	{
	}

	public float GetOrder(bool next)
	{
		return 0f;
	}

	public virtual BaseExposedData Clone()
	{
		return null;
	}

	private bool _003Cget_Children_003Eb__17_0(BaseExposedData item)
	{
		return false;
	}
}
