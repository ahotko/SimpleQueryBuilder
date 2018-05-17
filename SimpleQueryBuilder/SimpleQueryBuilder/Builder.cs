using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueryBuilder
{
    public partial class Builder
    {
        private string _tableName = String.Empty;
        private string _tableAlias = String.Empty;
        private Collection<string> _fieldNames = null;

        public Builder Query(string tableName)
        {
            _tableName = tableName.ToUpper();
            _tableAlias = tableName.Substring(0, 1).ToLower();
            return this;
        }

        public Builder Query(string tableName, string alias)
        {
            _tableName = tableName.ToUpper();
            _tableAlias = alias.ToLower();
            return this;
        }
    }
}
