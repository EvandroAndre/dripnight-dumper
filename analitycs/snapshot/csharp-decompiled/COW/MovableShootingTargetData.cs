using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW;

public class MovableShootingTargetData : MonoBehaviour
{
	public float MaxHP;

	public List<Vector3> MovePointList;

	public float DelayToNextPoint;

	public float DelayToRevive;

	public float ReviveTime;

	public float MoveSpeed;

	public string ModelResID;

	public Transform ModelContainer;

	public Transform HitColliderContainer;

	public GameObject WeaponGoodContainer;

	public GameObject WeaponNormalContainer;

	public GameObject WeaponBadContainer;

	public bool CouldSelectedInShootingGame;

	public bool NeedAimAssist;

	public BKIKACLLFKL TargetType;

	public uint Group;
}
