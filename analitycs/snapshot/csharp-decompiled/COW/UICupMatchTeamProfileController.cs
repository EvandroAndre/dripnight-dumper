using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UICupMatchTeamProfileController : UIBaseController
{
	public class InfoEasyListFactory : IEasyList
	{
		private UICupMatchTeamProfileController teamProfile;

		public bool ShowPresence;

		public bool ShowPopupMenu;

		public int CupMatchKey;

		public InfoEasyListFactory(UICupMatchTeamProfileController teamProfile)
		{
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	public UICupMatchTeamProfileView m_View;

	protected InfoEasyListFactory m_InfoEasyListFactory;

	protected UICupMatchTeamOverviewController m_TeamOverviewUI;

	protected int m_CupMatchKey;

	protected Vector3 m_RecruitBtnInitPos;

	public static ResourceID UIResource()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public T OpenChild<T>(Transform parent) where T : UIBaseController
	{
		return null;
	}

	protected Bounds CalcPriceContainerBounds(Transform priceContainer)
	{
		return default(Bounds);
	}

	protected void UpdateRecruitPostion(List<UIModelCupMatch.AccountInfoBasicWithCupInfo> list)
	{
	}

	public void UpdateTeamMemberView(CupTeamInfo teamInfo, List<UIModelCupMatch.AccountInfoBasicWithCupInfo> members, bool sortPresence = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
