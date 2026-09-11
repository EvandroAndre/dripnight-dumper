using GCommon;

namespace COW.Gameplay.UGC;

public class UGCTutorialAT_ClickItemCategory : UGCTutorialAtomicTaskBase
{
	private EventDispatcher.EventHandler m_SubTabHandler;

	private int m_TargetCategoryIndex;

	private bool m_Registered;

	private UGCTutorialAtomicTaskParam_ClickItemCategory m_Param;

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

	private void OnSubTabSelect(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_AutoComplete()
	{
	}
}
