using UnityEngine;

namespace COW;

public class CustomUIAtlasReleaserMgr : MonoSingleton<CustomUIAtlasReleaserMgr>
{
	private Coroutine m_IEProcess;

	public new void Init()
	{
	}

	public void SetValid(bool isValid, bool releaseNeverVisible = false, bool releaseOnce = false)
	{
	}
}
