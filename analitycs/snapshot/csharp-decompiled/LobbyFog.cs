using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyFog : MonoBehaviour
{
	protected static int _FogColor1;

	protected static int _FogColor2;

	protected static int _FogColor3;

	protected static int _FogColor4;

	protected static int _FogLerp1234;

	protected static int _FogLerp23StartEnd;

	protected static int _FogCenter;

	protected static int _FogEllipse;

	public Color color1;

	public Vector2 lerp12;

	public Color color2;

	public Vector2 lerp23;

	public Color color3;

	public Vector2 lerp34;

	public Color color4;

	public Vector2 startEnd;

	protected Vector4 mLerp1234;

	protected Vector4 mLerp23StartEnd;

	public Vector4 center;

	public Vector4 ellipse;

	protected Vector4 mEllipse;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSceneChange(Scene scene1, Scene scene2)
	{
	}

	private void ResetUnityFog()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	protected void UpdateProps()
	{
	}
}
