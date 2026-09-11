using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UIFootballSkillItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public IDCBLNGKFFG type;

		internal bool _003CSetViewData_003Eb__0(CSVBaseData x)
		{
			return false;
		}
	}

	private UIFootballSkillItemView m_View;

	private IDCBLNGKFFG m_SkillType;

	private List<UISprite> m_TeammateList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(IDCBLNGKFFG type, IDCBLNGKFFG selectedType)
	{
	}

	public void OnTypeChanged(object[] data)
	{
	}

	private void OnBackgroundClick()
	{
	}

	private void OnPlayerSkillChanged(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
