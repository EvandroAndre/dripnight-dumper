using UnityEngine;

namespace COW.GamePlay;

internal class UGCThirdPersonCamera : FollowCamera, COW.GamePlay.CALHLIPMGMD<UGCCameraConfigRepItem>
{
	private readonly CKIFHNOIGJM KNBPCFLHANH;

	private bool _003CINLCOLLPEEL_003Ek__BackingField;

	public override Vector3 FNAMPFFAMBD => default(Vector3);

	public override Quaternion DEIEGHLADGP => default(Quaternion);

	public bool CGENDOEIKDN
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override float GetFovNormal()
	{
		return 0f;
	}

	protected override Quaternion BAEGCHLNCDD()
	{
		return default(Quaternion);
	}

	protected override float BBHBLKMMLKK(Player PGEGMKJKOKI)
	{
		return 0f;
	}

	protected override float GBAEBHHKPMI(Player PGEGMKJKOKI, Vector3 AIFMLGFBPOO, Vector3 JNINPJDKGNA)
	{
		return 0f;
	}

	protected override float KIPEIJMCALI(Player PGEGMKJKOKI)
	{
		return 0f;
	}

	protected override void AAJBLNPFLOB()
	{
	}

	public override void RefreshState(UGCCameraConfigRepItem ICDHKINICGE)
	{
	}

	public new void InitManually(KMBEHIGOKNF LAIDKEINKFG, float FFADCBDFANJ, float HMCHAKDHAKE, float GOKHJBJHCLK, float CGGPBJKCDEG, Vector3 DFNHOKCIIJK, NHMBEJGPEMP CJPNFPLEDPA, CIDCDEOCLBA OAGMEDEPKML, FDACAOPGNJK FPJMDJMMDBL)
	{
	}

	public new void UninitManually()
	{
	}

	public float _003C_003EiFixBaseProxy_GetFovNormal()
	{
		return 0f;
	}

	public new Vector3 _003C_003EiFixBaseProxy_get_TransTargetPos()
	{
		return default(Vector3);
	}

	public new Quaternion _003C_003EiFixBaseProxy_get_TransTargetRot()
	{
		return default(Quaternion);
	}

	public Quaternion _003C_003EiFixBaseProxy_BAEGCHLNCDD()
	{
		return default(Quaternion);
	}

	public float _003C_003EiFixBaseProxy_BBHBLKMMLKK(Player P0)
	{
		return 0f;
	}

	public float _003C_003EiFixBaseProxy_GBAEBHHKPMI(Player P0, Vector3 P1, Vector3 P2)
	{
		return 0f;
	}

	public float _003C_003EiFixBaseProxy_KIPEIJMCALI(Player P0)
	{
		return 0f;
	}

	public new void _003C_003EiFixBaseProxy_AAJBLNPFLOB()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshState(UGCCameraConfigRepItem P0)
	{
	}
}
