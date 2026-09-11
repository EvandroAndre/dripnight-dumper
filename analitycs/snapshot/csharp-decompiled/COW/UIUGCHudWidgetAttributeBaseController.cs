using COW.UGCHudEdit;
using GCommon;

namespace COW;

public abstract class UIUGCHudWidgetAttributeBaseController : UIBaseController
{
	protected RecordUGCHudWidgetAttributeCommand m_RecordCommand;

	public abstract object AttributeObject { get; set; }

	protected abstract UIUGCHudWidgetAttributeEnum GetAttributeEnum();

	public abstract void SetAttributeDirty();

	public virtual void InitDepth(int startDepth)
	{
	}

	protected void StartRecordCommand()
	{
	}

	protected void EndRecordCommand()
	{
	}
}
