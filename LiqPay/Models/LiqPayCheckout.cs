using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LiqPay.Models
{
    /// <summary>
    /// Data параметри LiqPay (більше параметрів тут: https://www.liqpay.ua/documentation/api/aquiring/checkout/doc)
    /// </summary>
    public class LiqPayCheckout
    {
        // --- Обов'язкові параметри:
        public int version { get; set; }
        public string public_key { get; set; }
        public string action { get; set; }
        public decimal amount { get; set; }
        public string currency { get; set; }
        public string description { get; set; }
        public string order_id { get; set; }

        // --- Не обов'язкові:
        public string expired_date { get; set; }
        public string language { get; set; }
        public string paytypes { get; set; }
        public string result_url { get; set; }
        public string server_url { get; set; }
        public string verifycode { get; set; }

        // Додаткова інформація:
        public string info { get; set; }
        [StringLength(25)]
        public string product_category { get; set; }
        [StringLength(500)]
        public string product_description { get; set; }
        [StringLength(100)]
        public string product_name { get; set; }
        [StringLength(2000)]
        public string product_url { get; set; }

        /// <summary>
        /// Тестовий режим: 1 - так, 0 - ні. (в тестовому режимі гроші не знімаються)
        /// </summary>
        public int sandbox { get; set; }
    }
}