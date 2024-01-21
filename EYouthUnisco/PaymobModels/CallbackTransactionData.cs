﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EYouthUnisco.Domain.PaymobModels
{
    public class CallbackTransactionData
    {

        [JsonPropertyName("bill_reference")]
        public int? BillReference { get; init; }

        [JsonPropertyName("gateway_integration_pk")]
        public int? GatewayIntegrationPk { get; init; }

        [JsonPropertyName("captured_amount")]
        public decimal? CapturedAmount { get; init; }

        [JsonPropertyName("refunded_amount")]
        public decimal? RefundedAmount { get; init; }

        [JsonPropertyName("transaction_no")]
        public string? TransactionNo { get; init; }

        [JsonPropertyName("authorize_id")]
        public string? AuthorizeId { get; init; }

        [JsonPropertyName("merchant_txn_ref")]
        public string? MerchantTxnRef { get; init; }

        [JsonPropertyName("authorised_amount")]
        public decimal AuthorisedAmount { get; init; }

        [JsonPropertyName("amount")]
        public decimal Amount { get; init; }

        [JsonPropertyName("merchant")]
        public string Merchant { get; init; }

        [JsonPropertyName("card_type")]
        public string CardType { get; init; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; init; }

        [JsonPropertyName("avs_result_code")]
        public string? AvsResultCode { get; init; }

        [JsonPropertyName("card_num")]
        public string? CardNum { get; init; }

        [JsonPropertyName("avs_acq_response_code")]
        public string? AvsAcqResponseCode { get; init; }

        [JsonPropertyName("txn_response_code")]
        public string? TxnResponseCode { get; init; }

        [JsonPropertyName("acq_response_code")]
        public string? AcqResponseCode { get; init; }

        [JsonPropertyName("receipt_no")]
        public string? ReceiptNo { get; init; }

        [JsonPropertyName("secure_hash")]
        public string? SecureHash { get; init; }

        [JsonPropertyName("klass")]
        public string? Klass { get; init; }

        [JsonPropertyName("message")]
        public string? Message { get; init; }

        [JsonPropertyName("currency")]
        public string Currency { get; init; }

        [JsonPropertyName("migs_result")]
        public string? MigsResult { get; init; }

        [JsonPropertyName("batch_no")]
        public int BatchNo { get; init; }

        [JsonPropertyName("order_info")]
        public string? OrderInfo { get; init; }

        [JsonPropertyName("migs_transaction")]
        public CallbackTransactionDataMigsTransaction MigsTransaction { get; init; } = default!;

        [JsonPropertyName("migs_order")]
        public CallbackTransactionDataMigsOrder MigsOrder { get; init; } = default!;

        [JsonExtensionData]
        public IDictionary<string, object?>? ExtensionData { get; init; }

    }
}
