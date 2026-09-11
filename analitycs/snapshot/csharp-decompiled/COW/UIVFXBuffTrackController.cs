using GCommon;
using UnityEngine;

namespace COW;

internal class UIVFXBuffTrackController : UIBaseController
{
	private UIVFXBuffTrackView m_View;

	private uint m_DestroyDelay;

	private bool m_DestroyAfterTrackEnd;

	private int m_MyIndex;

	private static int m_Index;

	private static int IndexGenerator => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void PlayVFX(Vector3 startPos, Vector3 endPos, bool destroyAfterTrackEnd = true)
	{
	}

	private void OnTrackEnd(object[] datas)
	{
	}

	private void _003COnTrackEnd_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
