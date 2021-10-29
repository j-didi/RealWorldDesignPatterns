﻿using RealWorldDesignPatterns.RulesEngine.Common;
using RealWorldDesignPatterns.RulesEngine.Contract;

namespace RealWorldDesignPatterns.RulesEngine.Rules
{
    public interface ITransactionRule
    {
        void Evaluate(
            BankAccount account,
            TransactionOperation transaction,
            OperationResult result
        );
    }
}