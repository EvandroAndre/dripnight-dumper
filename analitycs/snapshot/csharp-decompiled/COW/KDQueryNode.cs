using UnityEngine;

namespace COW;

public class KDQueryNode
{
	public KDNode node;

	public Vector3 tempClosestPoint;

	public float distance;

	public KDQueryNode()
	{
	}

	public KDQueryNode(KDNode node, Vector3 tempClosestPoint)
	{
	}
}
