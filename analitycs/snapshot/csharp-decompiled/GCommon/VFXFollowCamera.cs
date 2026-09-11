using UnityEngine;

namespace GCommon;

public class VFXFollowCamera : MonoBehaviour
{
	public GameObject m_Target;

	private Transform m_followTrans;

	public Vector3 m_Offset;

	private void Awake()
	{
	}

	public void LateUpdate()
	{
	}
}
