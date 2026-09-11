using GCommon;

namespace COW;

public abstract class UICGPlayableNavigationController : UIPreviewNavigationController
{
	protected uint m_UINavigationPageType;

	protected abstract uint GetUINavigationPageType();

	protected override void OnUIInit()
	{
	}

	protected virtual void PlayCG(ResourceID cgResourceID, bool showFuncBtn = true, bool isHas = false)
	{
	}

	protected virtual void PlaySkinAnimCG(uint Type, ResourceID cgResourceID)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
