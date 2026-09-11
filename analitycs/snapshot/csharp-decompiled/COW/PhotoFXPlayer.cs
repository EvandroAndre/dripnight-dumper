using GCommon;
using UnityEngine;

namespace COW;

public class PhotoFXPlayer
{
	private Camera m_Camera;

	private GameObject m_FxInstance;

	private string m_CurFxResName;

	private ResourceID m_LoadedFxResId;

	private ResourceID m_LoadingFxResId;

	private uint m_AsyncLoadTicket;

	public void SetCamera(Camera targetCamera)
	{
	}

	public void Play(string fxResName, Camera targetCamera)
	{
	}

	private void OnFxLoaded(uint ticket, bool success, Object obj)
	{
	}

	private void SetupFxInstance()
	{
	}

	public static bool HasFxResource(string fxResName)
	{
		return false;
	}

	private static ResourceID ResolveFxResId(string fxResName)
	{
		return default(ResourceID);
	}

	public void Stop()
	{
	}
}
