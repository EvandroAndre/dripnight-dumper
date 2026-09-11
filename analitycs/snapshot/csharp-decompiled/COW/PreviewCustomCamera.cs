using System;
using UnityEngine;

namespace COW;

public class PreviewCustomCamera
{
	public Action<bool> CameraShowAction;

	public GameObject CameraGo;

	public FrontendPreviewType PreviewType;

	public bool UseCustomCamera;

	public bool IsOnlyShowCustomOnFullScreen;

	public void Clear()
	{
	}
}
