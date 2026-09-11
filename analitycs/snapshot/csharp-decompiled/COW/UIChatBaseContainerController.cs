using GCommon;
using UnityEngine;

namespace COW;

public abstract class UIChatBaseContainerController : UIBaseController
{
	public abstract GameObject GetContentNode();

	public abstract GameObject GetEmptyNode();

	public abstract UIScrollView GetMessageList();

	public abstract UITable2 GetMessageListTable2();

	public virtual void InitWidget(Transform parent)
	{
	}

	public abstract void RefreshContentNode();
}
