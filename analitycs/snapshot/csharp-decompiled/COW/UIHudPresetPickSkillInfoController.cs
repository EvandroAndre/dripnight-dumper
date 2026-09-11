using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudPresetPickSkillInfoController : UIBaseController
{
	private UIHudPresetPickSkillInfoView m_View;

	private List<Transform> m_SkillItemPosList;

	private List<UIHudPresetPickSkillItemController> m_SkillItemCtrlList;

	private UIHudPresetPickSkillItemController m_PetSkillItemCtrl;

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

	public void SetEmptyView()
	{
	}

	public void SetViewData(BHGGAEEHJCO playerID)
	{
	}

	public void SetViewData(EADOMEKFHBE presetInfo)
	{
	}

	public void InitSkillCtrls()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
