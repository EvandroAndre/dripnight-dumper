using System.Collections.Generic;
using COW;
using UnityEngine;

public class GyroVFXController : MonoBehaviour
{
	public float lerpSharpness;

	public float offsetX;

	public float offsetY;

	public bool useRotation;

	public float rotationSpeed;

	public bool usePosition;

	public bool useSwingPos;

	public float positionSpeedX;

	public float positionSpeedY;

	public float posSpringSharpness;

	private Vector3 positionTemp;

	public bool useAnim;

	public bool useSwingAnim;

	public bool animByHorizontal;

	public float animSpeed;

	public float animDefaultSampleTime;

	private float curAnimSampleTime;

	public float animSpringSharpness;

	public Animation anim;

	public bool useAlpha;

	public float alphaSpeedX;

	public float alphaSpeedY;

	private float alphaTemp;

	public List<Renderer> rendererList;

	public List<AnimatedAlpha> animatedAlphaList;

	public bool useTrigger;

	public float triggerRange;

	public float triggerTime;

	private float triggerTimer;

	public Animator triggerAnimator;

	private bool triggerActived;

	private bool triggerActivedTemp;

	private Vector2 ratio;

	private Vector2 deltaRatio;

	private MaterialPropertyBlock mpb;

	private int _ColorAlphaBrightnessContrast_ID;

	private bool m_Inited;

	private bool m_GyroEnabled;

	private LobbyWeatherEffectController.MainColor m_MainColor;

	private LobbyWeatherEffectController m_LobbyWeatherEffectController;

	public bool controlAvatar;

	private UIAvatarWindowController m_AvatarWindowCtrl;

	private UIAvatarWindowController AvatarWindowCtrl => null;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}

	private Vector3 CalcPosByMappingCamera(Camera originCam, Camera mappingCam, Vector3 originPos, Vector3 currentPos, Vector3 mappingOffset, float lerpVal)
	{
		return default(Vector3);
	}

	public void ResetGyro()
	{
	}

	private void OnDisable()
	{
	}

	private void ResumeGyroCam()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public Vector3 GetAvatarPosByMappingGyroOffset(Vector3 originPos)
	{
		return default(Vector3);
	}
}
