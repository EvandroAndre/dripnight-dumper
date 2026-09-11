using GCommon;
using UnityEngine;

namespace COW;

public class UINinthSYSGameplaySkillTipsController : UIPopupWindowController
{
	private UINinthSYSGameplaySkillTipsView m_View;

	private UIRoot m_UIRoot;

	private const float m_HeightSpace = 40f;

	private const float m_WidthSpace = 40f;

	private UIModelNinthSYS.INinthSYSGamePlayContext m_Context;

	private uint m_TabType;

	private UIModelBigEvent m_ModelBigEvent;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void SetViewData(Vector3 itemPos, UIModelNinthSYS.INinthSYSGamePlayContext context, uint tabType, uint cdnid, string desc)
	{
	}

	private void OnClickGoposBtn()
	{
	}

	private void SetPosition(Vector3 itemPos)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
