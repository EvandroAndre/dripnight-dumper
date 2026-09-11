using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityADContentController : UIActivityContentController
{
	public class Data
	{
		public uint id;

		public uint groupId;

		public string url;

		public uint goPos;

		public string subGoPos;

		public bool prefersExternal;

		public bool enableGotoButton;

		public bool isAnnouncement;

		public uint NetworkTextureEndTime;
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public ActivityGroupDesc groupDesc;

		internal bool _003CSetData_003Eb__1(AdvertDesc e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public ActivityRowDesc activityRow;

		public UIActivityADContentController _003C_003E4__this;

		internal void _003CSetGotoRow_003Eb__0()
		{
		}
	}

	private UIActivityADContentView m_View;

	private Data m_Data;

	private UIModelActivity m_ModelActivity;

	private List<GameObject> mRowList;

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

	private void SetGotoRow(ClientActivityDesc desc)
	{
	}

	private void OnGoToClick()
	{
	}

	private void SendBannerClickLog(uint id)
	{
	}

	public override void Reload()
	{
	}

	private void _003COnUIInit_003Eb__5_0(GameObject e)
	{
	}

	private void _003CSetData_003Eb__6_0()
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
