using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHUDUGC_InternalHudController : UIBaseController, IUIHUDBaseController
{
	protected string m_EntityID;

	protected Dictionary<UIPanel, int> m_PanelDepth;

	private UGCInternalHudRepItem m_UGCInternalHudRepItem;

	public virtual void SetEntityID(string entityID)
	{
	}

	public virtual void DestroyEntity()
	{
	}

	private void OnDepthChanged(int cur)
	{
	}
}
