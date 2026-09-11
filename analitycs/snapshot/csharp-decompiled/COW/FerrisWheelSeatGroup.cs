using GCommon;
using UnityEngine;

namespace COW;

public class FerrisWheelSeatGroup : Entity
{
	private bool m_EnableSeatRota;

	public Transform RotationCenter;

	public FerrisWheelSeat[] Seat;

	public byte GroupID;

	public uint FerrisWheelID;

	private Vector3 oriWorldRota;

	protected override void OnAwake()
	{
	}

	private void LateUpdate()
	{
	}

	public bool CanGetOn()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}
}
