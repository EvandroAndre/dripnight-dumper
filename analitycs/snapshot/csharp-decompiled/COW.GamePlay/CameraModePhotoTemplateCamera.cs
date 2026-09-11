using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

internal class CameraModePhotoTemplateCamera : FollowCamera
{
	private sealed class AKPMIEGOCDE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public CameraModePhotoTemplateCamera KOKNHFGCGLN;

		public AvatarManager.JEGKOJDIKEL PAJHJBNMLPE;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public AKPMIEGOCDE(int CBPPJACCGOH)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private AvatarManager FFGLNMFFDEC;

	private EPPlayerInfo HECNFLIBJAA;

	private bool ILCFCKOHFFG;

	private Vector3 CDNOJLJHIAL;

	private float OOCFFHNEMBB;

	private float EIMJEDDEGJF;

	private Vector3 JFFDIMBGIOJ;

	private float EPJDPMGFCDF;

	private CameraTemplateData IHOOAOFGLEO;

	public override void OnCameraChanged()
	{
	}

	public override void OnCameraUnLoaded()
	{
	}

	public void SetTemplateParam(CameraTemplateData HDNAALELHPA)
	{
	}

	public void SetTemplateParam(Vector3 HGCKOABADNI, float GGIJOFLMIGA, float BFFMCGMMJPO, float KHOOFONPFAN, bool LAOLIMDDHGD, bool KCJOMFHKCAA, uint NHCHJKFONGK)
	{
	}

	private void FENGNKHDACB()
	{
	}

	public bool IsInFreezePhotoTemplate()
	{
		return false;
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

	private Vector3 AONFFOEFGDM()
	{
		return default(Vector3);
	}

	protected override void AAJBLNPFLOB()
	{
	}

	private void LNBNGDBDGGB(bool EOGOGFLCEHL)
	{
	}

	protected IEnumerator LEFNPPPPNLD(AvatarManager.JEGKOJDIKEL PAJHJBNMLPE)
	{
		return null;
	}

	public void DestroyFreezeTemplateAvatar()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnCameraChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCameraUnLoaded()
	{
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
}
