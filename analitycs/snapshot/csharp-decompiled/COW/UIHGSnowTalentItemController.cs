using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHGSnowTalentItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private List<UIHGSnowTalentBranchNodeController> m_BranchNodeList;

	private UIHGSnowTalentMainNodeController m_MainNode;

	private UIHGSnowTalentItemView m_View;

	private UIModelHuntingGround m_Model;

	private int m_ItemCount;

	private int m_DataIndex;

	private Dictionary<uint, uint> m_NodeItemPos;

	private List<UIHGSnowTalentItemLineAnimView> m_LineAnimList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void GetGuideItem(out UIWidget guideWidge, out UIButton guideBtn)
	{
		guideWidge = null;
		guideBtn = null;
	}

	private void ResetNodeLine()
	{
	}

	private void ResetNodeLineAnim(UIHGSnowTalentItemLineAnimParam param)
	{
	}

	private void UnlockLineByPos(UIHGSnowTalentItemLineAnimParam param, bool isPlayAnim)
	{
	}

	private void ShowNodeLine()
	{
	}

	private void CreateBranchNode(Transform parent, uint talentId)
	{
	}

	private UIHGSnowTalentMainNodeController CreateMainNode(Transform parent, uint talentId)
	{
		return null;
	}

	private void UnlockLine(uint talentId, bool isPlayAnim)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
