using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class LevelBalloon : MonoBehaviour
{
	private LinkedListNode<LevelBalloon> m_node;

	private bool isInit;

	private readonly float upSpeed;

	private readonly float maxLifeTime;

	private float lifeTime;

	private ResourceID m_Resource;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void Init(LinkedListNode<LevelBalloon> node, ResourceID resource)
	{
	}

	public void BalloonDestroy()
	{
	}
}
