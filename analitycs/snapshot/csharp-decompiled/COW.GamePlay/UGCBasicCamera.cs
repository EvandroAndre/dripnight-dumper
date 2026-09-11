using COW.Gameplay.UGC;
using UnityEngine;

namespace COW.GamePlay;

internal class UGCBasicCamera : CameraControllerBase, COW.GamePlay.CALHLIPMGMD<UGCBasicCameraEntity>
{
	private readonly CKIFHNOIGJM KNBPCFLHANH;

	private UGCBasicCameraEntity HABGFIGBKNN;

	public override Vector3 FNAMPFFAMBD => default(Vector3);

	public override Quaternion DEIEGHLADGP => default(Quaternion);

	protected override void AAJBLNPFLOB()
	{
	}

	public override void OnCameraChanged()
	{
	}

	public bool InTransition()
	{
		return false;
	}

	void COW.GamePlay.CALHLIPMGMD<UGCBasicCameraEntity>.InitManually(KMBEHIGOKNF LAIDKEINKFG, float FFADCBDFANJ, float HMCHAKDHAKE, float GOKHJBJHCLK, float CGGPBJKCDEG, Vector3 DFNHOKCIIJK, NHMBEJGPEMP CJPNFPLEDPA, CIDCDEOCLBA OAGMEDEPKML, FDACAOPGNJK FPJMDJMMDBL)
	{
	}

	void COW.GamePlay.CALHLIPMGMD<UGCBasicCameraEntity>.UninitManually()
	{
	}

	void COW.GamePlay.CALHLIPMGMD<UGCBasicCameraEntity>.RefreshState(UGCBasicCameraEntity ICDHKINICGE)
	{
	}

	public void _003C_003EiFixBaseProxy_AAJBLNPFLOB()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCameraChanged()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_get_TransTargetPos()
	{
		return default(Vector3);
	}

	public Quaternion _003C_003EiFixBaseProxy_get_TransTargetRot()
	{
		return default(Quaternion);
	}
}
