using UnityEngine;

namespace COW;

public class UICSPeakInfoItemController : MonoBehaviour
{
	private UICSPeakInfoItemView m_View;

	private const string NAME_ANIM_REFRESH = "FF_CSLoadinginfo_on";

	private uint m_DataType;

	public void SetView(UICSPeakInfoItemView view)
	{
	}

	public void SetViewData(ELoadingBattleType loadingBattleType, uint dataType, BattleStatsInfo statsInfo = null, bool showRefreshAnim = false)
	{
	}
}
