using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPetSkillGridController : UIBaseController, IEasyList
{
	private const int ALL_GRID_COLUMN = 1;

	private UIPetSkillScrollViewView m_View;

	private UIPetSkillItemController m_CurrentSkillItemCtrl;

	private List<PetSkillConfigInfo> m_NeedShowConfigList;

	private uint m_CurrentSelectedSkillID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetSelectedSkillInfo(List<PetSkillConfigInfo> dataShowList)
	{
	}

	private void ShowSkillList()
	{
	}

	private void ShowSelectSkillList(object[] param)
	{
	}

	public void ShowCurrentSelectedSkill(PetSkillConfigInfo data)
	{
	}

	public void OnClickMask()
	{
	}

	public void ShowNoItemTips(bool isUnlock)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
