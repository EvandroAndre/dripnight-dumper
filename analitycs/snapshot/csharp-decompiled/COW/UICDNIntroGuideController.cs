using System;
using GCommon;
using proto;

namespace COW;

public class UICDNIntroGuideController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public uint gopos;

		public WorkshopEditorChoiceDesc desc;

		public UICDNIntroGuideController _003C_003E4__this;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private UICDNIntroGuideView m_View;

	private Action gotoAction;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(WorkshopEditorChoiceDesc desc, WorkshopBannerPopup config)
	{
	}

	private void OnClickGotoButton()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
