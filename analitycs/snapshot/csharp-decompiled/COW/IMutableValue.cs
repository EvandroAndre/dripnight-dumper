using UnityEngine;

namespace COW;

public interface IMutableValue
{
	EUGCMutableValueType GetValueType();

	void SetValue(bool value);

	void SetValue(int value);

	void SetValue(long value);

	void SetValue(float value);

	void SetValue(string value);

	void SetValue(Vector2 value);

	void SetValue(Vector3 value);

	void SetValue(Quaternion value);
}
