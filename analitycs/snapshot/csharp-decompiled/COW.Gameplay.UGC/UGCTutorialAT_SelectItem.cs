using GCommon;

namespace COW.Gameplay.UGC;

public class UGCTutorialAT_SelectItem : UGCTutorialAtomicTaskBase
{
	private EventDispatcher.UEventHandler m_SelectHandler;

	private uint m_TargetItemId;

	private bool m_Registered;

	private UGCTutorialAtomicTaskParam_SelectItem m_Param;

	protected override void OnStart()
	{
	}

	protected override void OnDispose()
	{
	}

	public override bool CheckCompletion()
	{
		return false;
	}

	protected override void AutoComplete()
	{
	}

	private void OnItemSelectChanged(uint prefabId)
	{
	}

	public void _003C_003EiFixBaseProxy_AutoComplete()
	{
	}
}
