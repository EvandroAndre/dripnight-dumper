using GCommon;

namespace COW;

public class UIGachaFeatureManager : SingletonModule<UIGachaFeatureManager>
{
	private UIGachaFeatureController m_GachaFeature;

	public void RegisterGachaFeature(UIGachaFeatureController ctrl)
	{
	}

	public void UnRegisterGachaFeature(UIGachaFeatureController ctrl)
	{
	}

	public bool OnScreenShot()
	{
		return false;
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}
}
