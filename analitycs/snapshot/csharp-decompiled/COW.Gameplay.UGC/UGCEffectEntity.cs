using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCEffectEntity : MonoBehaviour
{
	private GameObject m_effectObject;

	private UGCEntityRepItem m_entityComm;

	private UGCPresentEffectRepItem m_presentEffectComm;

	private string m_entityID;

	private string TrackEntityID;

	private Vector3 OffsetPosition;

	private Color32 Color;

	private Dictionary<ParticleSystem, float> oriParticleSpeed;

	private Texture mCurrentTex;

	private Renderer[] CacheRenders;

	private static string[] ms_typeid2Name;

	public Transform TrackObject;

	private bool IsChangeColor()
	{
		return false;
	}

	private void OnColorChanged(int valueNew)
	{
	}

	private void ApplyColor()
	{
	}

	public static void ChangeAnyObjectColor(GameObject go, int colorValue)
	{
	}

	private void OnScaleChanged(float valueNew)
	{
	}

	public void OnOffsetChanged(Vector3 valueNew)
	{
	}

	private void OnFollowTargetChanged(string valueNew)
	{
	}

	public void OnEffectTypeChanged(string valueNew)
	{
	}

	private void OnSpeedChanged(int valueNew)
	{
	}

	private void OnTexChanged(string valueNew)
	{
	}

	private void ApplyTexture()
	{
	}

	private void OnRotatorChanged(Vector3 valueNew)
	{
	}

	private void OnScaleVectorChanged(Vector3 valueNew)
	{
	}

	private void OnEnableChanged(bool valueNew)
	{
	}

	private void Update()
	{
	}

	private void UpdatePosition()
	{
	}

	public static UGCEffectEntity Create(string entityID)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
