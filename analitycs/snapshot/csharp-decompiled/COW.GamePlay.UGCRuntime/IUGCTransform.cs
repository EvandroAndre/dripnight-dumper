using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public interface IUGCTransform
{
	void SetPosition(Vector3 position);

	Vector3 GetPosition();

	Vector3 GetEulerRotation();
}
