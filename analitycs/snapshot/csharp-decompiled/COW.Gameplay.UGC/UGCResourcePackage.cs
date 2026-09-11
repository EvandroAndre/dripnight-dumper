using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using message;

namespace COW.Gameplay.UGC;

public class UGCResourcePackage
{
	private sealed class _003CCorLoadWebResData_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UGCResourcePackage _003C_003E4__this;

		public string resUUID;

		public Action<OLEDMLOHNFH> callback;

		private OLEDMLOHNFH _003CresItem_003E5__2;

		private UnityWebRequest _003Crequest_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCorLoadWebResData_003Ed__45(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private JBBDIJHHPLK m_data;

	private bool m_isLoading;

	private string m_baseAbUrl;

	private string m_packageUrl;

	private string m_localFilePath;

	private bool m_isCanFreeMemory;

	private static byte[] m_zipMagicNumber;

	public UGCVFSBase VFS;

	public bool IsCanFreeMemory
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsLoading
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string BaseAbUrl
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string PackageUrl
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string LocalFilePath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public JBBDIJHHPLK PackageData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string UUID => null;

	public bool IsUnityAssetBundle => false;

	public bool IsFFBuildinResource => false;

	public bool IsVFSPackage => false;

	public void RemapItemData(JBBDIJHHPLK data)
	{
	}

	public void ReleaseMemoryAndResource()
	{
	}

	public static bool FastCheckIsZipedPackageData(byte[] rawData)
	{
		return false;
	}

	public static JBBDIJHHPLK DecodeData(byte[] rawData)
	{
		return null;
	}

	public void LoadFromData(byte[] dataArray, bool registerToManager)
	{
	}

	public void LoadFromVFSPackage(string localFilePath, bool registerToManager)
	{
	}

	public void LoadFromVFSPackageMemory(byte[] vfsData, bool registerToManager)
	{
	}

	public void LoadFromPackage(JBBDIJHHPLK data, bool registerToManager)
	{
	}

	public void ReloadFromData(byte[] dataArray, bool registerToManager)
	{
	}

	public void AutoMappingABUrl(string abBaseUrl)
	{
	}

	public OLEDMLOHNFH GetResourceItemData(string uuid)
	{
		return null;
	}

	public IEnumerator CorLoadWebResData(string resUUID, Action<OLEDMLOHNFH> callback)
	{
		return null;
	}

	public static bool FromProbufBytes<T>(byte[] dataBytes, out T data, int dataStartIndex = 0, int useDataLength = -1)
	{
		data = default(T);
		return false;
	}

	public static bool ToProtoBufBytes<T>(T data, out byte[] dataBytes)
	{
		dataBytes = null;
		return false;
	}
}
