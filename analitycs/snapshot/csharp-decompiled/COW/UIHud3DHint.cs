using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHud3DHint : MonoBehaviour
{
	public MeshRenderer m_MeshRenderer;

	public Transform m_VFXContainer;

	private BHGGAEEHJCO m_TargetPlayer;

	private ResourceID m_ResID;

	private float m_StartTime;

	private Vector3 m_Pos;

	private VisualInstanceHolder m_VFXHolder;

	private GameObject m_VFX;

	private InGameHint3DManager.EHint3DType m_Hint3DType;

	private WarningHintData m_hintData;

	private bool m_LongLast;

	private bool m_PosFixed;

	private bool m_IsValid;

	public float StartTime => 0f;

	public BHGGAEEHJCO TargePlayer => default(BHGGAEEHJCO);

	public ResourceID ResID => default(ResourceID);

	public Vector3 Pos => default(Vector3);

	public GameObject VFX => null;

	public InGameHint3DManager.EHint3DType Hint3DType => InGameHint3DManager.EHint3DType.None;

	public float ExpireTime => 0f;

	public bool LongLast => false;

	public bool PosFixed => false;

	public bool IsValid
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void SetHitHintInfo(BHGGAEEHJCO player, ResourceID resId, InGameHint3DManager.EHint3DType hint3DType)
	{
	}

	public void ResetHitHintInfo()
	{
	}

	public void ResetExpireTime()
	{
	}

	public void SetFireHintInfo(BHGGAEEHJCO player, WarningHintData hintData, bool longLast, bool postionFixed, ResourceID resId, Vector3 pos)
	{
	}

	public void ResetFireHintInfo()
	{
	}

	public void SetGrenadeHintInfo(ResourceID resId, bool isValid, BHGGAEEHJCO playerId)
	{
	}

	public void SetGrenadeHintInfo(ResourceID resId, bool isValid, Vector3 pos)
	{
	}

	public void RefreshGrenadeHintInfo(bool isValid, Vector3 pos)
	{
	}

	public void ResetGrenadeHintInfo()
	{
	}

	public void SetEnemyReviveHintInfo(ResourceID resId)
	{
	}

	public void ResetEnemyReviveHintInfo()
	{
	}

	public void SetEnemyChargeHintInfo(BHGGAEEHJCO player, ResourceID resId, float startTime)
	{
	}

	public void ResetEnemyChargeHintInfo()
	{
	}

	private VisualInstanceHolder EnsureVisualInstanceHolder()
	{
		return null;
	}

	private void TryReleasePreviousHolder()
	{
	}

	public void CreateVFXOBJ(ResourceID resourceID, Vector3 scale)
	{
	}

	private void OnVFXLoaded(GameObject go)
	{
	}
}
