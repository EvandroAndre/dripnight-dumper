using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudShibuya_GP_DoorIconController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UIHudIIVTeleportDoorIconTeammateTag> _003C_003E9__13_0;

		internal int _003CRefreshTagPos_003Eb__13_0(UIHudIIVTeleportDoorIconTeammateTag a, UIHudIIVTeleportDoorIconTeammateTag b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public BHGGAEEHJCO playerID;

		public UIHudShibuya_GP_DoorIconController _003C_003E4__this;

		internal void _003CRefreshTeammateTag_003Eb__0(uint uniqueID, ResourceID vfxResID, GameObject instance)
		{
		}
	}

	private UIHudShibuya_GP_DoorIconView m_View;

	public int EndTime;

	public uint DoorConfigId;

	public uint TargetDoorConfigId;

	public FOGOEBDAGIK Action;

	private MutableString m_CountStr;

	private byte m_CurPlayerTeamId;

	private Dictionary<BHGGAEEHJCO, uint> m_TeammateTag;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(uint doorConfigId, int endTime, uint targetDoorConfigId, FOGOEBDAGIK action)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void RefreshTeammateTag(object[] data)
	{
	}

	private void RefreshTagPos()
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
