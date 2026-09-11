using UnityEngine;

namespace RuntimeGizmos;

public struct Square
{
	public Vector3 bottomLeft;

	public Vector3 bottomRight;

	public Vector3 topLeft;

	public Vector3 topRight;

	// C# has no syntax for parameterized property 'Item'.
	public Vector3 get_Item(int index)
	{
		return default(Vector3);
	}
}
