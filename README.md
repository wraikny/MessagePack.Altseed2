# MessagePack.Altseed2

MessagePack.Altseed2 is a
[MessagePack-CSharp](https://github.com/neuecc/MessagePack-CSharp)
extension library for
[Altseed2 for .NET](https://github.com/altseed/altseed2-csharp).

## Usage
```C#
using System;
using Altseed2;
using MessagePack;
using MessagePack.Altseed2;

class Program
{
    static void Main(string[] args)
    {
        // setup
        var resolver = CompositeResolver.Create(
            Altseed2Resolver.Instance,
            StandardResolver.Instance
        );

        var options = MessagePackSerializerOptions.Standard.WithResolver(resolver);

        MessagePackSerializer.DefaultOptions = options;

        /* write code below */

        var v = new Vector2F(1.0f, 2.0f);
        var bytes = MessagePackSerializer.Serialize(v);
        var v2 = MessagePackSerializer.Deserialize<Vector2F>(bytes);

        Console.WriteLine(v == v2);
    }
}
```

## Supported Types

- Vector2F
- Vector3F
- Vector4F
- Vector2I
- Vector3I
- Vector4I
- RectF
- RectI
- Color
- Matrix33F
- Matrix44F
- Matrix33I
- Matrix44I
