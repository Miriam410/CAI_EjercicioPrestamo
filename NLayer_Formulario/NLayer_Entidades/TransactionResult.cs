using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer_Entidades
{
    public class TransactionResult
    {
        private bool _isOk;
        private string _error;
        private int _id;

        public bool IsOk
        {
            get { return this._isOk; }
            set { this._isOk = value; }
        }

        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

    }
}
