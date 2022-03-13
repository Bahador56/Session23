using System;

namespace Common
{
    public static class GeneralEnums
    {
        public enum InsertResult :int
        {
           Unknown=0,
           Success=1,
           ValidationError=-1,
           Conflict=-2,
           Duplicated=-3,
           Error=-100

        }
        public enum UpdateResult : int
        {
            Unknown = 0,
            Success = 1,
            ValidationError = -1,
            Conflict = -2,
            Duplicated = -3,
            NotFound = -4,
            Error = -100
            
        }
        public enum DeleteResult : int
        {
            Unknown = 0,
            Success = 1,
            ValidationError = -1,
            Conflict = -2,
            NotFound = -3,
            Error = -100

        }
    }
}
