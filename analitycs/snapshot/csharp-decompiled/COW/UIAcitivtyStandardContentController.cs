using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIAcitivtyStandardContentController : UIActivityContentController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ClientActivityDesc> _003C_003E9__7_0;

		public static Comparison<ClientActivityDesc> _003C_003E9__7_1;

		public static Comparison<ClientActivityDesc> _003C_003E9__7_2;

		internal int _003CCreateEventDescList_003Eb__7_0(ClientActivityDesc x, ClientActivityDesc y)
		{
			return 0;
		}

		internal int _003CCreateEventDescList_003Eb__7_1(ClientActivityDesc x, ClientActivityDesc y)
		{
			return 0;
		}

		internal int _003CCreateEventDescList_003Eb__7_2(ClientActivityDesc x, ClientActivityDesc y)
		{
			return 0;
		}
	}

	private UIActivityStandardContentView m_View;

	private UIModelActivity m_ModelActivity;

	private List<ClientActivityDesc> m_Descs;

	private List<ActivityAwardDescription> m_AwardDescUIs;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetData(object data)
	{
	}

	private void CreateEventDescList()
	{
	}

	private ActivityAwardDescription CreateEventDesc(ClientActivityDesc desc)
	{
		return null;
	}

	public override void Reload()
	{
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
