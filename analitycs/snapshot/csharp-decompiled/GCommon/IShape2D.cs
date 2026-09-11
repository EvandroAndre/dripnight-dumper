using UnityEngine;

namespace GCommon;

public interface IShape2D
{
	Vector3 GetPosition();

	Vector3 GetCenter();

	Vector3 GetSize();

	bool IsPointInside(Vector3 v, float margin = 0f);

	Vector3 GetRandomPoint(float margin = 0f);

	Vector3 ClampPoint(Vector3 v, float margin = 0f);
}
