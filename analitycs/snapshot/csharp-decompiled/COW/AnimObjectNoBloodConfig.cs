using System;
using UnityEngine;

namespace COW;

[Serializable]
public class AnimObjectNoBloodConfig : ScriptableObject
{
	public GameObject Object_Normal;

	public GameObject Object_NoBlood;

	public GameObject GetObject()
	{
		return null;
	}
}
