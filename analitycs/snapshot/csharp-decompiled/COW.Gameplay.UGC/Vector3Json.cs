using LitJson;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class Vector3Json
{
	public JsonData x;

	public JsonData y;

	public JsonData z;

	public static implicit operator Vector3(Vector3Json v)
	{
		return default(Vector3);
	}
}
