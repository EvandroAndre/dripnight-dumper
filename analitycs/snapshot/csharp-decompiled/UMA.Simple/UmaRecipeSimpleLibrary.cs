using System.Collections.Generic;
using UnityEngine;

namespace UMA.Simple;

public class UmaRecipeSimpleLibrary
{
	public const byte Version = 2;

	public const byte FlagHasAdditive = 128;

	public const byte FlagHasHides = 64;

	public const byte FlagHasSups = 32;

	public const byte FlagHasBeSups = 16;

	public const byte FlagHasSupOrBeSups = 48;

	public const byte FlagMaskSlotCount = 15;

	public const int EndMark = 2;

	public const bool ExportBaseRecipes = false;

	public static UmaRecipeSimpleLibrary Instance;

	public static bool ParseDataByUnsafe;

	private bool m_Inited;

	internal int[] m_Data;

	private byte m_Version;

	private ushort m_Count;

	private int[] m_pBaseRecipes;

	private int m_pWardrobeRecipeStart;

	private Dictionary<int, int> m_pWardrobeRecipes;

	public int Count => 0;

	public Dictionary<int, int> GetAllRecipes()
	{
		return null;
	}

	public static void ClearForRestart()
	{
	}

	public static void InitInstanceInNeed()
	{
	}

	private void InitInNeed()
	{
	}

	public void Load(TextAsset asset)
	{
	}

	private bool ReadRecipe(int[] data, ref int p, bool isBase)
	{
		return false;
	}

	private bool GetWardrobeReipcePtr(string name, out int ptr)
	{
		ptr = default(int);
		return false;
	}

	private bool GetWardrobeReipcePtr(int hash, out int ptr)
	{
		ptr = default(int);
		return false;
	}

	public UmaRecipeSimple GetWardrobeRecipe(int hash)
	{
		return default(UmaRecipeSimple);
	}
}
