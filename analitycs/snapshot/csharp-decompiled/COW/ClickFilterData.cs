using System;
using UnityEngine;

namespace COW;

[Serializable]
public class ClickFilterData
{
	public string FilterKey;

	public GameObject FilterGo;

	public ClickFilterData(string key, GameObject go)
	{
	}
}
