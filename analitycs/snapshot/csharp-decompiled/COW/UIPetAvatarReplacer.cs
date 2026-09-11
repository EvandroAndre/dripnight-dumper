using UnityEngine;

namespace COW;

public class UIPetAvatarReplacer : MonoBehaviour
{
	private Camera m_camera;

	public UIButton button;

	public UIWidget buttonWidget;

	public Transform mockTrans;

	private float m_localScale;

	private Vector3 m_mockPos;

	private Vector3 m_cameraPos;

	private void Awake()
	{
	}

	private void OnClick()
	{
	}

	public void UpdateTransform()
	{
	}

	private void LateUpdate()
	{
	}

	public float GetButtonTopLocalPosY()
	{
		return 0f;
	}
}
