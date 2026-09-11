using UnityEngine;

namespace COW;

public class GyroCameraController : MonoBehaviour
{
	public enum ESwingType
	{
		Smooth,
		Abrupt
	}

	private const string GyroSettingKey = "GyroSetting_{0}";

	private Camera cam1;

	private Camera cam2;

	private float vertRotateRateScale;

	private float horiRotateRateScale;

	private bool restoreCamera;

	private float cameraRestoreRate;

	private bool restoreSwingPivot;

	private float swingPivotRestoreRate;

	private bool restoreTexture;

	private float textureRestoreRate;

	private float maxRotateAngleXSwingPlus;

	private float maxRotateAngleYSwingPlus;

	private MeshRenderer[] meshRenderers;

	private float materialSpeed;

	private GameObject[] SwingPivots;

	private ESwingType swingType;

	private GyroStandard gyroStandard;

	private Material[] mats;

	private Quaternion initRotationCam1;

	private Quaternion initRotationCam2;

	private Quaternion[] initRotationSwings;

	private int m_matoffsetXID;

	private int m_matoffsetYID;

	private float maxRotateAngleX;

	private float maxRotateAngleY;

	private float offsetX;

	private float offsetY;

	private float vertRotateRate;

	private float horiRotateRate;

	private bool m_GyroEnabled;

	private bool m_Inited;

	public float VertRotateRateScale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float HoriRotateRateScale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool RestoreCamera
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float CameraRestoreRate
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool RestoreSwingPivot
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float SwingPivotRestoreRate
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool RestoreTexture
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float TextureRestoreRate
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float MaxRotateAngleXSwingPlus
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float MaxRotateAngleYSwingPlus
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float MaterialSpeed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public ESwingType SwingType
	{
		get
		{
			return ESwingType.Smooth;
		}
		set
		{
		}
	}

	public float GyroStandardWidth
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float GyroStandardHeight
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool Inited => false;

	private void Update()
	{
	}

	public void Init(Camera c1, Camera c2 = null)
	{
	}

	private void ApplyGyroStandard()
	{
	}

	private void CameraRotateControl()
	{
	}

	public void PauseGyroCam()
	{
	}

	public void ResumeGyroCam(Camera c1, Camera c2 = null)
	{
	}

	private void ResumeGyroCam()
	{
	}

	public void ResetCamRotation()
	{
	}

	public void ResetGyroStandard()
	{
	}
}
