using System;
using System.Collections.Generic;
using UnityEngine;

namespace PrefabEvolution;

[Serializable]
public class PEExposedProperties : ISerializationCallbackReceiver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<BaseExposedData, bool> _003C_003E9__7_0;

		public static Predicate<ExposedProperty> _003C_003E9__7_2;

		public static Predicate<ExposedPropertyGroup> _003C_003E9__7_3;

		internal bool _003CGetInheritedProperties_003Eb__7_0(BaseExposedData i)
		{
			return false;
		}

		internal bool _003CGetInheritedProperties_003Eb__7_2(ExposedProperty p)
		{
			return false;
		}

		internal bool _003CGetInheritedProperties_003Eb__7_3(ExposedPropertyGroup p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public int id;

		internal bool _003CRemove_003Eb__0(ExposedProperty p)
		{
			return false;
		}

		internal bool _003CRemove_003Eb__1(ExposedPropertyGroup p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public string label;

		internal bool _003CFindProperty_003Eb__0(ExposedProperty p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public int id;

		internal bool _003CFindProperty_003Eb__0(ExposedProperty p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public uint id;

		internal bool _003CFindProperty_003Eb__0(ExposedProperty p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public int id;

		internal bool _003Cget_Item_003Eb__0(BaseExposedData p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public string label;

		internal bool _003Cget_Item_003Eb__0(BaseExposedData p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public int id;

		internal bool _003CGetInherited_003Eb__0(BaseExposedData i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public int id;

		internal bool _003CGetHidden_003Eb__0(int i)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public int p;

		internal bool _003CGetInheritedProperties_003Eb__5(BaseExposedData item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public UnityEngine.Object target;

		public string propertyPath;

		internal bool _003CHasProperty_003Eb__0(ExposedProperty p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public UnityEngine.Object target;

		public string propertyPath;

		internal bool _003CRemove_003Eb__0(ExposedProperty p)
		{
			return false;
		}
	}

	[NonSerialized]
	internal List<BaseExposedData> InheritedProperties;

	[NonSerialized]
	public PEPrefabScript PrefabScript;

	public List<ExposedProperty> Properties;

	public List<ExposedPropertyGroup> Groups;

	private List<int> Hidden;

	// C# has no syntax for parameterized property 'Item'.
	public BaseExposedData get_Item(int id)
	{
		return null;
	}

	// C# has no syntax for parameterized property 'Item'.
	public BaseExposedData get_Item(string label)
	{
		return null;
	}

	public IEnumerable<BaseExposedData> Items => null;

	public IEnumerable<BaseExposedData> OrderedItems => null;

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}

	public IEnumerable<BaseExposedData> GetInheritedProperties()
	{
		return null;
	}

	public bool HasProperty(UnityEngine.Object target, string propertyPath)
	{
		return false;
	}

	public void Remove(UnityEngine.Object target, string propertyPath)
	{
	}

	public void Add(BaseExposedData exposed)
	{
	}

	public void Add(ExposedProperty exposed)
	{
	}

	public void Add(ExposedPropertyGroup exposed)
	{
	}

	public void Remove(int id)
	{
	}

	public ExposedProperty FindProperty(string label)
	{
		return null;
	}

	public ExposedProperty FindProperty(int id)
	{
		return null;
	}

	public ExposedProperty FindProperty(uint id)
	{
		return null;
	}

	public bool GetInherited(int id)
	{
		return false;
	}

	public bool GetHidden(int id)
	{
		return false;
	}

	public void SetHide(BaseExposedData property, bool state)
	{
	}

	private BaseExposedData _003CGetInheritedProperties_003Eb__7_1(BaseExposedData p)
	{
		return null;
	}

	private bool _003CGetInheritedProperties_003Eb__7_4(int p)
	{
		return false;
	}
}
