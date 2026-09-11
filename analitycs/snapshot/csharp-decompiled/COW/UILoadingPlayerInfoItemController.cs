using UnityEngine;

namespace COW;

public class UILoadingPlayerInfoItemController : MonoBehaviour
{
	private UILoadingPlayerInfoItemView m_View;

	private const string NAME_ANIM_REFRESH = "FF_CSLoadinginfo_on";

	private uint m_DataType;

	public void SetView(UILoadingPlayerInfoItemView view)
	{
	}

	public void SetViewData(ELoadingBattleType loadingBattleType, uint dataType, BattleStatsInfo statsInfo = null, bool showRefreshAnim = false)
	{
	}
}
