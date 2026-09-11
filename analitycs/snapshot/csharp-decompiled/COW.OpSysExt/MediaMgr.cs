using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.OpSysExt;

public class MediaMgr : OpSysExt
{
	public class MediaMetaData
	{
		public string NativeId;

		public string FileName;

		public long FileSize;

		public long CreationTime;

		public long LastModTime;

		public string Mime;

		public string Desc;

		public static bool IsValid(MediaMetaData mediaMetaData)
		{
			return false;
		}
	}

	protected class AlbumImageTexturePool : IDisposable
	{
		protected class AlbumImageTexture : IAlbumImageTexture, IDisposable
		{
			private AlbumImageTexturePool _Pool;

			private string _003CNativeIdentifier_003Ek__BackingField;

			private Texture2D _003CTexture_003Ek__BackingField;

			public long Ticks_Dispose;

			public int Refs;

			public string NativeIdentifier
			{
				get
				{
					return _003CNativeIdentifier_003Ek__BackingField;
				}
				private set
				{
					_003CNativeIdentifier_003Ek__BackingField = value;
				}
			}

			public Texture2D Texture
			{
				get
				{
					return _003CTexture_003Ek__BackingField;
				}
				private set
				{
					_003CTexture_003Ek__BackingField = value;
				}
			}

			public AlbumImageTexture(AlbumImageTexturePool pool, string nativeIdentifier, byte[] bytes)
			{
			}

			public void Obtain()
			{
			}

			public void Dispose()
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<KeyValuePair<string, AlbumImageTexture>, bool> _003C_003E9__11_0;

			public static Comparison<KeyValuePair<string, AlbumImageTexture>> _003C_003E9__11_1;

			internal bool _003CUpdate_003Eb__11_0(KeyValuePair<string, AlbumImageTexture> p)
			{
				return false;
			}

			internal int _003CUpdate_003Eb__11_1(KeyValuePair<string, AlbumImageTexture> a, KeyValuePair<string, AlbumImageTexture> b)
			{
				return 0;
			}
		}

		private Dictionary<string, AlbumImageTexture> _Textures;

		private int _003CMaxSize_003Ek__BackingField;

		private int _003CMaxAge_S_003Ek__BackingField;

		public int MaxSize
		{
			get
			{
				return _003CMaxSize_003Ek__BackingField;
			}
			private set
			{
				_003CMaxSize_003Ek__BackingField = value;
			}
		}

		public int MaxAge_S
		{
			get
			{
				return _003CMaxAge_S_003Ek__BackingField;
			}
			private set
			{
				_003CMaxAge_S_003Ek__BackingField = value;
			}
		}

		public AlbumImageTexturePool(int maxSize, int maxAgeInSeconds)
		{
		}

		protected virtual void Update()
		{
		}

		public IAlbumImageTexture Obtain(string nativeIdentifier)
		{
			return null;
		}

		private void _Dispose(AlbumImageTexture texture)
		{
		}

		public void Cache(string nativeIdentifier, byte[] bytes)
		{
		}

		public void Dispose()
		{
		}
	}

	public interface IAlbumImageTexture : IDisposable
	{
		string NativeIdentifier { get; }

		Texture2D Texture { get; }
	}

	public interface IObserver
	{
		void OnSavedMediaToAlbum(string filePath, string nativeIdentifier, string error);

		void OnSavedMediaToAlbum(byte[] imageData, string nativeIdentifier, string error);

		void OnIsMediaInAlbum(string nativeIdentifier, bool exists, string error);

		void OnQueryMediaInAlbum(Dictionary<string, MediaMetaData> mediaMetaData, string error);

		void OnLoadedMediaFromAlbum(string nativeIdentifier, byte[] data, string error);

		void OnDeletedMediaFromAlbum(Dictionary<string, bool> result, string error);
	}

	private class SaveImageCall
	{
		public byte[] ImageData;

		public Action<byte[], string, string> Callback;

		public PlatformUtility.TakenSreenshotMaskToken TakenSreenshotMaskToken;

		public string FilePath;

		public Action<string, string, string> FilePathCallback;
	}

	private class QueryMediaInAlbumCall
	{
		public string[] NativeIdentifiers;

		public Action<Dictionary<string, MediaMetaData>, string> Callback;
	}

	public class LoadMediaOption
	{
		public MediaVersion Version;
	}

	private class DeleteImagesCall
	{
		public string[] NativeIdentifiers;

		public Action<Dictionary<string, bool>, string> Callback;

		public PlatformUtility.TakenSreenshotMaskToken TakenSreenshotMaskToken;
	}

	public enum MediaType
	{
		Image,
		Video
	}

	public enum MediaAccessType
	{
		Save,
		Load,
		Delete
	}

	public enum MediaAuthStatus
	{
		NotDetermined,
		Restricted,
		Denied,
		Authorized,
		Limited
	}

	public enum MediaVersion
	{
		Current,
		Unadjusted,
		Original
	}

	private class Impl_Android : MediaMgr
	{
		private class MediaMgrCallback : AndroidJavaProxy
		{
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				public MediaMgrCallback _003C_003E4__this;

				public long id;

				public string nativeIdentifier;

				public string error;

				internal void _003ConSaveImageToAlbumResult_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass3_0
			{
				public MediaMgrCallback _003C_003E4__this;

				public long id;

				public string identifier;

				public bool exists;

				public string error;

				internal void _003ConIsImageInAlbumResult_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass4_0
			{
				public MediaMgrCallback _003C_003E4__this;

				public long id;

				public string error;

				public MediaMetaData[] mediaMetaData;

				internal void _003ConQueryImagesInAlbumResult_003Eb__0()
				{
				}

				internal void _003ConQueryImagesInAlbumResult_003Eb__1()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass5_0
			{
				public MediaMgrCallback _003C_003E4__this;

				public long id;

				public string identifier;

				public byte[] data;

				public string error;

				public string tempFilePath;

				internal void _003ConLoadImageFromAlbumResult_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass6_0
			{
				public MediaMgrCallback _003C_003E4__this;

				public long id;

				public bool[] results;

				public string error;

				internal void _003ConDeleteImagesFromAlbumResult_003Eb__0()
				{
				}
			}

			private Impl_Android _Mgr;

			public MediaMgrCallback(Impl_Android mgr)
				: base((string)null)
			{
			}

			public void onSaveImageToAlbumResult(long id, string nativeIdentifier, string error)
			{
			}

			public void onIsImageInAlbumResult(long id, string identifier, bool exists, string error)
			{
			}

			public void onQueryImagesInAlbumResult(long id, string error, int mediaMetaDataLength, string[] fileNames, long[] fileSizes, long[] creationTimes, long[] lastModTimes, string[] mimes, string[] descs)
			{
			}

			public void onLoadImageFromAlbumResult(long id, string identifier, string tempFilePath, string error)
			{
			}

			public void onDeleteImagesFromAlbumResult(long id, string error, bool[] results)
			{
			}
		}

		private HashSet<string> _SavedImageNativeIdentifiers;

		private HashSet<string> _DeletedImageNativeIdentifiers;

		private AndroidJavaClass _JavaClass;

		private MediaMgrCallback _Callback;

		private bool _IsSavedOrDeletedImage(string nativeIdentifier)
		{
			return false;
		}

		protected override void _SaveImageToAlbum(long id, byte[] imageData, string title, string description)
		{
		}

		protected override void _SaveImageToAlbum(long id, string filePath, string title, string description)
		{
		}

		protected override void OnSavedImageToAlbum(long id, string nativeIdentifier, string error)
		{
		}

		protected override void _IsImageInAlbum(long id, string nativeIdentifier)
		{
		}

		protected override void _QueryMediaInAlbum(long id, string[] nativeIdentifiers)
		{
		}

		protected override void _LoadImageFromAlbum(long id, string nativeIdentifier, LoadMediaOption option = null)
		{
		}

		protected override void _DeleteImagesFromAlbum(long id, string[] nativeIdentifiers)
		{
		}

		protected override void OnDeletedImagesFromAlbum(long id, bool[] success, string error)
		{
		}

		public override void CheckMediaAuthStatus(MediaType mediaType, MediaAccessType accessType, Action<MediaType, MediaAccessType, MediaAuthStatus, string> callback)
		{
		}

		public override void RequestMediaAuth(MediaType mediaType, MediaAccessType accessType, Action<MediaType, MediaAccessType, MediaAuthStatus, string> callback)
		{
		}

		public void _003C_003EiFixBaseProxy__SaveImageToAlbum(long P0, byte[] P1, string P2, string P3)
		{
		}

		public void _003C_003EiFixBaseProxy__SaveImageToAlbum(long P0, string P1, string P2, string P3)
		{
		}

		public void _003C_003EiFixBaseProxy_OnSavedImageToAlbum(long P0, string P1, string P2)
		{
		}

		public void _003C_003EiFixBaseProxy__IsImageInAlbum(long P0, string P1)
		{
		}

		public void _003C_003EiFixBaseProxy__QueryMediaInAlbum(long P0, string[] P1)
		{
		}

		public void _003C_003EiFixBaseProxy__LoadImageFromAlbum(long P0, string P1, LoadMediaOption P2)
		{
		}

		public void _003C_003EiFixBaseProxy__DeleteImagesFromAlbum(long P0, string[] P1)
		{
		}

		public void _003C_003EiFixBaseProxy_OnDeletedImagesFromAlbum(long P0, bool[] P1, string P2)
		{
		}

		public void _003C_003EiFixBaseProxy_CheckMediaAuthStatus(MediaType P0, MediaAccessType P1, Action<MediaType, MediaAccessType, MediaAuthStatus, string> P2)
		{
		}

		public void _003C_003EiFixBaseProxy_RequestMediaAuth(MediaType P0, MediaAccessType P1, Action<MediaType, MediaAccessType, MediaAuthStatus, string> P2)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public Action<string, IAlbumImageTexture, string> callback;

		public MediaMgr _003C_003E4__this;

		internal void _003CObtainAlbumImageTexture_003Eb__0(string id, byte[] bytes, string error)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public MediaMgr _003C_003E4__this;

		public long id;

		public MediaMetaData[] mediaMetaData;

		public string error;

		internal void _003COnQueryMediaInAlbumResult_003Eb__0()
		{
		}
	}

	private static MediaMgr _I;

	protected AlbumImageTexturePool _ImagePool;

	private Dictionary<int, HashSet<IObserver>> _Observers;

	private LongSeqPool<SaveImageCall> _SaveImageCalls;

	private LongSeqPool<Action<string, bool, string>> _IsImageInAlbumCallbacks;

	private LongSeqPool<QueryMediaInAlbumCall> _QueryMediaInAlbumCallbacks;

	private LongSeqPool<Action<string, byte[], string>> _LoadImageFromAlbumCallbacks;

	private LongSeqPool<DeleteImagesCall> _DeleteImagesFromAlbumCallbacks;

	public static MediaMgr I => null;

	protected MediaMgr()
	{
	}

	public bool IsAlbumImageTexturePoolExist()
	{
		return false;
	}

	public bool CreateAlbumImageTexturePool(int maxSize, int maxAge_S)
	{
		return false;
	}

	public void DestroyAlbumImageTexturePool()
	{
	}

	public bool ObtainAlbumImageTexture(string nativeIdentifier, Action<string, IAlbumImageTexture, string> callback)
	{
		return false;
	}

	public void RegisterObserver(MediaType mediaType, IObserver observer)
	{
	}

	public void UnregisterObserver(MediaType mediaType, IObserver observer)
	{
	}

	public void SaveImageToAlbum(string filePath, string title, string description, Action<string, string, string> callback = null)
	{
	}

	public void SaveImageToAlbum(byte[] imageData, string title, string description, Action<byte[], string, string> callback = null)
	{
	}

	protected virtual void _SaveImageToAlbum(long id, string filePath, string title, string description)
	{
	}

	protected virtual void _SaveImageToAlbum(long id, byte[] imageData, string title, string description)
	{
	}

	protected virtual void OnSavedImageToAlbum(long id, string nativeIdentifier, string error)
	{
	}

	public void IsImageInAlbum(string nativeIdentifier, Action<string, bool, string> callback = null)
	{
	}

	protected virtual void _IsImageInAlbum(long id, string nativeIdentifier)
	{
	}

	protected void OnIsImageInAlbumResult(long id, string nativeIdentifier, bool exists, string error)
	{
	}

	public void QueryMediaInAlbum(string[] nativeIdentifiers, Action<Dictionary<string, MediaMetaData>, string> callback = null)
	{
	}

	protected virtual void _QueryMediaInAlbum(long id, string[] nativeIdentifiers)
	{
	}

	protected void OnQueryMediaInAlbumResult(long id, MediaMetaData[] mediaMetaData, string error)
	{
	}

	public void LoadImageFromAlbum(string nativeIdentifier, LoadMediaOption option = null, Action<string, byte[], string> callback = null)
	{
	}

	protected virtual void _LoadImageFromAlbum(long id, string nativeIdentifier, LoadMediaOption option = null)
	{
	}

	protected void OnLoadedImageFromAlbum(long id, string nativeIdentifier, byte[] data, string error)
	{
	}

	public void DeleteImagesFromAlbum(string[] nativeIdentifiers, Action<Dictionary<string, bool>, string> callback = null)
	{
	}

	protected virtual void _DeleteImagesFromAlbum(long id, string[] nativeIdentifiers)
	{
	}

	protected virtual void OnDeletedImagesFromAlbum(long id, bool[] success, string error)
	{
	}

	public virtual void CheckMediaAuthStatus(MediaType mediaType, MediaAccessType accessType, Action<MediaType, MediaAccessType, MediaAuthStatus, string> callback)
	{
	}

	public virtual void RequestMediaAuth(MediaType mediaType, MediaAccessType accessType, Action<MediaType, MediaAccessType, MediaAuthStatus, string> callback)
	{
	}

	public virtual void PromptToUpdateLimitedAuthMediaList(Action<bool, string[]> callback)
	{
	}
}
