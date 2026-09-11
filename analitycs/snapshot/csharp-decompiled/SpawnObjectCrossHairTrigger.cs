using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

public class SpawnObjectCrossHairTrigger : MonoBehaviour
{
	protected const uint FLAGID_VEHICLE = 1u;

	protected const uint FLAGID_HUMAN = 2u;

	public GameObject Model;

	public static SpawnObjectCrossHairTrigger ActiveInstance;

	public List<int> AgainstObjectTypeList;

	public Vector3 BoxCenter;

	public Vector3 BoxSize;

	protected float m_Offy;

	private Dictionary<AttackableEntity, List<Collider>> m_EntityDic;

	private List<AttackableEntity> m_RemoveList;

	private Collider[] m_BaseColliders;

	protected BitArray AgainstTypeFlag;

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	private void InitLists()
	{
	}

	private void ClearLists()
	{
	}

	public virtual Vector3 GetSpawnPosition()
	{
		return default(Vector3);
	}

	public virtual bool HasAgainstEntities()
	{
		return false;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public virtual void UpdateOffYWithDeg(float deg)
	{
	}

	public virtual bool NeedUpdateOffY()
	{
		return false;
	}

	public virtual void TryChangeColor(bool valid)
	{
	}

	public virtual bool NeedChangeActive(bool value)
	{
		return false;
	}

	public virtual bool ActiveStateChange(bool value)
	{
		return false;
	}
}
