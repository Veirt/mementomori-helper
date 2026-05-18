using System.Runtime.CompilerServices;
using MementoMori.Ortega.Share.Enums;
using MessagePack;

namespace MementoMori.Ortega.Share.Data.DtoInfo
{
    [MessagePackObject(true)]
    public class UserDeckDtoInfo
    {
        public int DeckNo { get; set; }

        public DeckUseContentType DeckUseContentType { get; set; }

        public long DeckBattlePower { get; set; }

        public string UserCharacterGuid1 { get; set; }

        public long CharacterId1 { get; set; }

        public string UserCharacterGuid2 { get; set; }

        public long CharacterId2 { get; set; }

        public string UserCharacterGuid3 { get; set; }

        public long CharacterId3 { get; set; }

        public string UserCharacterGuid4 { get; set; }

        public long CharacterId4 { get; set; }

        public string UserCharacterGuid5 { get; set; }

        public long CharacterId5 { get; set; }

        public List<string> GetUserCharacterGuids()
        {
            var result = new List<string>(5);
            if (!string.IsNullOrEmpty(UserCharacterGuid1)) result.Add(UserCharacterGuid1);
            if (!string.IsNullOrEmpty(UserCharacterGuid2)) result.Add(UserCharacterGuid2);
            if (!string.IsNullOrEmpty(UserCharacterGuid3)) result.Add(UserCharacterGuid3);
            if (!string.IsNullOrEmpty(UserCharacterGuid4)) result.Add(UserCharacterGuid4);
            if (!string.IsNullOrEmpty(UserCharacterGuid5)) result.Add(UserCharacterGuid5);
            return result;
        }

        public List<long> GetCharacterIds()
        {
            var result = new List<long>(5);
            if (CharacterId1 > 0) result.Add(CharacterId1);
            if (CharacterId2 > 0) result.Add(CharacterId2);
            if (CharacterId3 > 0) result.Add(CharacterId3);
            if (CharacterId4 > 0) result.Add(CharacterId4);
            if (CharacterId5 > 0) result.Add(CharacterId5);
            return result;
        }

        public List<long> GetOpponentCharacterIds()
        {
            var result = new List<long>(5);
            if (CharacterId1 > 0) result.Add(CharacterId1);
            if (CharacterId2 > 0) result.Add(CharacterId2);
            if (CharacterId3 > 0) result.Add(CharacterId3);
            if (CharacterId4 > 0) result.Add(CharacterId4);
            if (CharacterId5 > 0) result.Add(CharacterId5);
            return result;
        }

        public UserDeckDtoInfo()
        {
        }
    }
}