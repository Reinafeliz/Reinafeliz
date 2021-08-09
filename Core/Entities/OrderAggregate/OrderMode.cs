using System.Runtime.Serialization;

namespace Core.Entities.OrderAggregate
{
    public enum OrderMode
    {
         [EnumMember(Value = "APP")]
        APP,

        [EnumMember(Value = "POS")]
        POS,

        [EnumMember(Value = "Room Service")]
        RoomService
    }
}
