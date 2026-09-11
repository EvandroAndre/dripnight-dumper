namespace COW.Gameplay.UGC;

public class UGCTutorialAT_DragItemCategory : UGCTutorialAtomicTaskBase
{
	private int m_TargetCategoryIndex;

	private UIScrollView m_ScrollView;

	private UIWidget m_TargetTabWidget;

	private UIPanel.OnClippingMoved m_ClipMoveHandler;

	private bool m_ListeningClipMove;

	private UGCTutorialAtomicTaskParam_DragItemCategory m_Param;

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

	private void OnClipMove(UIPanel panel)
	{
	}

	private void UnregisterClipMove()
	{
	}

	public void _003C_003EiFixBaseProxy_AutoComplete()
	{
	}
}
