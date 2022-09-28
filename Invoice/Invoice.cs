using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class Invoice
    {
        private readonly int _account;
        private readonly string _provider;
        private readonly string _customer;

        private string _article;
        private int _quantity;

        public Invoice(int account, string provider, string customer, string article, int quantity)
        {
            _account = account;
            _provider = provider;
            _customer = customer;
            _article = article;
            _quantity = quantity;
        }

        public double GetSum(bool UsePdv = true)
        {
            return UsePdv ? _account * _quantity * 1.2 : _quantity * _account;
        }
    }
}
