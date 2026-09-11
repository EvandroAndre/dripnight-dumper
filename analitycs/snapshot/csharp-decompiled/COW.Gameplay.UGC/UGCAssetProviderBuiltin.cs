using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;

namespace COW.Gameplay.UGC;

public sealed class UGCAssetProviderBuiltin : UGCAssetProviderBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<FCAJEKECGME, string> _003C_003E9__20_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__20_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__20_2;

		public static Func<FCAJEKECGME, string> _003C_003E9__21_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__21_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__21_2;

		public static Func<FCAJEKECGME, string> _003C_003E9__22_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__22_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__22_2;

		public static Func<FCAJEKECGME, string> _003C_003E9__23_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__23_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__23_2;

		public static Func<FCAJEKECGME, string> _003C_003E9__24_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__24_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__24_2;

		public static Func<FCAJEKECGME, string> _003C_003E9__25_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__25_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__25_2;

		public static Func<FCAJEKECGME, string> _003C_003E9__26_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__26_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__26_2;

		public static Func<FCAJEKECGME, string> _003C_003E9__27_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__27_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__27_2;

		public static Func<FCAJEKECGME, string> _003C_003E9__28_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__28_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__28_2;

		public static Func<FCAJEKECGME, string> _003C_003E9__29_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__29_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__29_2;

		public static Func<CSVBaseData, FCAJEKECGME> _003C_003E9__29_3;

		public static Func<FCAJEKECGME, string> _003C_003E9__30_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__30_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__30_2;

		public static Func<CSVBaseData, FCAJEKECGME> _003C_003E9__30_3;

		public static Func<FCAJEKECGME, string> _003C_003E9__31_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__31_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__31_2;

		public static Func<CSVBaseData, FCAJEKECGME> _003C_003E9__31_3;

		public static Func<FCAJEKECGME, string> _003C_003E9__32_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__32_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__32_2;

		public static Func<CSVBaseData, FCAJEKECGME> _003C_003E9__32_3;

		public static Func<FCAJEKECGME, string> _003C_003E9__33_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__33_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__33_2;

		public static Func<CSVBaseData, FCAJEKECGME> _003C_003E9__33_3;

		public static Func<FCAJEKECGME, string> _003C_003E9__34_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__34_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__34_2;

		public static Func<CSVBaseData, FCAJEKECGME> _003C_003E9__34_3;

		public static Func<FCAJEKECGME, string> _003C_003E9__35_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__35_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__35_2;

		public static Func<CSVBaseData, FCAJEKECGME> _003C_003E9__35_3;

		public static Func<FCAJEKECGME, string> _003C_003E9__36_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__36_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__36_2;

		public static Func<CSVBaseData, FCAJEKECGME> _003C_003E9__36_3;

		public static Func<FCAJEKECGME, string> _003C_003E9__37_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__37_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__37_2;

		public static Func<CSVBaseData, FCAJEKECGME> _003C_003E9__37_3;

		public static Func<FCAJEKECGME, string> _003C_003E9__38_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__38_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__38_2;

		public static Func<CSVBaseData, FCAJEKECGME> _003C_003E9__38_3;

		public static Func<FCAJEKECGME, string> _003C_003E9__39_0;

		public static Func<FCAJEKECGME, string> _003C_003E9__39_1;

		public static Func<FCAJEKECGME, UGCPreview> _003C_003E9__39_2;

		public static Func<CSVBaseData, FCAJEKECGME> _003C_003E9__39_3;

		internal string _003CRegisterIcons_003Eb__20_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterIcons_003Eb__20_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterIcons_003Eb__20_2(FCAJEKECGME row)
		{
			return null;
		}

		internal string _003CRegisterTextures_003Eb__21_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterTextures_003Eb__21_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterTextures_003Eb__21_2(FCAJEKECGME row)
		{
			return null;
		}

		internal string _003CRegisterSounds_003Eb__22_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterSounds_003Eb__22_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterSounds_003Eb__22_2(FCAJEKECGME row)
		{
			return null;
		}

		internal string _003CRegisterVfx_003Eb__23_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterVfx_003Eb__23_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterVfx_003Eb__23_2(FCAJEKECGME row)
		{
			return null;
		}

		internal string _003CRegisterObjects_003Eb__24_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterObjects_003Eb__24_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterObjects_003Eb__24_2(FCAJEKECGME row)
		{
			return null;
		}

		internal string _003CRegisterItems_003Eb__25_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterItems_003Eb__25_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterItems_003Eb__25_2(FCAJEKECGME row)
		{
			return null;
		}

		internal string _003CRegisterItemGenerators_003Eb__26_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterItemGenerators_003Eb__26_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterItemGenerators_003Eb__26_2(FCAJEKECGME row)
		{
			return null;
		}

		internal string _003CRegisterWeaponGenerators_003Eb__27_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterWeaponGenerators_003Eb__27_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterWeaponGenerators_003Eb__27_2(FCAJEKECGME row)
		{
			return null;
		}

		internal string _003CRegisterSkyEnv_003Eb__28_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterSkyEnv_003Eb__28_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterSkyEnv_003Eb__28_2(FCAJEKECGME row)
		{
			return null;
		}

		internal string _003CRegisterClothes_003Eb__29_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterClothes_003Eb__29_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterClothes_003Eb__29_2(FCAJEKECGME row)
		{
			return null;
		}

		internal FCAJEKECGME _003CRegisterClothes_003Eb__29_3(CSVBaseData csv)
		{
			return null;
		}

		internal string _003CRegisterNPCAvatars_003Eb__30_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterNPCAvatars_003Eb__30_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterNPCAvatars_003Eb__30_2(FCAJEKECGME row)
		{
			return null;
		}

		internal FCAJEKECGME _003CRegisterNPCAvatars_003Eb__30_3(CSVBaseData csv)
		{
			return null;
		}

		internal string _003CRegisterPetClothes_003Eb__31_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterPetClothes_003Eb__31_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterPetClothes_003Eb__31_2(FCAJEKECGME row)
		{
			return null;
		}

		internal FCAJEKECGME _003CRegisterPetClothes_003Eb__31_3(CSVBaseData csv)
		{
			return null;
		}

		internal string _003CRegisterPetEmotes_003Eb__32_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterPetEmotes_003Eb__32_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterPetEmotes_003Eb__32_2(FCAJEKECGME row)
		{
			return null;
		}

		internal FCAJEKECGME _003CRegisterPetEmotes_003Eb__32_3(CSVBaseData csv)
		{
			return null;
		}

		internal string _003CRegisterNPCAnimStateClips_003Eb__33_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterNPCAnimStateClips_003Eb__33_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterNPCAnimStateClips_003Eb__33_2(FCAJEKECGME row)
		{
			return null;
		}

		internal FCAJEKECGME _003CRegisterNPCAnimStateClips_003Eb__33_3(CSVBaseData csv)
		{
			return null;
		}

		internal string _003CRegisterWeaponSkins_003Eb__34_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterWeaponSkins_003Eb__34_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterWeaponSkins_003Eb__34_2(FCAJEKECGME row)
		{
			return null;
		}

		internal FCAJEKECGME _003CRegisterWeaponSkins_003Eb__34_3(CSVBaseData csv)
		{
			return null;
		}

		internal string _003CRegisterEmotes_003Eb__35_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterEmotes_003Eb__35_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterEmotes_003Eb__35_2(FCAJEKECGME row)
		{
			return null;
		}

		internal FCAJEKECGME _003CRegisterEmotes_003Eb__35_3(CSVBaseData csv)
		{
			return null;
		}

		internal string _003CRegisterVehicleSkins_003Eb__36_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterVehicleSkins_003Eb__36_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterVehicleSkins_003Eb__36_2(FCAJEKECGME row)
		{
			return null;
		}

		internal FCAJEKECGME _003CRegisterVehicleSkins_003Eb__36_3(CSVBaseData csv)
		{
			return null;
		}

		internal string _003CRegisterBagSkins_003Eb__37_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterBagSkins_003Eb__37_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterBagSkins_003Eb__37_2(FCAJEKECGME row)
		{
			return null;
		}

		internal FCAJEKECGME _003CRegisterBagSkins_003Eb__37_3(CSVBaseData csv)
		{
			return null;
		}

		internal string _003CRegisterAvatarSkills_003Eb__38_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterAvatarSkills_003Eb__38_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterAvatarSkills_003Eb__38_2(FCAJEKECGME row)
		{
			return null;
		}

		internal FCAJEKECGME _003CRegisterAvatarSkills_003Eb__38_3(CSVBaseData csv)
		{
			return null;
		}

		internal string _003CRegisterDialogueStyles_003Eb__39_0(FCAJEKECGME d)
		{
			return null;
		}

		internal string _003CRegisterDialogueStyles_003Eb__39_1(FCAJEKECGME d)
		{
			return null;
		}

		internal UGCPreview _003CRegisterDialogueStyles_003Eb__39_2(FCAJEKECGME row)
		{
			return null;
		}

		internal FCAJEKECGME _003CRegisterDialogueStyles_003Eb__39_3(CSVBaseData csv)
		{
			return null;
		}
	}

	private readonly EUGCAssetProviderType _providerId;

	private readonly Dictionary<string, UGCAssetMetadata> _assetIdToMeta;

	private readonly Dictionary<string, UGCPreview> _uuidToUGCPreview;

	private readonly HashSet<string> _loadedTags;

	public override EUGCAssetProviderType ProviderId => EUGCAssetProviderType.None;

	public override string DisplayName => null;

	public UGCAssetProviderBuiltin(EUGCAssetProviderType providerId)
	{
	}

	public override void Initialize(UGCAssetExplorer explorer)
	{
	}

	public override void EnsureAssetsForQuery(UGCQuery query)
	{
	}

	private static string SafeId(string prefer, string fallback)
	{
		return null;
	}

	private void RegisterList(string category, List<CSVBaseData> list, IHDACHNBFNG resType, Func<FCAJEKECGME, string> getId, Func<FCAJEKECGME, string> getName, Func<FCAJEKECGME, UGCPreview> createPreview = null, Func<CSVBaseData, FCAJEKECGME> toBase = null)
	{
	}

	public override UGCAssetMetadata GetAssetMetadata(string assetId)
	{
		return null;
	}

	public override void PrepareAssetForLoad(UGCAssetRef asset)
	{
	}

	public override bool IsAssetInUse(UGCAssetRef asset, bool IgnorePackage = false)
	{
		return false;
	}

	public override bool DeleteAsset(UGCAssetRef asset)
	{
		return false;
	}

	public override bool IsPackageAsset(UGCAssetRef asset)
	{
		return false;
	}

	public override bool RenameAsset(UGCAssetRef asset, string newName)
	{
		return false;
	}

	public override bool TryCreatePreview(string assetId, UGCPreviewOptions options, out UGCPreview preview)
	{
		preview = null;
		return false;
	}

	private void RegisterIcons()
	{
	}

	private void RegisterTextures()
	{
	}

	private void RegisterSounds()
	{
	}

	private void RegisterVfx()
	{
	}

	private void RegisterObjects()
	{
	}

	private void RegisterItems()
	{
	}

	private void RegisterItemGenerators()
	{
	}

	private void RegisterWeaponGenerators()
	{
	}

	private void RegisterSkyEnv()
	{
	}

	private void RegisterClothes()
	{
	}

	private void RegisterNPCAvatars()
	{
	}

	private void RegisterPetClothes()
	{
	}

	private void RegisterPetEmotes()
	{
	}

	private void RegisterNPCAnimStateClips()
	{
	}

	private void RegisterWeaponSkins()
	{
	}

	private void RegisterEmotes()
	{
	}

	private void RegisterVehicleSkins()
	{
	}

	private void RegisterBagSkins()
	{
	}

	private void RegisterAvatarSkills()
	{
	}

	private void RegisterDialogueStyles()
	{
	}

	public void _003C_003EiFixBaseProxy_Initialize(UGCAssetExplorer P0)
	{
	}

	public void _003C_003EiFixBaseProxy_EnsureAssetsForQuery(UGCQuery P0)
	{
	}
}
