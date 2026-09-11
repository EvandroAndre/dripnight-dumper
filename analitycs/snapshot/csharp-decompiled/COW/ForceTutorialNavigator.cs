using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class ForceTutorialNavigator : MonoBehaviour
{
	protected bool m_ShowNavigator;

	public GameObject EffectNode;

	private Vector3 m_ToPos;

	private readonly float OFFSET;

	private List<Transform> m_TrArrows;

	protected bool ShowNavigator
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void OnShowGrenadeLineChanged()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void DrawLine(Vector3 fromPos, Vector3 toPos)
	{
	}

	private void DestroyTrArrows()
	{
	}

	private void OnNavigatorChange(object[] data)
	{
	}
}
