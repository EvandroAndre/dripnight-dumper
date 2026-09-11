using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudIIVTeleportDoorIcon : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UIHudIIVTeleportDoorIconTeammateTag> _003C_003E9__17_0;

		internal int _003CRefreshTagPos_003Eb__17_0(UIHudIIVTeleportDoorIconTeammateTag a, UIHudIIVTeleportDoorIconTeammateTag b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public BHGGAEEHJCO playerID;

		public UIHudIIVTeleportDoorIcon _003C_003E4__this;

		internal void _003CRefreshTeammateTag_003Eb__0(uint uniqueID, ResourceID vfxResID, GameObject instance)
		{
		}
	}

	public UILabel TimeLabel;

	public GameObject Countdown;

	public UIGrid TagGrid;

	public UILabel Destination;

	public int EndTime;

	public uint DoorConfigId;

	public uint TargetDoorConfigId;

	public FOGOEBDAGIK Action;

	private MutableString m_CountStr;

	private byte m_CurPlayerTeamId;

	private Dictionary<BHGGAEEHJCO, uint> m_TeammateTag;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void SetData(uint doorConfigId, int endTime, uint targetDoorConfigId, FOGOEBDAGIK action)
	{
	}

	private void RefreshTeammateTag(object[] data)
	{
	}

	private void RefreshTagPos()
	{
	}
}
