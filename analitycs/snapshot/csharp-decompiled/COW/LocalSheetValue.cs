using System;
using System.Collections.Generic;

namespace COW;

[Serializable]
public class LocalSheetValue
{
	public long TypeID;

	public bool BoolValue;

	public int IntValue;

	public float FloatValue;

	public string StringValue;

	public LocalVector2 Vector2Value;

	public LocalVector3 Vector3Value;

	public LocalQuaternion QuaternionValue;

	public List<LocalSheetValue> ListData;

	public long Int64Value;
}
