using UnityEngine;

namespace COW;

public class UIMVPCameraController : MonoBehaviour
{
	public Camera m_MVPCamera;

	private bool m_ScreenshotEventRegistered;

	private bool m_DisabledForScreenshot;

	public void SetMVPCamera(Camera camera)
	{
	}

	public void SetMvpCamera()
	{
	}

	public void SetMvpCameraInLobbySocialArea(RenderTexture targetRT)
	{
	}

	public void SetMvpVFXCameraInLobbySocialArea(RenderTexture targetRT)
	{
	}

	private void RegisterScreenshotEvents()
	{
	}

	private void OnScreenshotForMVPCamera(object[] data)
	{
	}

	private void OnDestroy()
	{
	}

	public void AddPostEffect()
	{
	}
}
