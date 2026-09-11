using GCommon.CommandPattern;

namespace COW.UGCHudEdit;

public class RecordUGCHudWidgetHierarchyCommand : RecordCommand
{
	private UIUGCHudWidgetHierarchyNodeItemController m_Target;

	private UIUGCHudWidgetHierarchyNodeItemController m_InitParentNode;

	private int m_InitIndex;

	private UIUGCHudWidgetHierarchyNodeItemController m_CurrentParentNode;

	private int m_CurrentIndex;

	public void SetTarget(UIUGCHudWidgetHierarchyNodeItemController item)
	{
	}

	public override void Execute()
	{
	}

	public override void UnExecute()
	{
	}

	public override void Record()
	{
	}

	public override void Clear()
	{
	}

	public void _003C_003EiFixBaseProxy_Clear()
	{
	}
}
