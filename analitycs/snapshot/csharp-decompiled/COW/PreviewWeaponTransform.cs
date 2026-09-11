using UnityEngine;

namespace COW;

public class PreviewWeaponTransform : MonoBehaviour
{
	public enum WeaponPreviewType
	{
		None,
		Blade,
		Scabbard
	}

	public Vector3 localPos;

	public Vector3 localScale;

	public Vector3 localQuaternion;

	public Vector3 localQuaternionForMax;

	public WeaponPreviewType previewType;
}
