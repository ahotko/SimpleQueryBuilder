using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueryBuilder
{
    public partial class Builder
    {

        public Builder Query(string tableName)
        {
            return this;
        }

        public Builder Query(string tableName, string alias)
        {
            return this;
        }
    }
}
