using UnityEngine;

namespace COW;

public class PreviewCameraMove : PreviewBaseComponent
{
	public static Vector3 DEFAULTSTRARPOS;

	public static Vector3 DEFAULTENDPOS;

	protected float m_Movetime;

	protected bool movedir;

	protected bool cameramove;

	public Vector3 startPos;

	public Vector3 middelePos;

	public Vector3 endPos;

	public float bgStart;

	public float bgEnd;

	public float movetime;

	public Vector3 startAngle;

	private Vector3 m_CurrentPos;

	private Vector3 lerpstart;

	private Vector3 lerpend;

	public float lerpbgstart;

	public float lerpbgend;

	public float lerpbgcurrent;

	private bool m_IsNeedStopAvatarAnim;

	private GameObject BgObj;

	private float currentmovetime;

	private float m_OriginFov;

	private float m_OriginNear;

	private float m_OriginFar;

	private Camera m_Camera;

	public Vector3 Lerpend
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public bool IsNeedStopAvatarAnim
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void SetLerpBgObj(GameObject obj)
	{
	}

	private void Awake()
	{
	}

	public void SavePos()
	{
	}

	public void ResumePos()
	{
	}

	public void SetCameraStartPos()
	{
	}

	public bool CheckCanClick()
	{
		return false;
	}

	public void InitCameraOriginParams(float fov, float near, float far)
	{
	}

	public void SetEnable(bool dir)
	{
	}

	public void SetMiddlePos(Vector3 pos)
	{
	}

	public void SetEndPos(Vector3 pos)
	{
	}

	public void SetStartPos(Vector3 pos)
	{
	}

	public void SetStartAngle(Vector3 angle)
	{
	}

	public void SetMoveTime(float time)
	{
	}

	public void InitLerpEndPos(Vector3 pos)
	{
	}

	public void ResetCameraTrans()
	{
	}

	private void OnDestroy()
	{
	}

	public void FocusBg()
	{
	}

	private void Update()
	{
	}
}
