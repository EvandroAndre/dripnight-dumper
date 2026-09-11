using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UICupMatchAccomplishedController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public CupTeamInfo cupTeamInfo;

		internal bool _003CRefreshTeamView_003Eb__0(UIModelCupMatch.AccountInfoBasicWithCupInfo m)
		{
			return false;
		}
	}

	private UICupMatchAccomplishedView m_View;

	private UIModelCupMatch m_Model;

	private int m_CupMatchKey;

	private string m_CupCDNPath;

	private string m_SquadName;

	private string m_CupName;

	private string m_TierLevel;

	private Transform[] m_ProfileContainerList;

	private UICupMatchProfileItemController[] m_ProfileCtrlList;

	private bool m_IsSolo;

	private const float SCREENSHOT_DELAY = 0.5f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(int cupMatchKey)
	{
	}

	public void RefreshTeamView()
	{
	}

	private void OnBtnShareClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
