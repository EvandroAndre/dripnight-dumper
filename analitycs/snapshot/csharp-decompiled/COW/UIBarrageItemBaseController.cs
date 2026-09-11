using GCommon;

namespace COW;

public abstract class UIBarrageItemBaseController : UIBaseController
{
	public bool IsInBarrageArea;

	public EBarrageType m_BarrageType;

	public abstract bool SetBarrageData(BarrageData data);

	public virtual void OnReachDestination()
	{
	}
}
