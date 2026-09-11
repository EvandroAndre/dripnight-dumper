using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIActivityFestivalContentController : UIActivityContentController
{
	private enum OperateStatus
	{
		None,
		GoTo,
		UnFinished,
		Available,
		Received
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__15_1;

		internal BaseItemInfo _003COnOperate_003Eb__15_1(AwardDesc e)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public UIActivityFestivalContentController _003C_003E4__this;

		public ClientActivityDesc activity;

		public EventDelegate.Callback _003C_003E9__0;

		internal void _003CCreateAwardList_003Eb__0()
		{
		}
	}

	private UIActivityFestivalContentView m_View;

	private UIModelActivity m_ModelActivity;

	private uint m_SelectAwardActivityId;

	private OperateStatus m_OperateStatus;

	private List<ClientActivityDesc> m_ActivityDescs;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static ResourceID GetVFXResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetData(object data)
	{
	}

	private void CreateActivityList()
	{
	}

	private void CreateAwardList(ClientActivityDesc activity, UIScrollView AwardScrollView, UIGrid AwardGrid, UIToggleButton selectButton)
	{
	}

	private void SetOperationTips()
	{
	}

	private void SetOperateButtonUI()
	{
	}

	private bool HasReceived()
	{
		return false;
	}

	private void OnOperate()
	{
	}

	public override void Reload()
	{
	}

	private bool _003COnOperate_003Eb__15_0(ClientActivityDesc e)
	{
		return false;
	}

	private void _003COnOperate_003Eb__15_2()
	{
	}

	private bool _003COnOperate_003Eb__15_3(ClientActivityDesc e)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
