using System;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

namespace COW;

[Serializable]
public class CameraParam
{
	public FrontEndPreviewTypeForCameraChange PreviewType;

	public bool ChangeCustomCamera;

	public Camera CustomCamera;

	public bool ChangeCustomVirtualCamera;

	public List<CinemachineVirtualCamera> CustomVirtualCamera;

	public Vector3 Position;

	public bool UsePosition;

	public Vector3 Rotation;

	public bool UseRotation;

	public float FieldOfView;

	public float ClippingPanelFar;

	public float ClippingPanelNear;

	public bool UseClippingPanelNear;

	public float Depth;

	public bool UseDepth;
}
