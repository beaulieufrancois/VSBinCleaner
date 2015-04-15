// Guids.cs
// MUST match guids.h
using System;

namespace FBeaulieu.BinCleaner
{
    static class GuidList
    {
        public const string guidBinCleanerPkgString = "46a6f769-4dad-4ff8-aae0-cb707d640e48";
        public const string guidBinCleanerCmdSetString = "92797856-a4eb-49be-af7c-d4721ddee571";

        public static readonly Guid guidBinCleanerCmdSet = new Guid(guidBinCleanerCmdSetString);
    };
}