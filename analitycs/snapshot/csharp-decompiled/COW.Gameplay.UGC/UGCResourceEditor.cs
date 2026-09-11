using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using message;

namespace COW.Gameplay.UGC;

public class UGCResourceEditor
{
	private sealed class _003CGetPackageItemEnumerator_003Ed__35 : IEnumerable<OLEDMLOHNFH>, IEnumerable, IEnumerator<OLEDMLOHNFH>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private OLEDMLOHNFH _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public UGCResourceEditor _003C_003E4__this;

		private int _003Ci_003E5__2;

		OLEDMLOHNFH IEnumerator<OLEDMLOHNFH>.Current => null;

		object IEnumerator.Current => null;

		public _003CGetPackageItemEnumerator_003Ed__35(int _003C_003E1__state)
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

		IEnumerator<OLEDMLOHNFH> IEnumerable<OLEDMLOHNFH>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public static string S_PrefixAutoNPCPath;

	private UGCResourcePackage m_package;

	private UGCResourcePackage m_packageResName;

	private static UGCResourceEditor ms_simulate;

	private byte[] m_magicVersion;

	private JBBDIJHHPLK NormalResPackageData => null;

	private JBBDIJHHPLK ResNamePackageData => null;

	public static UGCResourceEditor TryGet()
	{
		return null;
	}

	public bool LoadProject(byte[] projectDataBytes, MFDKDILMLFP version, EditorEntityData editorEntityData)
	{
		return false;
	}

	public bool UnloadProject()
	{
		return false;
	}

	private void saveOnePackage(MemoryStream writer, UGCResourcePackage package)
	{
	}

	private int loadOnePackage(byte[] projectBytes, int index, UGCResourcePackage package)
	{
		return 0;
	}

	private void loadFromProjectDataMultiPackage(byte[] projectDataBytes, int index)
	{
	}

	private byte[] saveMultiPackageToProjectData()
	{
		return null;
	}

	public bool Export(out byte[] projectDataBytes, ref EditorMiscData miscData)
	{
		projectDataBytes = null;
		return false;
	}

	public bool CheckLegality(ref EditorMiscData miscData)
	{
		return false;
	}

	private void collectResName(UGCResourcePackage package, GNHAFLDPNJI resContentData)
	{
	}

	public void CollectResourcePackage(GNHAFLDPNJI resContentData)
	{
	}

	private void collectResAvatarCSSItems(OLEDMLOHNFH item, List<uint> cssItemIDs)
	{
	}

	private void collectTimeLineAssetsRefResIDs(OLEDMLOHNFH item, ref List<uint> cssItemIDs, ref List<string> resUIDs)
	{
	}

	private void collectTimelineTrackResRef(HPKDGEHKENL trackData, ref List<uint> cssItemIDs, ref List<string> resUIDs)
	{
	}

	private void collectResTimeLineAnimationClipCSSItems(HPKDGEHKENL trackData, ref List<uint> cssItemIDs)
	{
	}

	private void collectResTimeLineAudioClipResUID(HPKDGEHKENL trackData, ref List<string> resUIDs)
	{
	}

	private void addCSSItemToList(List<uint> cssItemIDs, uint itemID)
	{
	}

	public OLEDMLOHNFH GetCustomResource(string resUUID)
	{
		return null;
	}

	private void validateResourcePackage()
	{
	}

	public void AddCustomResource(OLEDMLOHNFH resItem)
	{
	}

	public void UpdateCustomResource(OLEDMLOHNFH resItem)
	{
	}

	public void RemoveCustomResource(OLEDMLOHNFH resItem)
	{
	}

	private void validateBuildinResPackage()
	{
	}

	public static void addCustomResource(OLEDMLOHNFH resItem, UGCResourcePackage package)
	{
	}

	public void AddBuildinRefResource(string resname, IHDACHNBFNG resType)
	{
	}

	public IEnumerable<OLEDMLOHNFH> GetPackageItemEnumerator()
	{
		return null;
	}
}
