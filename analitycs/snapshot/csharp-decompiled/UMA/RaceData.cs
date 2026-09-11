using System;
using System.Collections.Generic;
using UnityEngine;

namespace UMA;

[Serializable]
public class RaceData : ScriptableObject, INameProvider
{
	[Serializable]
	public class RaceThumbnails
	{
		[Serializable]
		public class WardrobeSlotThumb
		{
			public string thumbIsFor;

			public Sprite thumb;
		}

		public Sprite fullThumb;

		public Sprite faceThumb;

		private List<WardrobeSlotThumb> wardrobeSlotThumbs;

		public Sprite GetThumbFor(string thumbToGet = "")
		{
			return null;
		}
	}

	public enum UMATarget
	{
		Humanoid,
		Generic
	}

	public UMARecipeBase baseRaceRecipe;

	public int baseOverlayLimitSizes;

	public List<string> wardrobeSlots;

	public List<int> overlayLimitSizes;

	public List<string> backwardsCompatibleWith;

	public RaceThumbnails raceThumbnails;

	public string raceName;

	public UmaTPose TPose;

	public UMATarget umaTarget;

	public string genericRootMotionTransformName;

	public float raceHeight;

	public float raceRadius;

	public float raceMass;

	public void AddDefaultWardrobeSlots(bool forceOverride = false)
	{
	}

	public bool ValidateWardrobeSlots(bool setToDefault = false)
	{
		return false;
	}

	public bool findBackwardsCompatibleWith(List<string> compatibleStrings)
	{
		return false;
	}

	public int GetSlotLimitSize(string s)
	{
		return 0;
	}

	public string GetAssetName()
	{
		return null;
	}

	public int GetNameHash()
	{
		return 0;
	}

	public bool Validate()
	{
		return false;
	}
}
