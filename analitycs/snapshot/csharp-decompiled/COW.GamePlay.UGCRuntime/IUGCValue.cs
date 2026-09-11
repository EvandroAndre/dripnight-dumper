using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public interface IUGCValue : IUGCObjectPoolItem
{
	void SetBool(bool v);

	bool GetBool();

	void SetInt(int v);

	int GetInt();

	void SetInt64(long v);

	long GetInt64();

	void SetFloat(float v);

	float GetFloat();

	void SetVector2(Vector2 v);

	void SetVector2(float x, float y);

	Vector2 GetVector2();

	void SetVector3(Vector3 v);

	void SetVector3(float x, float y, float z);

	Vector3 GetVector3();

	void SetQuaternion(Quaternion q);

	Quaternion GetQuaternion();

	void SetObj(object v);

	object GetObj();

	object GetValue();

	MHJLOKOOGNB ValueType();
}
