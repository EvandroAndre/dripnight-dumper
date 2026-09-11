using COW.GamePlay;
using UnityEngine;

namespace COW;

public class LevelFerrisWheel : BaseLevelObject
{
	public enum ELevelFerrisWheelAction
	{
		SYNC_ANGLE,
		GET_ON,
		GET_OFF
	}

	private class ShadowState : ShadowStateBase
	{
		public float CurAngle;

		public float NextAngle;
	}

	public FerrisWheelSeatGroup[] SeatGroup;

	public Transform RotationCenter;

	public Rigidbody RotationCenterRigidbody;

	public Transform GetOffPos;

	public float Radius;

	public float RotaSpeed;

	private ShadowState m_ShadowState;

	protected uint m_LastValidTickCount;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	public override void OnFixedUpdate(float gameTime, float deltaTime)
	{
	}

	private void UpdateRotationAngle(float newVal, uint tickCount)
	{
	}

	public override void ResetForInGameReload()
	{
	}

	public void OnPlayerGetOn(BHGGAEEHJCO pID, byte seatGroup, byte seatIndex)
	{
	}

	public void OnPlayerGetOff(byte seatGroup, byte seatIndex)
	{
	}

	private FerrisWheelSeat GetPlayerMountSeat(byte groupID, byte seatInx)
	{
		return null;
	}

	public override void SyncAction(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ResetForInGameReload()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
