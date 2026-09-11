using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCAirDropEntity : MonoBehaviour
{
	private UGCAirDropRepItem m_AirDropRepItem;

	private UGCTransformRepItem m_TransformRepItem;

	private GameObject m_SceneAirDropBar;

	private Vector3 m_LocalPos => default(Vector3);

	private Quaternion m_LocalRot => default(Quaternion);

	public void LoadAirDropFlag()
	{
	}

	private void OnDestroy()
	{
	}

	private void AirDropStateChangeEvent(int value)
	{
	}

	private void LocalPositionChangeEvent(Vector3 vector)
	{
	}

	private void LocalRotationQChangeEvent(Quaternion quaternion)
	{
	}

	public static UGCAirDropEntity Create(string entityID)
	{
		return null;
	}
}
