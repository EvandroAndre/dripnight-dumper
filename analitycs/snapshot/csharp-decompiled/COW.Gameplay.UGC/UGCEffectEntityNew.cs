using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCEffectEntityNew : MonoBehaviour, HDIAOJDIPII
{
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public UGCEffectEntityNew _003C_003E4__this;

		public string valueNew;

		internal void _003COnTexChanged_003Eb__0(bool succ, bool isReloaded, Texture2D tex)
		{
		}
	}

	private GameObject m_effectObject;

	private UGCEntityRepItem m_entityComm;

	private UGCEffectEntityRepItem m_EffectEntityRep;

	private UGCTransformRepItem m_TransRep;

	private UGCPlayableRepItem m_PlayableRep;

	private UGCVisibilityRepItem m_VisibilityRep;

	private UGCLoopableRepItem m_LoopableRep;

	private string TrackEntityID;

	private Vector3 OffsetPosition;

	private Color32 Color;

	private Dictionary<ParticleSystem, float> oriParticleSpeed;

	private Dictionary<ParticleSystem, bool> oriParticleLoop;

	private List<ParticleSystem> m_Particles;

	private Texture2D mCurrentTex;

	private Renderer[] CacheRenders;

	private FJEEGHOAKOG CurrentUGCGame => null;

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

	public void OnLocalPosChanged(Vector3 valueNew)
	{
	}

	public void OnParentChange(string parentEntityID)
	{
	}

	public void OnVisibleChange(bool valueNew)
	{
	}

	public void OnCameraCullingMaskChanged()
	{
	}

	public void OnVisibilityLayerChange(int valueNew)
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

	private void OnRotatorChanged(Quaternion valueNew)
	{
	}

	private void OnScaleVectorChanged(Vector3 valueNew)
	{
	}

	private void OnEnableChanged(bool valueNew)
	{
	}

	private void OnLoopTypeChange(int value)
	{
	}

	private void OnPlayingChange(bool value)
	{
	}

	private void OnFlagChange(int value)
	{
	}

	public static UGCEffectEntityNew Create(string entityID)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
