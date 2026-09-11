using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.Gameplay;

public class LevelObjectColorCube : BaseLevelObject, IReusableObjectOwner
{
	private class LevelObjectColorConfig
	{
		public float RotationSpeedBegin;

		public float CubeSpeedDecimal;

		public string VFX;

		public string VFXDAY;

		private float _003CRotationPeriod_003Ek__BackingField;

		private ResourceID _003CVFXResource_003Ek__BackingField;

		public float RotationPeriod
		{
			get
			{
				return _003CRotationPeriod_003Ek__BackingField;
			}
			set
			{
				_003CRotationPeriod_003Ek__BackingField = value;
			}
		}

		public ResourceID VFXResource
		{
			get
			{
				return _003CVFXResource_003Ek__BackingField;
			}
			set
			{
				_003CVFXResource_003Ek__BackingField = value;
			}
		}

		public void Init(int curDay = 1)
		{
		}
	}

	private LevelObjectColorConfig config;

	private GameObject m_model;

	private GameObject m_model_vfx_root;

	private uint m_loadModelTicket;

	private uint m_loadVFXTicket;

	private CommonParticleEffect m_onceVfx;

	protected override string GetObjectTag()
	{
		return null;
	}

	public override void SyncAction(object[] param)
	{
	}

	private void LoadModel()
	{
	}

	private void OnModelLoaded(uint ticket, bool success, Object obj)
	{
	}

	private void LoadVFX()
	{
	}

	public void PlayOnceVFX()
	{
	}

	private void OnVFXLoaded(uint ticket, bool success, Object obj)
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	protected override void OnOnDestroy()
	{
	}

	private void CancelLoad(ref uint ticket)
	{
	}

	public void OnReusableObjectRecycled(ResourceID rID, GameObject obj)
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
