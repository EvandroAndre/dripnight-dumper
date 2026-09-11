using COW.GamePlay;
using UnityEngine;

namespace COW;

internal interface IGrenadeLikeHintObject
{
	UIHudGrenadeHintController.HintType GetHintType();

	BHGGAEEHJCO GetOwnerPlayerID();

	Vector3 GetPosition();

	float GetWarningRange();
}
