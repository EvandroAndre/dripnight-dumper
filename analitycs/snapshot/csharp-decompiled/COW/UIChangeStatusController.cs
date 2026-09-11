using GCommon;
using UnityEngine;

namespace COW;

public class UIChangeStatusController : UIBaseController
{
	private UIChangeStatusView m_View;

	private const string DefaultPowerTagDescKey = "T_54_MF_PERK_TIPS";

	private Color NewColor;

	private Color ReworkColor;

	private string m_TagDescKey;

	private string m_PowerTagDescKey;

	private Vector3 m_DefaultPowerIconLocalPosition;

	private bool m_HasCachedDefaultPowerIconLocalPosition;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(uint tagType, string tagDescKey, bool isPower = false, string powerTagDescKey = "T_54_MF_PERK_TIPS")
	{
	}

	private bool IsSkillMightyPowerTagOpen()
	{
		return false;
	}

	public void AdjustPowerIconAnchor(bool isPower, uint tagType)
	{
	}

	private void CacheDefaultPowerIconLocalPosition()
	{
	}

	private void OnTipsClick()
	{
	}

	private void OnPowerTipsClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
