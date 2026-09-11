using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMailItemController : UIEasyListItemController
{
	public enum MailType
	{
		NOTICE,
		SYSTEM,
		REPORT
	}

	private UIMailItemView m_View;

	private MailInfo m_Data;

	private ReportMailInfo m_ReportData;

	private new int m_Index;

	private MailType m_MailType;

	private static Color m_ColorLight;

	private static Color m_ColorLightGrey;

	private static Color m_ColorDark;

	private static Color m_ColorSpriteDark;

	private static Color m_ColorSpriteLight;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshMailReadIcon(bool read)
	{
	}

	public bool IsUnRead()
	{
		return false;
	}

	private string RemainigTime(uint time, long expireTime = 0L)
	{
		return null;
	}

	private string RemainigEndTime(uint endTime)
	{
		return null;
	}

	private void _003CSetViewData_003Eb__15_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
