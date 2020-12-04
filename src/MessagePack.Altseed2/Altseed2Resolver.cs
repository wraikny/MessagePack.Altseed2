using System;
using System.Collections.Generic;
using MessagePack.Formatters;
using Altseed2;

namespace MessagePack.Altseed2
{
    public sealed class Altseed2Resolver : IFormatterResolver
    {
        public static readonly IFormatterResolver Instance = new Altseed2Resolver();

        private Altseed2Resolver() { }

        public IMessagePackFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.Formatter;
        }

        private static class FormatterCache<T>
        {
            public static readonly IMessagePackFormatter<T> Formatter;

            static FormatterCache()
            {
                Formatter = (IMessagePackFormatter<T>)Altseed2GetFormatterHelper.GetFormatter(typeof(T));
            }
        }
    }

    internal static class Altseed2GetFormatterHelper
    {
        private static readonly Dictionary<Type, object> formatterMap = new Dictionary<Type, object>()
        {
            { typeof(Vector2F), new Formatters.Vector2FFormatter() },
            { typeof(Vector3F), new Formatters.Vector3FFormatter() },
            { typeof(Vector4F), new Formatters.Vector4FFormatter() },
            { typeof(Vector2I), new Formatters.Vector2IFormatter() },
            { typeof(Vector3I), new Formatters.Vector3IFormatter() },
            { typeof(Vector4I), new Formatters.Vector4IFormatter() },
            { typeof(RectF), new Formatters.RectFFormatter() },
            { typeof(RectI), new Formatters.RectIFormatter() },
            { typeof(Color), new Formatters.ColorFormatter() },
            { typeof(Matrix33F), new Formatters.Matrix33FFormatter() },
            { typeof(Matrix44F), new Formatters.Matrix44FFormatter() },
            { typeof(Matrix33I), new Formatters.Matrix33IFormatter() },
            { typeof(Matrix44I), new Formatters.Matrix44IFormatter() },

            { typeof(Vector2F?), new NullableFormatter<Vector2F>() },
            { typeof(Vector3F?), new NullableFormatter<Vector3F>() },
            { typeof(Vector4F?), new NullableFormatter<Vector4F>() },
            { typeof(Vector2I?), new NullableFormatter<Vector2I>() },
            { typeof(Vector3I?), new NullableFormatter<Vector3I>() },
            { typeof(Vector4I?), new NullableFormatter<Vector4I>() },
            { typeof(RectF?), new NullableFormatter<RectF>() },
            { typeof(RectI?), new NullableFormatter<RectI>() },
            { typeof(Color?), new NullableFormatter<Color>() },
            { typeof(Matrix33F?), new NullableFormatter<Matrix33F>() },
            { typeof(Matrix44F?), new NullableFormatter<Matrix44F>() },
            { typeof(Matrix33I?), new NullableFormatter<Matrix33I>() },
            { typeof(Matrix44I?), new NullableFormatter<Matrix44I>() },
        };

        internal static object GetFormatter(Type t)
        {

            if (formatterMap.TryGetValue(t, out var formatter))
            {
                return formatter;
            }

            return null;
        }

    }
}
