using UnityEngine;

namespace COW;

public class AvatarCameraMoveComp : MonoBehaviour
{
	private Vector3 lerpstart;

	private Vector3 lerpend;

	private float lerpbgstart;

	private float lerpbgend;

	private Vector3 currentPos;

	private float currentBgPos;

	private GameObject BgObj;

	private GameObject CameraObj;

	public float currentmovetime;

	private bool IsMoving;

	private float m_Movetime;

	private float m_orignbg;

	private Vector3 m_orignpos;

	public void SetOriginInfo(Vector3 prePos, float preBgSize, GameObject bgObj, GameObject camObj, float moveDuration = 1f)
	{
	}

	public void SetSimpleLerpInfo(Vector3 start, Vector3 end, float bgstart, float bgend)
	{
	}

	public void SetMoveing()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}
}
