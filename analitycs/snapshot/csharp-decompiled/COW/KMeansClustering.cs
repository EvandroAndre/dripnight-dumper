using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class KMeansClustering
{
	public class ClusterResult
	{
		public Vector2[] centers;

		public int[] assignments;

		public int iterations;

		public bool converged;

		public int GetClusterSize(int clusterIndex)
		{
			return 0;
		}
	}

	private int m_MaxIterations;

	private float m_ConvergenceThreshold;

	public void SetMaxIterations(int maxIterations)
	{
	}

	public void SetConvergenceThreshold(float threshold)
	{
	}

	public ClusterResult Cluster(List<Vector2> points, int k)
	{
		return null;
	}

	private void InitializeCentersKMeansPlusPlus(List<Vector2> points, Vector2[] centers)
	{
	}

	private int FindNearestCenter(Vector2 point, Vector2[] centers)
	{
		return 0;
	}

	private void UpdateCenters(List<Vector2> points, int[] assignments, Vector2[] centers)
	{
	}
}
