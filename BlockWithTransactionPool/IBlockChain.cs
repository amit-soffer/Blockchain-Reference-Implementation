﻿namespace BlockChainCourse.BlockWithMultipleTransactions
{
    public interface IBlockChain
    {
        void AcceptBlock(IBlock block);
        int NextBlockNumber { get; }
        void VerifyChain();
    }
}
