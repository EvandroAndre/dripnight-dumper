using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

internal class UIHudLWSOLeaderBoardItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public UIHudLWSOLeaderBoardItemController _003C_003E4__this;

		public float waitingTime;

		public int randomCount;

		internal void _003CSetItemInfo_003Eb__0()
		{
		}
	}

	private UIHudLWSOLeaderBoardItemView m_View;

	private UIModelMatch m_ModelMatch;

	private CIBDABGDGOM m_Game;

	private MFNHNEDOGKH m_Data;

	private List<UISprite> m_HPList;

	private uint m_RandomIconDelayCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public bool SetItemInfo(MFNHNEDOGKH data, bool matchMaking, bool changeData)
	{
		return false;
	}

	private void ShowZoneIconInfo(int zone, int Identity)
	{
	}

	public void HideInfo()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
