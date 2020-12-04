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
            // standard
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
            { typeof(Vector2F?), new StaticNullableFormatter<Vector2F>(new Formatters.Vector2FFormatter()) },
            { typeof(Vector3F?), new StaticNullableFormatter<Vector3F>(new Formatters.Vector3FFormatter()) },
            { typeof(Vector4F?), new StaticNullableFormatter<Vector4F>(new Formatters.Vector4FFormatter()) },
            { typeof(Vector2I?), new StaticNullableFormatter<Vector2I>(new Formatters.Vector2IFormatter()) },
            { typeof(Vector3I?), new StaticNullableFormatter<Vector3I>(new Formatters.Vector3IFormatter()) },
            { typeof(Vector4I?), new StaticNullableFormatter<Vector4I>(new Formatters.Vector4IFormatter()) },
            { typeof(RectF?), new StaticNullableFormatter<RectF>(new Formatters.RectFFormatter()) },
            { typeof(RectI?), new StaticNullableFormatter<RectI>(new Formatters.RectIFormatter()) },
            { typeof(Color?), new StaticNullableFormatter<Color>(new Formatters.ColorFormatter()) },
            { typeof(Matrix33F?), new StaticNullableFormatter<Matrix33F>(new Formatters.Matrix33FFormatter()) },
            { typeof(Matrix44F?), new StaticNullableFormatter<Matrix44F>(new Formatters.Matrix44FFormatter()) },
            { typeof(Matrix33I?), new StaticNullableFormatter<Matrix33I>(new Formatters.Matrix33IFormatter()) },
            { typeof(Matrix44I?), new StaticNullableFormatter<Matrix44I>(new Formatters.Matrix44IFormatter()) },

            // standard + array
            { typeof(Vector2F[]), new ArrayFormatter<Vector2F>() },
            { typeof(Vector3F[]), new ArrayFormatter<Vector3F>() },
            { typeof(Vector4F[]), new ArrayFormatter<Vector4F>() },
            { typeof(Vector2I[]), new ArrayFormatter<Vector2I>() },
            { typeof(Vector3I[]), new ArrayFormatter<Vector3I>() },
            { typeof(Vector4I[]), new ArrayFormatter<Vector4I>() },
            { typeof(RectF[]), new ArrayFormatter<RectF>() },
            { typeof(RectI[]), new ArrayFormatter<RectI>() },
            { typeof(Color[]), new ArrayFormatter<Color>() },
            { typeof(Matrix33F[]), new ArrayFormatter<Matrix33F>() },
            { typeof(Matrix44F[]), new ArrayFormatter<Matrix44F>() },
            { typeof(Matrix33I[]), new ArrayFormatter<Matrix33I>() },
            { typeof(Matrix44I[]), new ArrayFormatter<Matrix44I>() },
            { typeof(Vector2F?[]), new ArrayFormatter<Vector2F>() },
            { typeof(Vector3F?[]), new ArrayFormatter<Vector3F>() },
            { typeof(Vector4F?[]), new ArrayFormatter<Vector4F>() },
            { typeof(Vector2I?[]), new ArrayFormatter<Vector2I>() },
            { typeof(Vector3I?[]), new ArrayFormatter<Vector3I>() },
            { typeof(Vector4I?[]), new ArrayFormatter<Vector4I>() },
            { typeof(RectF?[]), new ArrayFormatter<RectF>() },
            { typeof(RectI?[]), new ArrayFormatter<RectI>() },
            { typeof(Color?[]), new ArrayFormatter<Color>() },
            { typeof(Matrix33F?[]), new ArrayFormatter<Matrix33F>() },
            { typeof(Matrix44F?[]), new ArrayFormatter<Matrix44F>() },
            { typeof(Matrix33I?[]), new ArrayFormatter<Matrix33I>() },
            { typeof(Matrix44I?[]), new ArrayFormatter<Matrix44I>() },

            // standard + list
            { typeof(List<Vector2F>), new ListFormatter<Vector2F>() },
            { typeof(List<Vector3F>), new ListFormatter<Vector3F>() },
            { typeof(List<Vector4F>), new ListFormatter<Vector4F>() },
            { typeof(List<Vector2I>), new ListFormatter<Vector2I>() },
            { typeof(List<Vector3I>), new ListFormatter<Vector3I>() },
            { typeof(List<Vector4I>), new ListFormatter<Vector4I>() },
            { typeof(List<RectF>), new ListFormatter<RectF>() },
            { typeof(List<RectI>), new ListFormatter<RectI>() },
            { typeof(List<Color>), new ListFormatter<Color>() },
            { typeof(List<Matrix33F>), new ListFormatter<Matrix33F>() },
            { typeof(List<Matrix44F>), new ListFormatter<Matrix44F>() },
            { typeof(List<Matrix33I>), new ListFormatter<Matrix33I>() },
            { typeof(List<Matrix44I>), new ListFormatter<Matrix44I>() },
            { typeof(List<Vector2F?>), new ListFormatter<Vector2F>() },
            { typeof(List<Vector3F?>), new ListFormatter<Vector3F>() },
            { typeof(List<Vector4F?>), new ListFormatter<Vector4F>() },
            { typeof(List<Vector2I?>), new ListFormatter<Vector2I>() },
            { typeof(List<Vector3I?>), new ListFormatter<Vector3I>() },
            { typeof(List<Vector4I?>), new ListFormatter<Vector4I>() },
            { typeof(List<RectF?>), new ListFormatter<RectF>() },
            { typeof(List<RectI?>), new ListFormatter<RectI>() },
            { typeof(List<Color?>), new ListFormatter<Color>() },
            { typeof(List<Matrix33F?>), new ListFormatter<Matrix33F>() },
            { typeof(List<Matrix44F?>), new ListFormatter<Matrix44F>() },
            { typeof(List<Matrix33I?>), new ListFormatter<Matrix33I>() },
            { typeof(List<Matrix44I?>), new ListFormatter<Matrix44I>() },
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
