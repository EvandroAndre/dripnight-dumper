using UnityEngine;

public class LobbyFogSetting : MonoBehaviour
{
	public bool updateEveryFrame;

	public Color fogColor;

	public bool useCustomStart;

	public float fogStartDistance;

	public float fogEndDistance;

	private bool _fogEnabled;

	private FogMode _fogMode;

	private float _originalStartDistance;

	private float _originalEndDistance;

	private Color _orginalColor;

	private void OnValidate()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}
}
