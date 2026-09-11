using UnityEngine;

namespace COW.GamePlay;

internal class GBGPFootballSpeedVFXAnimationController : MonoBehaviour
{
	private enum EKDFIELPHBF
	{
		Static,
		LowSpeed,
		HighSpeed
	}

	private const string KDPHPIJCDBH = "VFX_GB_GP_Soccer_Rolling_speed01_start";

	private const string FCBIOEAMNPN = "VFX_GB_GP_Soccer_Rolling_speed01_end";

	private const string MKIIOOMBBLE = "VFX_GB_GP_Soccer_Rolling_speed02_start";

	private const string HLLJDCDEFMN = "VFX_GB_GP_Soccer_Rolling_speed02_end";

	private const string LKFHONEIEMA = "VFX_GB_GP_Soccer_Rolling_speed02To01";

	private const string IPAHDBDFIJL = "VFX_GB_GP_Soccer_Rolling_speed01To02";

	public GameObject VFXNode_1;

	public GameObject VFXNode_2;

	public Animation VFXAnimation;

	private EKDFIELPHBF JOOENGNHJMD;

	public void Init()
	{
	}

	public void SetSpeed(float EKLIPILNCBM)
	{
	}
}
