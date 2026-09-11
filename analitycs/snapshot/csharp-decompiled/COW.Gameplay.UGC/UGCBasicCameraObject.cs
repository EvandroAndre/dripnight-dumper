using COW.GamePlay;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCBasicCameraObject : MonoBehaviour
{
	public GameObject Perspective;

	public GameObject Orthogonal;

	private bool m_Selected;

	private NHMBEJGPEMP m_CameraProjectionMode;

	private float m_Fov;

	private float m_OrthogonalSize;

	public NHMBEJGPEMP CameraProjectionMode
	{
		get
		{
			return NHMBEJGPEMP.Perspective;
		}
		set
		{
		}
	}

	public float Fov
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float OrthogonalSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void SetSelected(bool selected)
	{
	}
}
