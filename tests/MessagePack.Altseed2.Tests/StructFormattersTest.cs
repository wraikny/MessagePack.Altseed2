using Altseed2;
using Xunit;
using MessagePack.Altseed2.Tests.Utils;

namespace MessagePack.Altseed2.Tests
{
    [Collection("ResolverCollection")]
    public class StructFormattersTest
    {
        [Fact]
        public void Vector2FTest()
        {
            var inputs = new Vector2F[] {
                default,
                new Vector2F(1.0f, 2.0f),
            };

            foreach (var input in inputs)
            {
                Assert.Equal(TestTools.Convert(input), input);
            }
        }

        [Fact]
        public void Vector3FTest()
        {
            var inputs = new Vector3F[] {
                default,
                new Vector3F(1.0f, 2.0f, 3.0f),
            };

            foreach (var input in inputs)
            {
                Assert.Equal(TestTools.Convert(input), input);
            }
        }

        [Fact]
        public void Vector4FTest()
        {
            var inputs = new Vector4F[] {
                default,
                new Vector4F(1.0f, 2.0f, 3.0f, 4.0f),
            };

            foreach (var input in inputs)
            {
                Assert.Equal(TestTools.Convert(input), input);
            }
        }

        [Fact]
        public void Vector2ITest()
        {
            var inputs = new Vector2I[] {
                default,
                new Vector2I(1, 2),
            };

            foreach (var input in inputs)
            {
                Assert.Equal(TestTools.Convert(input), input);
            }
        }

        [Fact]
        public void Vector3ITest()
        {
            var inputs = new Vector3I[] {
                default,
                new Vector3I(1, 2, 3),
            };

            foreach (var input in inputs)
            {
                Assert.Equal(TestTools.Convert(input), input);
            }
        }

        [Fact]
        public void Vector4ITest()
        {
            var inputs = new Vector4F[] {
                default,
                new Vector4I(1, 2, 3, 4),
            };

            foreach (var input in inputs)
            {
                Assert.Equal(TestTools.Convert(input), input);
            }
        }

        [Fact]
        public void RectFTest()
        {
            var inputs = new RectF[] {
                default,
                new RectF(1.0f, 2.0f, 3.0f, 4.0f),
            };

            foreach (var input in inputs)
            {
                Assert.Equal(TestTools.Convert(input), input);
            }
        }

        [Fact]
        public void RectITest()
        {
            var inputs = new RectI[] {
                default,
                new RectI(1, 2, 3, 4),
            };

            foreach (var input in inputs)
            {
                Assert.Equal(TestTools.Convert(input), input);
            }
        }

        [Fact]
        public void ColorTest()
        {
            var inputs = new Color[] {
                default,
                new Color(1, 2, 3, 4),
            };

            foreach (var input in inputs)
            {
                Assert.Equal(TestTools.Convert(input), input);
            }
        }

        [Fact]
        public void Matrix33FTest()
        {
            var inputs = new Matrix33F[] {
                default,
                Matrix33F.Identity,
                Matrix33F.GetRotation(12.3f),
            };

            foreach (var input in inputs)
            {
                Assert.Equal(TestTools.Convert(input), input);
            }
        }

        [Fact]
        public void Matrix44FTest()
        {
            var inputs = new Matrix44F[] {
                default,
                Matrix44F.Identity,
                Matrix44F.GetQuaternion(new Vector4F(1.0f, 2.0f, 3.0f, 4.0f)),
            };

            foreach (var input in inputs)
            {
                Assert.Equal(TestTools.Convert(input), input);
            }
        }

        [Fact]
        public void Matrix33ITest()
        {
            var inputs = new Matrix33I[] {
                default,
                Matrix33I.Identity,
            };

            foreach (var input in inputs)
            {
                Assert.Equal(TestTools.Convert(input), input);
            }
        }

        [Fact]
        public void Matrix44ITest()
        {
            var inputs = new Matrix44I[] {
                default,
                Matrix44I.Identity,
            };

            foreach (var input in inputs)
            {
                Assert.Equal(TestTools.Convert(input), input);
            }
        }
    }
}
