using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class DENKLLOGEHJ : MatchGame
{
	private sealed class CALJHPAFEHO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public DENKLLOGEHJ KOKNHFGCGLN;

		private IEnumerator LKACOAHEDDC;

		private bool DEOGDCLIIMH;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public CALJHPAFEHO(int CBPPJACCGOH)
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

	private sealed class MHCNLNFALPD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public DENKLLOGEHJ KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public MHCNLNFALPD(int CBPPJACCGOH)
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

	public static ResourceID[] CGAHLJKNFAD;

	public static string OOEBEKKJLJA;

	protected LLIBLINGFLO BJABFABBHNB;

	private Stack<IEnumerator> ILGOCGEBPFC;

	private FTimer AHPPPIDDLEH;

	private IEnumerator BNKLIOKCNEN;

	public static int ELHIAPCAHKM;

	public override ResourceID[] GetResourceID()
	{
		return null;
	}

	public override string GetSceneName()
	{
		return null;
	}

	public override bool IsOnlineGame()
	{
		return false;
	}

	public override LoadingProcess[] GetLoadingProcesses()
	{
		return null;
	}

	public LLIBLINGFLO BKPCNDMEHIG()
	{
		return null;
	}

	protected override void OnSceneLoaded()
	{
	}

	public bool JFOFPGIKDPK(UIModelUGCResourceSelect.ETableType JPJBLAMLPHI, string GGMIDNEJGNO)
	{
		return false;
	}

	public IEnumerator CNKAGLMKFHP()
	{
		return null;
	}

	private IEnumerator MDIDAHKFPFB()
	{
		return null;
	}

	protected virtual void GCLGIKFHIFH()
	{
	}

	private Vector3 AFBOGGPCLBH()
	{
		return default(Vector3);
	}

	protected virtual void GHNMGMCJFEH()
	{
	}

	public Vector3 HPKGPHFCFCP(uint LIKPJDHGPFG)
	{
		return default(Vector3);
	}

	protected override void OnFixedUpdate()
	{
	}

	protected override void OnUpdate()
	{
	}

	public override int GetGameType()
	{
		return 0;
	}

	public void HMPGBEPMMKM(int PNLDKNOFPNG)
	{
	}

	public void BKKKEKJDBPE(int GNLIAKMGDDG)
	{
	}

	public void PGHFGEGNPLC(Vector3 IGDHIDGLOKG, uint HIDANNMJCDP, int PNLDKNOFPNG)
	{
	}

	public Vector3 DHMLOFBCIBB(Vector3 HDFILHFDBKB)
	{
		return default(Vector3);
	}

	public override void OnLoadingSceneFailed()
	{
	}

	public override void PauseGame(bool FKJMCGEFJMD)
	{
	}

	public override bool NeedPreloadBeforeLoadScene()
	{
		return false;
	}

	protected override void OnPreloadLoaded()
	{
	}

	public override bool IsGamePaused()
	{
		return false;
	}

	protected override void OnInputUpdate()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdate()
	{
	}

	public string _003C_003EiFixBaseProxy_GetSceneName()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_IsOnlineGame()
	{
		return false;
	}

	public LoadingProcess[] _003C_003EiFixBaseProxy_GetLoadingProcesses()
	{
		return null;
	}

	public int _003C_003EiFixBaseProxy_GetGameType()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnLoadingSceneFailed()
	{
	}

	public void _003C_003EiFixBaseProxy_PauseGame(bool P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedPreloadBeforeLoadScene()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnPreloadLoaded()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsGamePaused()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnInputUpdate()
	{
	}
}
