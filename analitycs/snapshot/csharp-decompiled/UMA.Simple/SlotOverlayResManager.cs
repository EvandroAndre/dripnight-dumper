using System.Collections.Generic;
using System.IO;
using GCommon;
using UnityEngine;

namespace UMA.Simple;

public class SlotOverlayResManager
{
	public static SlotOverlayResManager Instance;

	private bool _003CInited_003Ek__BackingField;

	private const int VAL_APK_HASH_FILE_NAME = 1073741824;

	public const ushort INVALID_IDX = ushort.MaxValue;

	private const int AB_SHIFT = 16;

	private const int MAX_AB_COUNT = 16383;

	private const int PATH_MASK = 65535;

	private int m_AbsCount;

	private List<string> m_Abs;

	private List<string> m_Pathes;

	private bool m_UsePackedUrls;

	private SlotOverlayUrlSplitResultPacked m_PackedUrls;

	private Dictionary<int, int> SlotMap;

	private Dictionary<int, int> OverlayMap;

	private MutableString m_Sb;

	public bool Inited
	{
		get
		{
			return _003CInited_003Ek__BackingField;
		}
		protected set
		{
			_003CInited_003Ek__BackingField = value;
		}
	}

	public static void ClearForRestart()
	{
	}

	public static void InitInstanceInNeed()
	{
	}

	public void InitStringBuilderInNeed()
	{
	}

	public void Load(TextAsset asset, Dictionary<string, int> hotAbs = null)
	{
	}

	private void Load(StringReader fs, Dictionary<string, int> hotAbs, Dictionary<string, string> abDeps)
	{
	}

	private static List<string> LoadAbs(StringReader fs, Dictionary<string, string> abDeps)
	{
		return null;
	}

	private static Dictionary<int, int> LoadSlotOverlays(StringReader fs, int count, List<string> abs, List<string> pathes, Dictionary<string, int> nonIndexedAbs, Dictionary<string, int> hotAbs = null)
	{
		return null;
	}

	private static bool ReadIntLine(StringReader r, out int val)
	{
		val = default(int);
		return false;
	}

	private void Load(BinaryReader bs, Dictionary<string, int> hotAbs, Dictionary<string, string> abDeps)
	{
	}

	private static List<string> LoadAbs(BinaryReader bs, Dictionary<string, string> abDeps)
	{
		return null;
	}

	private static Dictionary<int, int> LoadSlotOverlays(BinaryReader bs, int count, List<string> abs, List<string> pathes, Dictionary<string, int> nonIndexedAbs, SlotOverlayUrlSplitResultPacked packedUrls, Dictionary<string, int> hotAbs = null)
	{
		return null;
	}

	public static bool GetSlotOrOverlay<T>(int hash, out string ab, out string path, bool useSharedStr = false)
	{
		ab = null;
		path = null;
		return false;
	}

	public bool GetSlotOrOverlay(int hash, bool isSlot, out string ab, out string path, bool useSharedStr = false)
	{
		ab = null;
		path = null;
		return false;
	}

	public bool GetSlotOrOverlayAb(int hash, bool isSlot, out string ab)
	{
		ab = null;
		return false;
	}

	public string GetSlotOrOverlayAb(int hash, bool isSlot)
	{
		return null;
	}

	public int GetSlotOrOverlayAbIdx(int hash, bool isSlot)
	{
		return 0;
	}

	private int GetSlotOrOverlayAbIdx(Dictionary<int, int> dic, int hash)
	{
		return 0;
	}

	private bool GetSlotOrOverlay(Dictionary<int, int> dic, int hash, out string ab, out string path, bool getPath = true, bool useSharedStr = false, bool skipError = false)
	{
		ab = null;
		path = null;
		return false;
	}

	private string GetPathFromHash(int hash, bool useSharedStr = false)
	{
		return null;
	}
}
