using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class HippoCrisisGuideEffect : MonoBehaviour
{
	public GameObject EffectNode;

	public Vector3 m_ToPos;

	private List<Transform> m_TrArrows;

	private readonly float OFFSET;

	public void DrawLine(Vector3 fromPos, Vector3 toPos)
	{
	}
}
