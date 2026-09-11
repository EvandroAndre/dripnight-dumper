using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class CameraChangeHelper : MonoBehaviour
{
	private bool m_InWork;

	public List<CameraParam> CameraParams;

	public bool InWork
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void ChangeCameraParams(uint previewType, Camera camera = null, Transform customTrans = null, bool keepPreviewType = false)
	{
	}

	private bool ApplyDepth(Camera camera, CameraParam sourceParam)
	{
		return false;
	}

	public CameraParam GetCameraParam(uint previewType)
	{
		return null;
	}
}
