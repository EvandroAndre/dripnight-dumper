using System;
using UnityEngine;

namespace GCommon.Trails;

public abstract class TrailRenderer_Base : MonoBehaviour
{
	public PCTrailRendererData TrailData;

	protected bool m_NoDecay;

	private PCTrail m_ActiveTrail;

	protected Transform m_Transform;

	private TrailManager m_Manager;

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void LateUpdate()
	{
	}

	protected virtual void Update()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected abstract Color GetMainColor();

	protected abstract int GetMaxNumberOfPoints();

	protected virtual void Reset()
	{
	}

	protected virtual void InitialiseNewPoint(PCTrailPoint newPoint)
	{
	}

	protected virtual void UpdateTrail(PCTrail trail, float deltaTime)
	{
	}

	protected void AddPoint(Vector3 pos)
	{
	}

	private void GenerateMesh(PCTrail trail)
	{
	}

	private void UpdatePoints(PCTrail line, float deltaTime)
	{
	}

	protected virtual void UpdatePoint(PCTrailPoint pCTrailPoint, float deltaTime)
	{
	}

	private int NumberOfActivePoints(PCTrail line)
	{
		return 0;
	}

	protected virtual void InitPCTrail(Type type)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
