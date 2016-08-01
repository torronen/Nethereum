﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using NBitcoin.Crypto;
using Nethereum.Core;
using Nethereum.Hex.HexConvertors.Extensions;

namespace Nethereum.Web3
{
    public class TransactionSigning
    {
        public string SignTransaction(string key, string to, BigInteger amount, BigInteger nonce)
        {
            var transaction = new Transaction(to, amount, nonce);
            transaction.Sign(new ECKey(key.HexToByteArray(), true));
            return transaction.GetRLPEncoded().ToHex();
        }

        public string SignTransaction(string key, string to, BigInteger amount, BigInteger nonce, string data)
        {
            var transaction = new Transaction(to, amount, nonce, data);
            transaction.Sign(new ECKey(key.HexToByteArray(), true));
            return transaction.GetRLPEncoded().ToHex();
        }

        public string SignTransaction(string key, string to, BigInteger amount, BigInteger nonce, BigInteger gasPrice, BigInteger gasLimit)
        {
            var transaction = new Transaction(to, amount, nonce, gasPrice, gasLimit);
            transaction.Sign(new ECKey(key.HexToByteArray(), true));
            return transaction.GetRLPEncoded().ToHex();
        }

        public string SignTransaction(string key, string to, BigInteger amount, BigInteger nonce, BigInteger gasPrice,
            BigInteger gasLimit, string data) 
        {
            var transaction = new Transaction(to, amount, nonce, gasPrice, gasLimit, data);
            transaction.Sign(new ECKey(key.HexToByteArray(), true));
            return transaction.GetRLPEncoded().ToHex();
        }
    }
}