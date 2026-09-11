using UnityEngine;

namespace GCommon;

public class GridValueBase
{
	protected Vector3 m_GridCoordinate;

	public Vector3 GridCoordinate => default(Vector3);

	public virtual void InitGridValue(Vector3 coordinate)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
