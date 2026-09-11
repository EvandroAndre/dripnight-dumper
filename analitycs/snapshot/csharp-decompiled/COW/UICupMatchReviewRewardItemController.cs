using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UICupMatchReviewRewardItemController : UIBaseController
{
	private UICupMatchReviewRewardItemView m_View;

	private CupChestDesc m_AwardData;

	private bool m_IsLeft;

	private List<GameObject> LevelList;

	private List<GameObject> LeftRewardList;

	private List<GameObject> RightRewardList;

	private UIModelCupMatch m_ModelCupMatch;

	private int m_CupMatchKey;

	private Color m_BGColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(CupChestDesc data, bool isLeft, int key)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshRewardList()
	{
	}

	private void UpdateBGColor()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
