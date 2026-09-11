using UnityEngine;

public class AvatarExtraAmbient : MonoBehaviour
{
	public enum Part
	{
		Cloth,
		Skin
	}

	public Part part;

	public float ambient;

	private void OnEnable()
	{
	}

	private void OnValidate()
	{
	}

	private void ApplyAmbient()
	{
	}
}
