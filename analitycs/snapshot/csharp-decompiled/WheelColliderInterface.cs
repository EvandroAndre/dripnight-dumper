using UnityEngine;

public interface WheelColliderInterface
{
	bool IsGrounded { get; }

	void AttachWheelModel(Transform wheelModel);

	WheelHit UpdateGrounded();

	void ClearTorque();
}
