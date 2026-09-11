using System;
using UnityEngine;

[Serializable]
public class UV2
{
	public Vector2[] verts;

	public UV2(Vector2[] verts)
	{
	}

	public static implicit operator UV2(Vector2[] verts)
	{
		return null;
	}
}
