using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudBaseCSRoundResultController : UIBaseController
{
	protected UIModelMatch m_ModelMatch;

	protected List<GameObject> m_BonusItemList;

	protected GameObject bonusItem;

	protected UIGrid bonusGrid;

	protected UILabel LabelReason;

	public void SetBonusDetailsView(FHCKGNCNMCA res)
	{
	}

	protected string GetDescriptionOfBonusType(NALFNCKIBNP bonusType, object[] param)
	{
		return null;
	}

	public void SetRoundWinLoseReason(byte winReason)
	{
	}
}
