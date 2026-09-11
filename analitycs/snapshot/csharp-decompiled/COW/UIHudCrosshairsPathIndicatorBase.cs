using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCrosshairsPathIndicatorBase
{
	protected GameObject m_MaterialGo;

	protected Transform m_MaterialTrans;

	protected const float m_YOffset = 0.3f;

	protected uint m_AsyncLoadTicket;

	protected virtual void CancelAsyncLoad()
	{
	}

	protected virtual void OnMaterialLoaded(uint ticket, bool success, Object obj)
	{
	}

	protected virtual ResourceID GetIndicatorResID()
	{
		return default(ResourceID);
	}

	protected virtual EventID GetIndicatorEventID()
	{
		return EventID.APPLICATION_QUIT;
	}

	public virtual void OnInit()
	{
	}

	public virtual void OnDestroy()
	{
	}

	public virtual void OnUpdate()
	{
	}

	protected virtual void CalVFXRotate()
	{
	}

	protected virtual void OnIndicatorStateChange(object[] data)
	{
	}
}
