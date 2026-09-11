using UnityEngine;

namespace COW;

public interface IThrowSkillLine
{
	bool ShowThrowSkillLine();

	bool CheckHitObject();

	Vector3 GetThrowPositionForDrawingLine();

	Vector3 GetThrowVelocity();

	float GetMaxDistance();
}
