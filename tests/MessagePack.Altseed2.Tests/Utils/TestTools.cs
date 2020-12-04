namespace MessagePack.Altseed2.Tests.Utils
{
    static class TestTools
    {
        public static T Convert<T>(T value)
        {
            return MessagePackSerializer.Deserialize<T>(MessagePackSerializer.Serialize(value));
        }
    }
}
