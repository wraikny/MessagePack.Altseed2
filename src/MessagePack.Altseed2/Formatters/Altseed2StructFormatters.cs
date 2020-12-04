using System;
using MessagePack.Formatters;
using Altseed2;

namespace MessagePack.Altseed2.Formatters
{
    public sealed class Vector2FFormatter : IMessagePackFormatter<Vector2F>
    {
        public void Serialize(ref MessagePackWriter writer, Vector2F value, MessagePackSerializerOptions options)
        {
            writer.WriteArrayHeader(2);
            writer.Write(value.X);
            writer.Write(value.Y);
        }

        public Vector2F Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.IsNil)
            {
                throw new InvalidOperationException("type code is null, struct not supported");
            }

            var length = reader.ReadArrayHeader();
            var x = default(float);
            var y = default(float);

            for (int i = 0; i < length; i++)
            {
                var key = i;
                switch (key)
                {
                    case 0:
                        x = reader.ReadSingle();
                        break;
                    case 1:
                        y = reader.ReadSingle();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var result = new Vector2F(x, y);
            return result;
        }
    }

    public sealed class Vector3FFormatter : IMessagePackFormatter<Vector3F>
    {
        public void Serialize(ref MessagePackWriter writer, Vector3F value, MessagePackSerializerOptions options)
        {
            writer.WriteArrayHeader(3);
            writer.Write(value.X);
            writer.Write(value.Y);
            writer.Write(value.Z);
        }

        public Vector3F Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.IsNil)
            {
                throw new InvalidOperationException("type code is null, struct not supported");
            }

            var length = reader.ReadArrayHeader();
            var x = default(float);
            var y = default(float);
            var z = default(float);

            for (int i = 0; i < length; i++)
            {
                var key = i;
                switch (key)
                {
                    case 0:
                        x = reader.ReadSingle();
                        break;
                    case 1:
                        y = reader.ReadSingle();
                        break;
                    case 2:
                        z = reader.ReadSingle();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var result = new Vector3F(x, y, z);
            return result;
        }
    }

    public sealed class Vector4FFormatter : IMessagePackFormatter<Vector4F>
    {
        public void Serialize(ref MessagePackWriter writer, Vector4F value, MessagePackSerializerOptions options)
        {
            writer.WriteArrayHeader(4);
            writer.Write(value.X);
            writer.Write(value.Y);
            writer.Write(value.Z);
            writer.Write(value.W);
        }

        public Vector4F Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.IsNil)
            {
                throw new InvalidOperationException("type code is null, struct not supported");
            }

            var length = reader.ReadArrayHeader();
            var x = default(float);
            var y = default(float);
            var z = default(float);
            var w = default(float);

            for (int i = 0; i < length; i++)
            {
                var key = i;
                switch (key)
                {
                    case 0:
                        x = reader.ReadSingle();
                        break;
                    case 1:
                        y = reader.ReadSingle();
                        break;
                    case 2:
                        z = reader.ReadSingle();
                        break;
                    case 3:
                        w = reader.ReadSingle();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var result = new Vector4F(x, y, z, w);
            return result;
        }
    }

    public sealed class Vector2IFormatter : IMessagePackFormatter<Vector2I>
    {
        public void Serialize(ref MessagePackWriter writer, Vector2I value, MessagePackSerializerOptions options)
        {
            writer.WriteArrayHeader(2);
            writer.Write(value.X);
            writer.Write(value.Y);
        }

        public Vector2I Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.IsNil)
            {
                throw new InvalidOperationException("type code is null, struct not supported");
            }

            var length = reader.ReadArrayHeader();
            var x = default(int);
            var y = default(int);

            for (int i = 0; i < length; i++)
            {
                var key = i;
                switch (key)
                {
                    case 0:
                        x = reader.ReadInt32();
                        break;
                    case 1:
                        y = reader.ReadInt32();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var result = new Vector2I(x, y);
            return result;
        }
    }

    public sealed class Vector3IFormatter : IMessagePackFormatter<Vector3I>
    {
        public void Serialize(ref MessagePackWriter writer, Vector3I value, MessagePackSerializerOptions options)
        {
            writer.WriteArrayHeader(3);
            writer.Write(value.X);
            writer.Write(value.Y);
            writer.Write(value.Z);
        }

        public Vector3I Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.IsNil)
            {
                throw new InvalidOperationException("type code is null, struct not supported");
            }

            var length = reader.ReadArrayHeader();
            var x = default(int);
            var y = default(int);
            var z = default(int);

            for (int i = 0; i < length; i++)
            {
                var key = i;
                switch (key)
                {
                    case 0:
                        x = reader.ReadInt32();
                        break;
                    case 1:
                        y = reader.ReadInt32();
                        break;
                    case 2:
                        z = reader.ReadInt32();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var result = new Vector3I(x, y, z);
            return result;
        }
    }

    public sealed class Vector4IFormatter : IMessagePackFormatter<Vector4I>
    {
        public void Serialize(ref MessagePackWriter writer, Vector4I value, MessagePackSerializerOptions options)
        {
            writer.WriteArrayHeader(4);
            writer.Write(value.X);
            writer.Write(value.Y);
            writer.Write(value.Z);
            writer.Write(value.W);
        }

        public Vector4I Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.IsNil)
            {
                throw new InvalidOperationException("type code is null, struct not supported");
            }

            var length = reader.ReadArrayHeader();
            var x = default(int);
            var y = default(int);
            var z = default(int);
            var w = default(int);

            for (int i = 0; i < length; i++)
            {
                var key = i;
                switch (key)
                {
                    case 0:
                        x = reader.ReadInt32();
                        break;
                    case 1:
                        y = reader.ReadInt32();
                        break;
                    case 2:
                        z = reader.ReadInt32();
                        break;
                    case 3:
                        w = reader.ReadInt32();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var result = new Vector4I(x, y, z, w);
            return result;
        }
    }

    public sealed class ColorFormatter : IMessagePackFormatter<Color>
    {
        public void Serialize(ref MessagePackWriter writer, Color value, MessagePackSerializerOptions options)
        {
            writer.WriteArrayHeader(4);
            writer.Write(value.R);
            writer.Write(value.G);
            writer.Write(value.B);
            writer.Write(value.A);
        }

        public Color Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.IsNil)
            {
                throw new InvalidOperationException("type code is null, struct not supported");
            }

            var length = reader.ReadArrayHeader();
            var r = default(byte);
            var g = default(byte);
            var b = default(byte);
            var a = default(byte);

            for (int i = 0; i < length; i++)
            {
                var key = i;
                switch (key)
                {
                    case 0:
                        r = reader.ReadByte();
                        break;
                    case 1:
                        g = reader.ReadByte();
                        break;
                    case 2:
                        b = reader.ReadByte();
                        break;
                    case 3:
                        a = reader.ReadByte();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var result = new Color(r, g, b, a);
            return result;
        }
    }

    public sealed class RectFFormatter : IMessagePackFormatter<RectF>
    {
        public void Serialize(ref MessagePackWriter writer, RectF value, MessagePackSerializerOptions options)
        {
            writer.WriteArrayHeader(4);
            writer.Write(value.X);
            writer.Write(value.Y);
            writer.Write(value.Width);
            writer.Write(value.Height);
        }

        public RectF Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.IsNil)
            {
                throw new InvalidOperationException("type code is null, struct not supported");
            }

            var length = reader.ReadArrayHeader();
            var x = default(float);
            var y = default(float);
            var width = default(float);
            var height = default(float);

            for (int i = 0; i < length; i++)
            {
                var key = i;
                switch (key)
                {
                    case 0:
                        x = reader.ReadSingle();
                        break;
                    case 1:
                        y = reader.ReadSingle();
                        break;
                    case 2:
                        width = reader.ReadSingle();
                        break;
                    case 3:
                        height = reader.ReadSingle();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var result = new RectF(x, y, width, height);
            return result;
        }
    }

    public sealed class RectIFormatter : IMessagePackFormatter<RectI>
    {
        public void Serialize(ref MessagePackWriter writer, RectI value, MessagePackSerializerOptions options)
        {
            writer.WriteArrayHeader(4);
            writer.Write(value.X);
            writer.Write(value.Y);
            writer.Write(value.Width);
            writer.Write(value.Height);
        }

        public RectI Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.IsNil)
            {
                throw new InvalidOperationException("type code is null, struct not supported");
            }

            var length = reader.ReadArrayHeader();
            var x = default(int);
            var y = default(int);
            var width = default(int);
            var height = default(int);

            for (int i = 0; i < length; i++)
            {
                var key = i;
                switch (key)
                {
                    case 0:
                        x = reader.ReadInt32();
                        break;
                    case 1:
                        y = reader.ReadInt32();
                        break;
                    case 2:
                        width = reader.ReadInt32();
                        break;
                    case 3:
                        height = reader.ReadInt32();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var result = new RectI(x, y, width, height);
            return result;
        }
    }

    public sealed class Matrix33FFormatter : IMessagePackFormatter<Matrix33F>
    {
        public void Serialize(ref MessagePackWriter writer, Matrix33F value, MessagePackSerializerOptions options)
        {
            writer.WriteArrayHeader(9);
            for(int x = 0; x < 3; x++)
            {
                for(int y = 0; y < 3; y++)
                {
                    writer.Write(value[x, y]);
                }
            }
        }

        public Matrix33F Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.IsNil)
            {
                throw new InvalidOperationException("type code is null, struct not supported");
            }

            var length = reader.ReadArrayHeader();
            var result = new Matrix33F();
            for (int i = 0; i < length; i++)
            {
                if (i > 9)
                {
                    reader.Skip();
                    continue;
                }

                result[i / 3, i % 3] = reader.ReadSingle();
            }
            return result;
        }
    }

    public sealed class Matrix44FFormatter : IMessagePackFormatter<Matrix44F>
    {
        public void Serialize(ref MessagePackWriter writer, Matrix44F value, MessagePackSerializerOptions options)
        {
            writer.WriteArrayHeader(16);
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    writer.Write(value[x, y]);
                }
            }
        }

        public Matrix44F Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.IsNil)
            {
                throw new InvalidOperationException("type code is null, struct not supported");
            }

            var length = reader.ReadArrayHeader();
            var result = new Matrix44F();
            for (int i = 0; i < length; i++)
            {
                if (i > 16)
                {
                    reader.Skip();
                    continue;
                }

                result[i / 4, i % 4] = reader.ReadSingle();
            }
            return result;
        }
    }

    public sealed class Matrix33IFormatter : IMessagePackFormatter<Matrix33I>
    {
        public void Serialize(ref MessagePackWriter writer, Matrix33I value, MessagePackSerializerOptions options)
        {
            writer.WriteArrayHeader(9);
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    writer.Write(value[x, y]);
                }
            }
        }

        public Matrix33I Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.IsNil)
            {
                throw new InvalidOperationException("type code is null, struct not supported");
            }

            var length = reader.ReadArrayHeader();
            var result = new Matrix33I();
            for (int i = 0; i < length; i++)
            {
                if (i > 9)
                {
                    reader.Skip();
                    continue;
                }

                result[i / 3, i % 3] = reader.ReadInt32();
            }
            return result;
        }
    }

    public sealed class Matrix44IFormatter : IMessagePackFormatter<Matrix44I>
    {
        public void Serialize(ref MessagePackWriter writer, Matrix44I value, MessagePackSerializerOptions options)
        {
            writer.WriteArrayHeader(16);
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    writer.Write(value[x, y]);
                }
            }
        }

        public Matrix44I Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.IsNil)
            {
                throw new InvalidOperationException("type code is null, struct not supported");
            }

            var length = reader.ReadArrayHeader();
            var result = new Matrix44I();
            for (int i = 0; i < length; i++)
            {
                if (i > 16)
                {
                    reader.Skip();
                    continue;
                }

                result[i / 4, i % 4] = reader.ReadInt32();
            }
            return result;
        }
    }
}
