using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityInteractionContentController : UIActivityContentController
{
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public ActivityInteractionDesc interactionDesc;

		public UIActivityInteractionContentController _003C_003E4__this;

		public UIButton goPosButton;

		internal void _003CCreateGoPosEvent_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_1
	{
		public uint goPos;

		public _003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals1;

		internal void _003CCreateGoPosEvent_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public ActivityGroupDesc groupDesc;

		internal bool _003CSetData_003Eb__1(AdvertDesc e)
		{
			return false;
		}
	}

	private UIActivityInteractionContentView m_View;

	private UIModelActivity m_ModelActivity;

	private List<ActivityInteractionDesc> interactionDescs;

	private uint goPos;

	private string subGoPos;

	private EEventType m_EventType;

	private uint m_ActivityId;

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

	private void CreateInteractionCompotent()
	{
	}

	private void OnGoToClick(GameObject go)
	{
	}

	private void CreateGoPosButton(ActivityInteractionDesc interactionDesc)
	{
	}

	private void CreateGoPosEvent(ActivityInteractionDesc interactionDesc, UIButton goPosButton)
	{
	}

	private void _003CSetData_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}
}
