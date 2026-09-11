using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class LevelJumpPad : BaseLevelObject
{
	private sealed class OOKFPPDKJNE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public LevelJumpPad KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public OOKFPPDKJNE(int CBPPJACCGOH)
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

	private sealed class MJICEPELIAF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public LevelJumpPad KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public MJICEPELIAF(int CBPPJACCGOH)
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

	private HENEHAGJCLI LLCCECIFPHN;

	private JGJFDAFCJLL MAOHIOEAMEA;

	private SphereCollider BPDOBCNIHLF;

	private float DHEDNGKDJNG;

	private GameObject DLMFMJMDLFG;

	private uint ADMNBPOILJP;

	public JumpPadModel m_JumpPadModel;

	private GMECHKEDOJP.KLANPAODHHF ONPKCMEMDBA;

	private float AKPNAFOFDDI;

	private bool AHFBCCDFEEK;

	private bool DBJHLADCLGJ;

	public bool LFAODPMKBJG
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool LGOELOAAFIN => false;

	private bool DMFFFCAOJMJ => false;

	public bool KHDPHFONOOG => false;

	public LNHKGDNMBNE EPNKIGKNOGE => LNHKGDNMBNE.EJumpPadEffectActiveState_None;

	public GMECHKEDOJP.KLANPAODHHF ELOGILPBOII => null;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	private void KONPKDOLKFK(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void IJHNGGDGOMG(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	public void SetInitialActive(bool MIBHDOJIHJE)
	{
	}

	private void KKEMIDEBKFA(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void HNBONIKCPNH()
	{
	}

	private void PBNNHENEIHA()
	{
	}

	private void OFCGIGKMOOA()
	{
	}

	private void PEIBJADFBCP()
	{
	}

	private void HKJELGAELEL()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public void Init(string MOFHIAENDJI, ResourceID OCCLMDNGINA)
	{
	}

	public void Init(HENEHAGJCLI DLOMCIHJJJG)
	{
	}

	public bool CheckValid(Vector3 AIFMLGFBPOO)
	{
		return false;
	}

	private JGJFDAFCJLL DBLANOFCDBA(byte CBCAJJJCKLH)
	{
		return JGJFDAFCJLL.ADD;
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public override void OnRecycle()
	{
	}

	private IEnumerator HCFOGODKPIG()
	{
		return null;
	}

	private IEnumerator EAEENEPGAJL()
	{
		return null;
	}

	public GMECHKEDOJP GetGrenadeData()
	{
		return null;
	}

	private void DDBKGHOIPHG()
	{
	}

	private void FBDNBDAGOKN()
	{
	}

	private void FCOGKHGGAGN()
	{
	}

	public ResourceID GetJumpSoundResID()
	{
		return default(ResourceID);
	}

	public void PlayerJump()
	{
	}

	private ResourceID FNMCEKPCLPL()
	{
		return default(ResourceID);
	}

	public ResourceID GetJumpTrailResID()
	{
		return default(ResourceID);
	}

	public Vector3 GetVelocity(Vector3 BMNLHFJNCLK, Vector3 DHBLNMLJGCD)
	{
		return default(Vector3);
	}

	protected override void OnModelShowed()
	{
	}

	private void GGHBJKDGFBE()
	{
	}

	private void BLCBCGJPIND()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public void _003C_003EiFixBaseProxy_OnModelShowed()
	{
	}
}
