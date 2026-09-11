using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UICustomParamUtil : MonoBehaviour
{
	[Serializable]
	public class ParamKeyValue
	{
		public string name;

		public string value;
	}

	public List<ParamKeyValue> paramList;

	private Dictionary<string, string> m_ParamListDic;

	private Dictionary<string, string> ParamListDic => null;

	public bool TryGetValue(string name, ref int result)
	{
		return false;
	}

	public bool TryGetValue(string name, ref float result)
	{
		return false;
	}

	public bool TryGetValue(string name, ref Color result)
	{
		return false;
	}

	public bool TryGetValue(string name, ref string result)
	{
		return false;
	}
}
