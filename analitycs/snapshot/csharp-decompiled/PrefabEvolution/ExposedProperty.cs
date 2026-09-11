using System;
using System.Reflection;
using UnityEngine;

namespace PrefabEvolution;

[Serializable]
public class ExposedProperty : BaseExposedData
{
	public class PropertyInvocationChain
	{
		public class InvokeInfo
		{
			public MemberInfo member;

			public int index;

			public object tempTarget;

			public Type valueType;

			public object GetValue(object target)
			{
				return null;
			}

			public void SetValue(object target, object value)
			{
			}

			public void SetValue(object value)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass14_0
		{
			public string field;

			internal bool _003CgetField_003Eb__0(MemberInfo m)
			{
				return false;
			}
		}

		public object root;

		public string path;

		public InvokeInfo[] members;

		public object value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isValid => false;

		public PropertyInvocationChain(object root, string path)
		{
		}

		internal static object GetInstance(object obj, string path, out InvokeInfo[] members)
		{
			members = null;
			return null;
		}

		private static object GetMemberValue(object target, MemberInfo member, int index = -1)
		{
			return null;
		}

		private static void setValue(object target, MemberInfo member, object value, int index = -1)
		{
		}

		public static string GetValidFieldName(ref object obj, string fieldName)
		{
			return null;
		}

		private static object getField(object obj, string field, out MemberInfo member, int index = -1)
		{
			member = null;
			return null;
		}
	}

	public UnityEngine.Object Target;

	public string PropertyPath;

	private PropertyInvocationChain _invocationChain;

	private PropertyInvocationChain invocationChain => null;

	public bool IsValid => false;

	public object Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override BaseExposedData Clone()
	{
		return null;
	}

	public override void OnAfterDeserialize()
	{
	}
}
