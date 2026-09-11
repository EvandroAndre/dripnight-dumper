using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace FFVoice;

public class JsonMapper
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static WrapperFactory _003C_003E9__23_0;

		public static ExporterFunc _003C_003E9__24_0;

		public static ExporterFunc _003C_003E9__24_1;

		public static ExporterFunc _003C_003E9__24_2;

		public static ExporterFunc _003C_003E9__24_3;

		public static ExporterFunc _003C_003E9__24_4;

		public static ExporterFunc _003C_003E9__24_5;

		public static ExporterFunc _003C_003E9__24_6;

		public static ExporterFunc _003C_003E9__24_7;

		public static ExporterFunc _003C_003E9__24_8;

		public static ImporterFunc _003C_003E9__25_0;

		public static ImporterFunc _003C_003E9__25_1;

		public static ImporterFunc _003C_003E9__25_2;

		public static ImporterFunc _003C_003E9__25_3;

		public static ImporterFunc _003C_003E9__25_4;

		public static ImporterFunc _003C_003E9__25_5;

		public static ImporterFunc _003C_003E9__25_6;

		public static ImporterFunc _003C_003E9__25_7;

		public static ImporterFunc _003C_003E9__25_8;

		public static ImporterFunc _003C_003E9__25_9;

		public static ImporterFunc _003C_003E9__25_10;

		public static ImporterFunc _003C_003E9__25_11;

		public static WrapperFactory _003C_003E9__30_0;

		public static WrapperFactory _003C_003E9__31_0;

		public static WrapperFactory _003C_003E9__32_0;

		internal IJsonWrapper _003CReadSkip_003Eb__23_0()
		{
			return null;
		}

		internal void _003CRegisterBaseExporters_003Eb__24_0(object obj, JsonWriter writer)
		{
		}

		internal void _003CRegisterBaseExporters_003Eb__24_1(object obj, JsonWriter writer)
		{
		}

		internal void _003CRegisterBaseExporters_003Eb__24_2(object obj, JsonWriter writer)
		{
		}

		internal void _003CRegisterBaseExporters_003Eb__24_3(object obj, JsonWriter writer)
		{
		}

		internal void _003CRegisterBaseExporters_003Eb__24_4(object obj, JsonWriter writer)
		{
		}

		internal void _003CRegisterBaseExporters_003Eb__24_5(object obj, JsonWriter writer)
		{
		}

		internal void _003CRegisterBaseExporters_003Eb__24_6(object obj, JsonWriter writer)
		{
		}

		internal void _003CRegisterBaseExporters_003Eb__24_7(object obj, JsonWriter writer)
		{
		}

		internal void _003CRegisterBaseExporters_003Eb__24_8(object obj, JsonWriter writer)
		{
		}

		internal object _003CRegisterBaseImporters_003Eb__25_0(object input)
		{
			return null;
		}

		internal object _003CRegisterBaseImporters_003Eb__25_1(object input)
		{
			return null;
		}

		internal object _003CRegisterBaseImporters_003Eb__25_2(object input)
		{
			return null;
		}

		internal object _003CRegisterBaseImporters_003Eb__25_3(object input)
		{
			return null;
		}

		internal object _003CRegisterBaseImporters_003Eb__25_4(object input)
		{
			return null;
		}

		internal object _003CRegisterBaseImporters_003Eb__25_5(object input)
		{
			return null;
		}

		internal object _003CRegisterBaseImporters_003Eb__25_6(object input)
		{
			return null;
		}

		internal object _003CRegisterBaseImporters_003Eb__25_7(object input)
		{
			return null;
		}

		internal object _003CRegisterBaseImporters_003Eb__25_8(object input)
		{
			return null;
		}

		internal object _003CRegisterBaseImporters_003Eb__25_9(object input)
		{
			return null;
		}

		internal object _003CRegisterBaseImporters_003Eb__25_10(object input)
		{
			return null;
		}

		internal object _003CRegisterBaseImporters_003Eb__25_11(object input)
		{
			return null;
		}

		internal IJsonWrapper _003CToObject_003Eb__30_0()
		{
			return null;
		}

		internal IJsonWrapper _003CToObject_003Eb__31_0()
		{
			return null;
		}

		internal IJsonWrapper _003CToObject_003Eb__32_0()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass38_0<T>
	{
		public ExporterFunc<T> exporter;

		internal void _003CRegisterExporter_003Eb__0(object obj, JsonWriter writer)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0<TJson, TValue>
	{
		public ImporterFunc<TJson, TValue> importer;

		internal object _003CRegisterImporter_003Eb__0(object input)
		{
			return null;
		}
	}

	private static int max_nesting_depth;

	private static IFormatProvider datetime_format;

	private static IDictionary<Type, ExporterFunc> base_exporters_table;

	private static IDictionary<Type, ExporterFunc> custom_exporters_table;

	private static IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;

	private static IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;

	private static IDictionary<Type, ArrayMetadata> array_metadata;

	private static readonly object array_metadata_lock;

	private static IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;

	private static readonly object conv_ops_lock;

	private static IDictionary<Type, ObjectMetadata> object_metadata;

	private static readonly object object_metadata_lock;

	private static IDictionary<Type, IList<PropertyMetadata>> type_properties;

	private static readonly object type_properties_lock;

	private static JsonWriter static_writer;

	private static readonly object static_writer_lock;

	static JsonMapper()
	{
	}

	private static void AddArrayMetadata(Type type)
	{
	}

	private static void AddObjectMetadata(Type type)
	{
	}

	private static void AddTypeProperties(Type type)
	{
	}

	private static MethodInfo GetConvOp(Type t1, Type t2)
	{
		return null;
	}

	private static object ReadValue(Type inst_type, JsonReader reader)
	{
		return null;
	}

	private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader)
	{
		return null;
	}

	private static void ReadSkip(JsonReader reader)
	{
	}

	private static void RegisterBaseExporters()
	{
	}

	private static void RegisterBaseImporters()
	{
	}

	private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer)
	{
	}

	private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth)
	{
	}

	public static string ToJson(object obj)
	{
		return null;
	}

	public static void ToJson(object obj, JsonWriter writer)
	{
	}

	public static JsonData ToObject(JsonReader reader)
	{
		return null;
	}

	public static JsonData ToObject(TextReader reader)
	{
		return null;
	}

	public static JsonData ToObject(string json)
	{
		return null;
	}

	public static T ToObject<T>(JsonReader reader)
	{
		return default(T);
	}

	public static T ToObject<T>(TextReader reader)
	{
		return default(T);
	}

	public static T ToObject<T>(string json)
	{
		return default(T);
	}

	public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader)
	{
		return null;
	}

	public static IJsonWrapper ToWrapper(WrapperFactory factory, string json)
	{
		return null;
	}

	public static void RegisterExporter<T>(ExporterFunc<T> exporter)
	{
	}

	public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer)
	{
	}

	public static void UnregisterExporters()
	{
	}

	public static void UnregisterImporters()
	{
	}
}
